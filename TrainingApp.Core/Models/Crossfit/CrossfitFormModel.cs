using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static TrainingApp.Core.Constants.MessageConstants;

namespace TrainingApp.Core.Models.Crossfit
{
    public class CrossfitFormModel
    {
        [Required(ErrorMessage = RequiredMassage)]
        [Display(Name = "Duration in minutes")]
        public int Duration { get; set; }

        [Required(ErrorMessage = RequiredMassage)]
        public string Date { get; set; } = null!;
    }
}
