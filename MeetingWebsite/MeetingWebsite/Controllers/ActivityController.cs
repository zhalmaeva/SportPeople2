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
    [Authorize]
    public class ActivityController : BaseController
    {
        public ActivityController(ActivitiesRepository activitiesRepository) : base(activitiesRepository)
        {
        }
        public IActionResult Index(int? id = null)
        {
            var activity = _activitiesRepository
                .GetList()
                .FirstOrDefault(p => p.Id == id);
            return View(new ActivityView(activity));
        }
    }
}
