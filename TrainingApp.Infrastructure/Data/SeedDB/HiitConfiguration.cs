using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Infrastructure.Data.SeedDB
{
    internal class HiitConfiguration : IEntityTypeConfiguration<Hiit>
    {
        public void Configure(EntityTypeBuilder<Hiit> builder)
        {
            var data = new SeedData();

            builder.HasData(new Hiit[] { data.Hiit });
        }
    }
}
