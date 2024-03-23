using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TrainingApp.Data
{
    public class TrainingDbContext : IdentityDbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
            : base(options)
        {

        }
    }
}