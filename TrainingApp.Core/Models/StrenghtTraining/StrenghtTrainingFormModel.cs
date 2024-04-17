using System.ComponentModel.DataAnnotations;
using static TrainingApp.Infrastructure.Constants.DataConstants;
using static TrainingApp.Core.Constants.MessageConstants;

namespace TrainingApp.Core.Models.StrenghtTraining
{
    public class StrenghtTrainingFormModel
    {
        [Required(ErrorMessage = RequiredMassage)]
        [StringLength(BodyPartMaxLenght, MinimumLength = BodyPartMinLenght, ErrorMessage = LenghtMassage)]
        [Display(Name = "BodyPart")]
        public string BodyPart { get; set; } = null!;
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Duration in minutes")]
        public int Duration { get; set; }
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Sets")]
        public int Sets { get; set; }
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Date")]
        [RegularExpression(DateRegex, ErrorMessage = DateFormatMassage)]
        public string Date { get; set; } = null!;
    }
}


