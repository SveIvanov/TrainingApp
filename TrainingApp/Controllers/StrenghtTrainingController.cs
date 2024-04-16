using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;

namespace TrainingApp.Controllers
{
    
    public class StrenghtTrainingController : BaseController
    {
        private readonly IStrenghtTrainingService _strenghtTrainingService;

        public StrenghtTrainingController(IStrenghtTrainingService strenghtTrainingService)
        {
            _strenghtTrainingService = strenghtTrainingService;
        }
        
        public async Task<IActionResult> All()
        {
            var model = await _strenghtTrainingService.TakeAll();
            return View(model);
        }
    }
}
