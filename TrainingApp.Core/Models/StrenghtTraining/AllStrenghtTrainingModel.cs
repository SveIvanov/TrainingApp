using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Core.Models.StrenghtTraining
{
	public class AllStrenghtTrainingModel
	{
		public int Id { get; set; }

		public string BodyPart { get; set; } = null!;

		public int Duration { get; set; }

		public int Sets { get; set; }

		public string Date { get; set; } = null!;

        public string Trainer { get; set; } = null!;

        public string TrainerEmail { get; set; } = null!;

    }
}


