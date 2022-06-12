using MeetingWebsite.ModelsView.News;
using MeetingWebsite.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.Controllers.API
{
    [Route("api/News")]
    [ApiController]
    [Authorize]
    public class NewsApiController : _BaseApiController
    {
        private readonly NewsRepository _newsRepoSitory;
        public NewsApiController(NewsRepository newsRepository)
            : base(newsRepository)
        {
            _newsRepoSitory = newsRepository;

        }

        [HttpPost("")]
        public async Task<IActionResult> Create(AddNewView model)
        {
            try
            {
                var newNew = model.ToDbModel();
                newNew.UserId = CurrentUserId();
                if (!await _newsRepository.Add(newNew))
                {
                    return StatusCode(500, "Не удалось добавить новость. Сообщите нам об этой ошибке");
                }
                return Ok(newNew.Id);
            }
            catch
            {
                throw new Exception("Не удалось добавить новость");
            }
        }

    }
}
