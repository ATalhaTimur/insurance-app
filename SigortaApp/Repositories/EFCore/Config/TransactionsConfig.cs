using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Repositories.EFCore.Config
{
    public class TransactionsConfig : IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.HasData(
                new Transactions
                {
                    Id = 1,
                    PolicyId = 2,
                    UsersId = 1,
                    TransactionPrice = 500.0f,
                    TransactionType = "Premium Payment",
                    timestamp = new DateTime(2024, 1, 1, 12, 0, 0)
                },
                new Transactions
                {
                    Id = 2,
                    PolicyId = 1,
                    UsersId = 1,
                    TransactionPrice = 300.0f,
                    TransactionType = "Policy Renewal",
                    timestamp = new DateTime(2024, 1, 15, 12, 0, 0)
                },
                new Transactions
                {
                    Id = 3,
                    PolicyId = 3,
                    UsersId = 2,
                    TransactionPrice = 700.0f,
                    TransactionType = "Claim Reimbursement",
                    timestamp = new DateTime(2024, 2, 1, 12, 0, 0)
                }
            );
        }
    }
}
