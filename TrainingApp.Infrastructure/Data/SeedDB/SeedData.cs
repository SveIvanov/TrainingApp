using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Infrastructure.Data.SeedDB
{
    internal class SeedData
    {
        public IdentityUser GuestUser { get; set; }

        public IdentityUser TrainerUser { get; set; }

        public Trainer Trainer { get; set; }

        public Hiit Hiit { get; set; }

        public Crossfit Crossfit { get; set; }

        public StrenghtTraining StrenghtTraining { get; set; }

        public CardioTraining CardioTraining { get; set; }
        private void SeedUsers() 
        { 
            var hasher = new PasswordHasher<IdentityUser>(); 
            
            TrainerUser = new IdentityUser() { Id = "dea12856-c198-4129-b3f3-b893d8395082", UserName = "agent@mail.com", NormalizedUserName = "agent@mail.com", Email = "agent@mail.com", NormalizedEmail = "agent@mail.com" }; 
            
            TrainerUser.PasswordHash = hasher.HashPassword(TrainerUser, "agent123"); 
            
            GuestUser = new IdentityUser() { Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", UserName = "guest@mail.com", NormalizedUserName = "guest@mail.com", Email = "guest@mail.com", NormalizedEmail = "guest@mail.com" }; 
            
            GuestUser.PasswordHash = hasher.HashPassword(TrainerUser, "guest123"); 
        }

        private void SeedTrainer() 
        {
            Trainer = new Trainer()
            {
                Id = 1,
                Name = "Ivan Petrov",
                UserId = TrainerUser.Id
            };
        }

        private void SeedTrainings()
        {
            Crossfit = new Crossfit()
            {
                Id = 1,
                DurationInMinutes = 60,
                Date = new DateTime(2024,05,05,12,00,00),
                TrainerId = Trainer.Id
                
            };
        }
    }
}
