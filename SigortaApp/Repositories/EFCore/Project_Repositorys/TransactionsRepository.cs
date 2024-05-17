using Entities.Models;
using Repositories.Contracts.Project_IRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Project_Repositorys
{
    public class TransactionsRepository : RepositoryBase<Transactions>, ITransactionsRepository
    {
        public TransactionsRepository(RepositoryContext context) : base(context)
        {

        }

        public void CreateTransaction(Transactions transaction) => Create(transaction);       

        public IQueryable<Transactions> GetAllTransactions(bool trackChanges) => FindAll(trackChanges).OrderBy(t => t.Id);

        public Transactions GetTransactionWithTransactionId(int id, bool trackChanges) => FindByCondition(t => t.Id.Equals(id), trackChanges).SingleOrDefault();

        public IQueryable<Transactions> GetTransactionsWithPolicyId(int id, bool trackChanges) => FindByCondition(t => t.PolicyId.Equals(id), trackChanges);

        public IQueryable<Transactions> GetTransactionsWithUserId(int userId, bool trackChanges) => FindByCondition(t => t.UsersId.Equals(userId), trackChanges);
        
    }
   
}
