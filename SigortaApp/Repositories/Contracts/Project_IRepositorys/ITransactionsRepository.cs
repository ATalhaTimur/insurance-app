using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts.Project_IRepositorys
{
    public interface ITransactionsRepository : IRepositoryBase<Transactions>
    {
        IQueryable<Transactions> GetAllTransactions(bool trackChanges);
        public Transactions GetTransactionWithTransactionId(int id, bool trackChanges);
        IQueryable<Transactions> GetTransactionsWithUserId(int userId, bool trackChanges);
        IQueryable<Transactions> GetTransactionsWithPolicyId(int id, bool trackChanges);
        void CreateTransaction(Transactions transaction);      
    }
}
