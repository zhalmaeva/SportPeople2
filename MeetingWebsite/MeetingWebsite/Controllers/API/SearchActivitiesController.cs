using MeetingWebsite.Models;
using MeetingWebsite.ModelsView;
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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SearchActivitiesController : _BaseApiController
    {
        public SearchActivitiesController(ActivitiesRepository activitiesRepository) : base(activitiesRepository)
        {
        }
        /// <summary>
        /// Поиск событий по параметрам
        /// </summary>
        /// <returns>Возвращает максимум 25 событий</returns>
        [HttpGet("")]
        public async Task<IActionResult> SerachActivitiesParam(SportKind sportKind, Level level)
        {
            var query = _activitiesRepository.GetList()                            
                            .Where(p => p.SportKind == sportKind && p.level == level);

            var activities = (await query.Take(25)
                            .ToListAsync())
                            .Select(p => new ActivityView(p))
                            .ToList();
            return Ok(activities);
        }
    }
}
