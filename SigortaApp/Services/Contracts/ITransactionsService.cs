using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ITransactionsService
    {
        IEnumerable<Transactions> GetAllTransactions(bool trackChanges);
        Transactions GetTransactionWithTransactionId(int id, bool trackChanges);
        IEnumerable<Transactions> GetTransactionsWithUserId(int userId, bool trackChanges);
        IEnumerable<Transactions> GetTransactionsWithPolicyId(int id, bool trackChanges);
        Transactions CreateTransaction(Transactions transaction);
    }
}
