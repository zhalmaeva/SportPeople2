using MeetingWebsite.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.Controllers
{
    [Authorize]
    public class NewsController : BaseController
    {
        public NewsController(NewsRepository newsRepository) : base(newsRepository)
        {
        }
        public IActionResult Index()
        {
            var activities = _newsRepository.GetList().ToList();
            return View(activities);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult AddNew()
        {
            return View();
        }
    }
}
