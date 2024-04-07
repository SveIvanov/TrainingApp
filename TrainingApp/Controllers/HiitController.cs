﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class HiitController : Controller
    {
        public IActionResult All()
        {
            var model = new AllHiitModel();
            return View(model);
        }
    }
}