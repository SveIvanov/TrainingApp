using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Infrastructure.Data.Models;


namespace TrainingApp.Core.Models.Hiit
{
    public class AllHiitModel
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;

        public int Intervals { get; set; }

        public int Duration { get; set; }

        public string Date { get; set; } = null!;

        public string Trainer { get; set; } = null!;

        public string TrainerEmail { get; set; } = null!;
    }
}

//[Key]
//public int Id { get; set; }
//[Required]
//[MaxLength(HiitTypeMaxLenght)]
//public string Type { get; set; } = string.Empty;
//[Required]
//public int DurationInMinutes { get; set; }
//[Required]
//public int Intervals { get; set; }
//[Required]
//public DateTime Date { get; set; }

//public string? ParticipantId { get; set; }

//[Required]
//public int TrainerId { get; set; }
//[ForeignKey(nameof(TrainerId))]
//public Trainer Trainer { get; set; } = null!;
