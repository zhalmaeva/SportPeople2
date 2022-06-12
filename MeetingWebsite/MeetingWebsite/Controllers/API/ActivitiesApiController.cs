using MeetingWebsite.Models;
using MeetingWebsite.ModelsView;
using MeetingWebsite.ModelsView.Activities;
using MeetingWebsite.ModelsView.UserModels;
using MeetingWebsite.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.Controllers
{
    [Route("api/Activities")]
    [ApiController]
    [Authorize]
    public class ActivitiesApiController : _BaseApiController
    {
        private readonly ActivitiesRepository _activitiesRepository;
        private readonly UsersRepository _usersRepository;

        public ActivitiesApiController(ActivitiesRepository activitiesRepository, UsersRepository usersRepository)
            : base(usersRepository)
        {
            _activitiesRepository = activitiesRepository;
            _usersRepository = usersRepository;
        }
      
        [HttpPost("")]
        public async Task<IActionResult> Create(NewActivityModel model)
        {
            try
            {
                var activity = model.ToDbModel();
                activity.UserId = CurrentUserId();                
                activity.ActivityUsers.Add(new ActivityUsers() { UserId = CurrentUserId(), ActivityId = activity.Id });
                activity.CountUser = 1;
                //if (!await _activitiesRepository.AddUsers(activityUsers)) { };
                if(!await _activitiesRepository.Add(activity))
                {
                    return StatusCode(500, "Не удалось добавит. Сообщите нам об этой ошибке");
                }
                //var _query = _activitiesRepository.GetList().Include(p => p.UserId);
                //var _activity = await _query.FirstOrDefaultAsync();

                return Ok(activity.Id);
            }
            catch
            {
                throw new Exception("Не удалось добавить activity");
            }
        }

        [HttpPut("")]
        public async Task<IActionResult> AddUser(string sgh, List<int> activityId)
        {
            activityId = activityId.Distinct().ToList();
            var actId = activityId.First();
            var activity = await _activitiesRepository.Find(actId);
            if (activity == null)
            {
                return StatusCode(404, "Не удалось найти событие с данным идентификатором: "+ actId.ToString());
            }
            var activityUser = new ActivityUsers() { UserId = CurrentUserId(), ActivityId = actId };
            activity.ActivityUsers.Add(activityUser);
            activity.CountUser += 1;
            var actUser = activityId.Select(p => new ActivityUsers(CurrentUserId(), p)).ToList();
            if (!await _activitiesRepository.Update(activity) && !await _activitiesRepository.AddUsers(actUser))
            {
                return StatusCode(500, "Не удалось присоединиться к мероприятию 2");
            }
            //else
            //if ()
            //{
            //    return StatusCode(500, "Не удалось присоединиться к мероприятию 1");
            //}
            

            return Ok();
        }

        [HttpGet("{activityId}")]
        public async Task<IActionResult> GetActivity(int activityId)
        {
            var peoples = await _usersRepository.GetList()
                .Include(p => p.ActivityUsers)
                .ThenInclude(p => p.Activity)
                .Where(p => p.ActivityUsers.Any(x => x.ActivityId == activityId))
                .ToListAsync();

            var result = peoples.Select(p => new UserView(p)).ToList();

            return Ok(result ?? new List<UserView>());
        }
    }
}
