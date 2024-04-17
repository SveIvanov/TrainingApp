using System.ComponentModel.DataAnnotations;
using static TrainingApp.Core.Constants.MessageConstants;
using static TrainingApp.Infrastructure.Constants.DataConstants;

namespace TrainingApp.Core.Models.CardioTraining
{
    public class CardioTrainingFormModel
    {
        [Required(ErrorMessage = RequiredMassage)]
        [StringLength(CardioTypeMaxLenght, MinimumLength = CardioTypeMinLenght, ErrorMessage = LenghtMassage)]
        [Display(Name = "Type")]
        public string Type { get; set; } = null!;
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Duration in minutes")]
        public int Duration { get; set; }
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Distance in meters")]
        public int Distance { get; set; }
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Date")]
        [RegularExpression(DateRegex, ErrorMessage = DateFormatMassage)]
        public string Date { get; set; } = null!;
    }
}
