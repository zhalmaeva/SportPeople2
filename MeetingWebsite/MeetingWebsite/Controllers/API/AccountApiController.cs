using MeetingWebsite.ModelsView.UserModels;
using MeetingWebsite.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.Controllers
{
    [Route("api/Account")]
    [ApiController]
    [Authorize]


    public class AccountApiController : _BaseApiController
    {
        private readonly UsersRepository _usersRepository;

        public AccountApiController(UsersRepository usersRepository)
            : base(usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost("")]
        public async Task<IActionResult> Create(UserView model)
        {
            try
            {
                var user = model.ToDbModel();
                
                if (!await _userRepository.Update(user))
                {
                    return StatusCode(500, "Не удалось изменить данные. Сообщите нам об этой ошибке");
                }
                //var _query = _activitiesRepository.GetList().Include(p => p.UserId);
                //var _activity = await _query.FirstOrDefaultAsync();

                return Ok();
            }
            catch
            {
                throw new Exception("Не удалось добавить activity");
            }
        }
    }
}
