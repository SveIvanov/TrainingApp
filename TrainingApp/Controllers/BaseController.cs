﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
            
    }
}
