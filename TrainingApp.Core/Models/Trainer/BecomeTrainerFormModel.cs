using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingApp.Core.Constants.MessageConstants;
using static TrainingApp.Infrastructure.Constants.DataConstants;

namespace TrainingApp.Core.Models.Trainer
{
	public class BecomeTrainerFormModel
	{
		[Required(ErrorMessage = RequiredMassage)]
		[StringLength(TrainerNameMaxLenght, MinimumLength = TrainerNameMinLenght, ErrorMessage = LenghtMassage)]
		[Display(Name = "Full Name")]
		public string Name { get; set; } = null!;
	}
}
