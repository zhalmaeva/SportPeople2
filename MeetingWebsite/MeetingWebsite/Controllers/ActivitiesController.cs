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
    [Authorize]
    public class ActivitiesController : BaseController
    {
        public ActivitiesController(ActivitiesRepository activitiesRepository) : base(activitiesRepository)
        {
        }
        public IActionResult Index()
        {
            var activities = _activitiesRepository.GetList().ToList();
            return View(activities);
        }
        public IActionResult New()
        {
            return View();
        }
    }
}
