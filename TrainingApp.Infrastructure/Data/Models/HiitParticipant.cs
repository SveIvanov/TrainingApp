using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Infrastructure.Data.Models
{
    public class HiitParticipant
    {
        [Required]
        public string ParticipantId { get; set; } = string.Empty;
        [ForeignKey(nameof(ParticipantId))]
        public IdentityUser Participant { get; set; } = null!;
        [Required]
        public int HiitId { get; set; }
        [ForeignKey(nameof(HiitId))]
        public Hiit Hiit { get; set; } = null!;
    }
}
