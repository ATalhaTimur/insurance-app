using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Contracts.Project_IRepositorys;
namespace Repositories.Contracts
{
    //unit of work
    public interface IRepositoryManager
    {
        IPolicyReposityory Policy { get; }
        IPolicyUserRepository PolicyUser { get; }
        ITransactionsRepository Transactions { get; }
        IUsersRepository Users { get; }
        void Save();
        
    }
}
