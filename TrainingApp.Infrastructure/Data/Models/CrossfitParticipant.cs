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
    public class CrossfitParticipant
    {
        [Required]
        public string ParticipantId { get; set; } = string.Empty;
        [ForeignKey(nameof(ParticipantId))]
        public IdentityUser Participant { get; set; } = null!;
        [Required]
        public int CrossfitId { get; set; }
        [ForeignKey(nameof(CrossfitId))]
        public Crossfit Crossfit { get; set; } = null!;
    }
}
