using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrainingApp.Infrastructure.Data.Models
{
    [Comment("Crossfit training")]
    public class Crossfit
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int DurationInMinutes { get; set; }
      
        [Required]
        public DateTime Date { get; set; }

        public string? ParticipantId { get; set; }

        [Required]
        public int TrainerId { get; set; }
        [ForeignKey(nameof(TrainerId))]
        public Trainer Trainer { get; set; } = null!;
    }
}
