using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Infrastructure.Data.Models
{
    public class StrenghtTrainingParticipant
    {
        [Required]
        public string ParticipantId { get; set; } = string.Empty;
        [ForeignKey(nameof(ParticipantId))]
        public IdentityUser Participant { get; set; } = null!;
        [Required]
        public int StrenghtTrainingId { get; set; }
        [ForeignKey(nameof(StrenghtTrainingId))]
        public StrenghtTraining StrenghtTraining { get; set; } = null!;
    }
}
