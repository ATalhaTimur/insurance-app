using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Repositories.EFCore.Config
{
    public class UsersConfig : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {

            builder.HasData(
                new Users
                {
                    Id = 1,
                    UserName = "JohnDoe",
                    Email = "john.doe@example.com",
                    Password = "SecurePassword123!",
                    PhoneNumber = "123-456-7890",
                    Created_at = new DateTime(2023, 1, 1)
                },
                new Users
                {
                    Id = 2,
                    UserName = "JaneSmith",
                    Email = "jane.smith@example.com",
                    Password = "AnotherSecure123!",
                    PhoneNumber = "123-456-7891",
                    Created_at = new DateTime(2022, 1, 2)
                },
                new Users
                {
                    Id = 3,
                    UserName = "AliceJohnson",
                    Email = "alice.johnson@example.com",
                    Password = "PasswordSecure456!",
                    PhoneNumber = "123-456-7892",
                    Created_at = new DateTime(2021, 1, 3)
                }
            );
        }
    }
}
