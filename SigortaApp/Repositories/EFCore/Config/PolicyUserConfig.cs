using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Repositories.EFCore.Config
{
    public class PolicyUserConfig : IEntityTypeConfiguration<PolicyUser>
    {
        public void Configure(EntityTypeBuilder<PolicyUser> builder)
        {
            builder.HasData(
              
                new PolicyUser
                {
                    Id = 1,
                    PolicyId = 2,
                    UsersId = 1,
                    Ownership_start_date = new DateTime(2024, 5, 1, 0, 0, 0),
                    Ownership_end_date = new DateTime(2024, 12, 31, 23, 59, 59)
                },
                new PolicyUser
                {
                    Id = 2,
                    PolicyId = 1,
                    UsersId = 1,
                    Ownership_start_date = new DateTime(2024, 6, 15, 0, 0, 0),
                    Ownership_end_date = new DateTime(2025, 6, 14, 23, 59, 59)
                },
                new PolicyUser
                {
                    Id = 3,
                    PolicyId = 3,
                    UsersId = 2,
                    Ownership_start_date = new DateTime(2024, 7, 1, 0, 0, 0),
                    Ownership_end_date = new DateTime(2024, 12, 1, 23, 59, 59)
                });
        }
    }
}
