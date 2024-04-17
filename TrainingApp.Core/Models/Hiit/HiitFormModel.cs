using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingApp.Infrastructure.Constants.DataConstants;
using static TrainingApp.Core.Constants.MessageConstants;

namespace TrainingApp.Core.Models.Hiit
{
    public class HiitFormModel
    {
        [Required(ErrorMessage = RequiredMassage)]
        [StringLength(HiitTypeMaxLenght, MinimumLength = HiitTypeMinLenght, ErrorMessage = LenghtMassage)]
        [Display(Name = "Type")]
        public string Type { get; set; } = null!;
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Duration in minutes")]
        public int Duration { get; set; }
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Intervals")]
        public int Intervals { get; set; }
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Date")]
        [RegularExpression(DateRegex,ErrorMessage = DateFormatMassage)]
        public string Date { get; set; } = null!;


    }
}
