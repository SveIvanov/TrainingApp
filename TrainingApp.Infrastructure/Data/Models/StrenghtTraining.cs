using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingApp.Infrastructure.Constants.DataConstants;

namespace TrainingApp.Infrastructure.Data.Models
{
    [Comment("Strenght Training")]
    public class StrenghtTraining
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(BodyPartMaxLenght)]
        public string BodyPart { get; set; } = string.Empty;
        [Required]
        public int DurationInMinutes { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public string? ParticipantId { get; set; }
        [Required]
        public int TrainerId { get; set; }
        [ForeignKey(nameof(TrainerId))]
        public Trainer Trainer { get; set; } = null!;



    }
}
