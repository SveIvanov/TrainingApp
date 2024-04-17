using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Trainer;
using TrainingApp.Extensions;

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
            if (await _trainerService.ExistByIDAsync(User.Id()))
            {
                return BadRequest();
            }
            
            var model = new BecomeTrainerFormModel();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeTrainerFormModel model)
        {
            if (await _trainerService.ExistByIDAsync(User.Id()))
            {
                return BadRequest();
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await _trainerService.CreateAsync(User.Id(), model.Name);

            return RedirectToAction(nameof(HomeController.Index),"Home");
        }

    }
}
