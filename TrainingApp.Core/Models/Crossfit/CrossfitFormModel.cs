using System.ComponentModel.DataAnnotations;
using static TrainingApp.Core.Constants.MessageConstants;
using static TrainingApp.Infrastructure.Constants.DataConstants;


namespace TrainingApp.Core.Models.Crossfit
{
    public class CrossfitFormModel
    {
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Duration in minutes")]
        public int Duration { get; set; }

        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Date")]
        [RegularExpression(DateRegex, ErrorMessage = DateFormatMassage)]
        public string Date { get; set; } = null!;
    }
}
