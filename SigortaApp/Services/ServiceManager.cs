using Repositories.Contracts;
using Services.Contracts;
using Services.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ITransactionsService> _transactionsService;
        private readonly Lazy<IUsersService> _usersService;
        private readonly Lazy<IPolicyUserService> _policyUserService;
        private readonly Lazy<IPolicyService> _policyService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _policyService = new Lazy<IPolicyService>(() => new PolicyManager(repositoryManager));
            _policyUserService = new Lazy<IPolicyUserService>(() => new PolicyUserManager(repositoryManager));
            _transactionsService = new Lazy<ITransactionsService>(() => new TransactionsManager(repositoryManager));                
            _usersService = new Lazy<IUsersService>(() => new UsersManager(repositoryManager));
        }
        public ITransactionsService TransactionsService => _transactionsService.Value;

        public IUsersService UsersService =>  _usersService.Value;

        public IPolicyUserService PolicyUserService =>  _policyUserService.Value;

        public IPolicyService PolicyService => _policyService.Value;
    }
}
