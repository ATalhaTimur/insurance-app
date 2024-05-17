using Repositories.Contracts;
using Repositories.Contracts.Project_IRepositorys;
using Repositories.EFCore.Project_Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _context; // aslında DbContext
        // nesne ancak ve ancak kullanıldıgında new le me yapılacak
        private readonly Lazy<IPolicyReposityory> _policy;
        private readonly Lazy<IPolicyUserRepository> _policyUser;
        private readonly Lazy<ITransactionsRepository> _transactions;
        private readonly Lazy<IUsersRepository> _users;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _policy = new Lazy<IPolicyReposityory>(() => new PolicyRepository(_context));
            _policyUser = new Lazy<IPolicyUserRepository>(() => new PolicyUserRepository(_context));
            _transactions = new Lazy<ITransactionsRepository>(() => new TransactionsRepository(_context));
            _users = new Lazy<IUsersRepository>(() => new UsersRepository(_context));

        }
        public IPolicyReposityory Policy => _policy.Value ;

        public IPolicyUserRepository PolicyUser => _policyUser.Value;

        public ITransactionsRepository Transactions => _transactions.Value;

        public IUsersRepository Users => _users.Value;

        public void Save() => _context.SaveChanges();
        
    }
}
