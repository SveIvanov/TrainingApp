using Microsoft.AspNetCore.Identity;
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
    public class Trainer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(TrainerNameMaxLenght)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IEnumerable<Hiit> Hiits { get; set; } = new List<Hiit>();

        public IEnumerable<CardioTraining> CardioTrainings { get; set; } = new List<CardioTraining>();

        public IEnumerable<StrenghtTraining> StrenghtTrainings { get; set; } = new List<StrenghtTraining>();


        public IEnumerable<Crossfit> Crossfits { get; set; } = new List<Crossfit>();
    }
}
