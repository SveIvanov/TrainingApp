using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class StrenghtTrainingController : Controller
    {
        private readonly IStrenghtTrainingServices _strenghtTrainingServices;

        public StrenghtTrainingController(IStrenghtTrainingServices strenghtTrainingServices)
        {
            _strenghtTrainingServices = strenghtTrainingServices;
        }
        
        public async Task<IActionResult> All()
        {
            var model = await _strenghtTrainingServices.TakeAll();
            return View(model);
        }
    }
}
