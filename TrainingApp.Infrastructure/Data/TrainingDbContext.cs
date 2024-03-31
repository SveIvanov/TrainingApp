using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TrainingApp.Infrastructure.Data.Models;
using TrainingApp.Infrastructure.Data.SeedDB;

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

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new TrainerConfiguration());
            builder.ApplyConfiguration(new HiitConfiguration());
            builder.ApplyConfiguration(new CrossfitConfiguration());
            builder.ApplyConfiguration(new CardioTrainingConfiguration());
            builder.ApplyConfiguration(new StrenghtTrainingConfiguration());


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

        public DbSet<CardioTraining> CardioTrainings { get; set; } = null!;

        public DbSet<CardioTrainingParticipant> CardioTrainingsParticipants { get; set; } = null!;
        public DbSet<Crossfit> Crossfits { get; set; } = null!; 
        public DbSet<CrossfitParticipant> CrossfitsParticipants { get; set; } = null!;  
        public DbSet<Hiit> Hiits { get; set; } = null!; 
        public DbSet<HiitParticipant> HiitsParticipants { get; set; } = null!;  
        public DbSet<StrenghtTraining> StrenghtTrainings { get; set; } = null!; 
        public DbSet<StrenghtTrainingParticipant> StrenghtTrainingsParticipants { get; set; } = null!;  
        public DbSet<Trainer> Trainers { get; set; } = null!;   
    }
}