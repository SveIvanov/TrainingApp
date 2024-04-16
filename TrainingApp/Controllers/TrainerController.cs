using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Trainer;

namespace TrainingApp.Controllers
{
    
    public class TrainerController : BaseController
    {
        private readonly ITrainerService _trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            var model = new BecomeTrainerFormModel();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeTrainerFormModel model)
        {
            return RedirectToAction(nameof(HomeController.Index),"Home");
        }

    }
}
