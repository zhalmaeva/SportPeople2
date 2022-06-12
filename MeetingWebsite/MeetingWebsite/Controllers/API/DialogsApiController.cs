﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingWebsite.Models;
using MeetingWebsite.ModelsView.Dialogs;
using MeetingWebsite.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetingWebsite.Controllers
{
    [Route("api/Dialogs")]
    [ApiController]
    [Authorize]
    public class DialogsApiController : _BaseApiController
    {
        private readonly DialogsRepository _dialogsRepository;

        public DialogsApiController(DialogsRepository dialogsRepository,
            UsersRepository userRepository)
            : base(userRepository)
        {
            _dialogsRepository = dialogsRepository;
        }

        /// <summary>
        /// Возвращает список диалогов пользователя
        /// </summary>
        [HttpGet("")]
        public async Task<IActionResult> Dialogs()
        {
            var userId = CurrentUserId();

            //var dialogs = (await _userRepository.GetList()
            //    .Include(p => p.DialogsUsers)
            //    .ThenInclude(p => p.Dialog)
            //    .FirstOrDefaultAsync(p => p.Email == emailUser)
            //    )?.DialogsUsers?.Select(p => p.Dialog).ToList();
            var test = _dialogsRepository.GetList();

            var dialogs = await _dialogsRepository.GetList()
                .Include(p => p.DialogsUsers)
                .ThenInclude(p => p.User)
                .Where(p => p.DialogsUsers.Any(x => x.UserId == userId))
                .ToListAsync();

            var result = dialogs
                .Select(p => new DialogView(p)).ToList();

            return Ok(result ?? new List<DialogView>());
        }

        /// <summary>
        /// Создание диалога
        /// </summary>
        /// <param name="title">Название диалога</param>
        /// <param name="usersId">Идентификаторы пользователей-участников</param>
        /// <returns>Возвращает идентификатор созданного диалога</returns>
        [HttpPost("")]
        public async Task<IActionResult> Create(string title, List<int> usersId)
        {
            try
            {
                usersId.Add(CurrentUserId());
                usersId = usersId.Distinct().ToList();
                if (usersId.Count < 2)
                    return StatusCode(400, "Не достаточное количество участников < 2");

                if (usersId.Count == 2)
                {
                    var _query = _dialogsRepository.GetList()
                        .Include(p => p.DialogsUsers)
                        .Where(p => p.DialogsUsers.Count == 2);

                    foreach (var userId in usersId)
                    {
                        _query = _query.Where(p => p.DialogsUsers.Any(x => x.UserId == userId));
                    }


                    var _dialog = await _query.FirstOrDefaultAsync();
                    //.FirstOrDefaultAsync(p => p.DialogsUsers.Any(x => x.User.Id == usersId[0]) && p.DialogsUsers.Any(x => x.User.Id == usersId[1]));
                    if (_dialog != null)
                        return Ok(_dialog.Id);
                }


                var errorUsers = await _userRepository.IsExists(usersId);
                if (errorUsers.Count > 0)
                    return StatusCode(400, $"Пользователи с идентификаторами: {string.Join(", ", errorUsers)} - не найдены");
                //if (string.IsNullOrEmpty(title))
                //    return StatusCode(400, "Название диалога не может быть пустым");

                var currentUserId = CurrentUserId();
                var dialog = new Dialog() { Title = title, CreateUserId = currentUserId };
                if (!await _dialogsRepository.Add(dialog))
                    throw new Exception("Не удалось создать диалог");

                var dialogUsers = usersId.Select(p => new DialogsUsers(p, dialog.Id)).ToList();
                if (!await _dialogsRepository.AddUsers(dialogUsers))
                    throw new Exception("Не удалось добавить пользователей к диалогу");

                return Ok(dialog.Id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Не удалось создать диалог. Сообщите нам об это ошибке");
            }
        }

        /// <summary>
        /// Смена названия диалога
        /// </summary>
        /// <param name="id">Идентификатор диалога</param>
        /// <param name="newTitle">Новое название</param>
        [HttpPut("")]
        public async Task<IActionResult> ChangeTitle(int id, string newTitle)
        {
            var dialog = await _dialogsRepository.Find(id);
            if (dialog == null)
                return StatusCode(404, "Не удалось найди диалог с данным идентификатором");

            //var currentUserId = await CurrentUserId();
            //if (currentUserId != dialog.CreateUserId)
            //    return StatusCode(401, "Менять название диалога может только его создатель");


            dialog.Title = newTitle;
            if (!await _dialogsRepository.Update(dialog))
                return StatusCode(500, "Не удалось изменить название диалога. Сообщите нам об это ошибке");

            return Ok();
        }

        /// <summary>
        /// Удаление диалога
        /// </summary>
        /// <param name="id">Идентификатор диалога</param>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var dialog = await _dialogsRepository.Find(id);
            if (dialog == null)
                return StatusCode(404, "Не удалось найди диалог с данным идентификатором");

            var currentUserId = CurrentUserId();
            if (currentUserId != dialog.CreateUserId)
                return StatusCode(401, "Удалять диалог может только его создатель");

            if (!await _dialogsRepository.Remove(dialog))
                return StatusCode(500, "Не удалось удалить диалог. Сообщите нам об это ошибке");

            return Ok();
        }
    }
}
