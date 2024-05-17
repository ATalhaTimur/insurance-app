using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Managers
{
    public class TransactionsManager : ITransactionsService
    {
        private readonly IRepositoryManager _manager;

        public TransactionsManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Transactions> GetAllTransactions(bool trackChanges)
        {
            return _manager.Transactions.GetAllTransactions(trackChanges);
        }

        public Transactions GetTransactionWithTransactionId(int id, bool trackChanges)
        {
            return _manager.Transactions.GetTransactionWithTransactionId(id, trackChanges);
        }

        public IEnumerable<Transactions> GetTransactionsWithUserId(int userId, bool trackChanges)
        {
           return _manager.Transactions.GetTransactionsWithUserId(userId, trackChanges);
        }

        public IEnumerable<Transactions> GetTransactionsWithPolicyId(int id, bool trackChanges)
        {
           return _manager.Transactions.GetTransactionsWithPolicyId(id, trackChanges);
        }

        public Transactions CreateTransaction(Transactions transaction)
        {
            _manager.Transactions.CreateTransaction(transaction);
            _manager.Save();
            return transaction;
        }

        
    }
}
