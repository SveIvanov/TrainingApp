using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingApp.Infrastructure.Constants.DataConstants;
using static TrainingApp.Core.Constants.MessageConstants;

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
        public string Date { get; set; } = null!;
    }
}
