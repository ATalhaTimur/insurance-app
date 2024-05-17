using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Repositories.EFCore.Config
{
    public class PoliciesConfig : IEntityTypeConfiguration<Policies>
    {
        public void Configure(EntityTypeBuilder<Policies> builder)
        {
           builder.HasData(
               new Policies
               {
                   Id = 1,
                   UsersId = 1,
                   PolicyPrice = 1000,
                   PolicyType = "Health",
                   Coverage = "Full",
                   Start_Date = DateTime.Now,
                   End_Date = DateTime.Now.AddYears(1),
                   Created_at = DateTime.Now
               },
                new Policies
                {
                    Id = 2,
                    UsersId = 1,
                    PolicyPrice = 6000,
                    PolicyType = "Car",
                    Coverage = "Full",
                    Start_Date = DateTime.Now,
                    End_Date = DateTime.Now.AddYears(1),
                    Created_at = DateTime.Now
                },
                new Policies
                {
                    Id = 3,
                    UsersId = 2,
                    PolicyPrice = 2000,
                    PolicyType = "House",
                    Coverage = "Full",
                    Start_Date = DateTime.Now,
                    End_Date = DateTime.Now.AddYears(1),
                    Created_at = DateTime.Now
                });
        }
    }
}
