using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TrainingApp.Infrastructure.Constants.DataConstants;

namespace TrainingApp.Infrastructure.Data.Models
{
    [Comment("HIIT Training")]
    public class Hiit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(HiitTypeMaxLenght)]
        public string Type { get; set; } = string.Empty;
        [Required]
        public int DurationInMinutes { get; set; }
        [Required]
        public int Intervals { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public string? ParticipantId { get; set; }

        [Required]
        public int TrainerId { get; set; }
        [ForeignKey(nameof(TrainerId))]
        public Trainer Trainer { get; set; } = null!;
    }
}
