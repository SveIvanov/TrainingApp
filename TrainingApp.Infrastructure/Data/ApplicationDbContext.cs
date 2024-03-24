using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Infrastructure.Data
{
    public class TrainingDbContext : IdentityDbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CardioTrainingParticipant>()
                .HasKey(cp => new { cp.CardioTrainingId, cp.ParticipantId });

            builder.Entity<CrossfitParticipant>()
                .HasKey(crp => new { crp.CrossfitId, crp.ParticipantId });

            builder.Entity<HiitParticipant>()
                .HasKey(hp => new { hp.HiitId, hp.ParticipantId });

            builder.Entity<StrenghtTrainingParticipant>()
                .HasKey(sp => new { sp.StrenghtTrainingId, sp.ParticipantId });

            


        }

        public DbSet<CardioTraining> CardioTrainings { get; set; }

        public DbSet<CardioTrainingParticipant> CardioTrainingsParticipants { get; set; }
        public DbSet<Crossfit> Crossfits { get; set; }
        public DbSet<CrossfitParticipant> CrossfitsParticipants { get; set; }
        public DbSet<Hiit> Hiits { get; set; }
        public DbSet<HiitParticipant> HiitsParticipants { get; set; }
        public DbSet<StrenghtTraining> StrenghtTrainings { get; set; }
        public DbSet<StrenghtTrainingParticipant> StrenghtTrainingsParticipants { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}