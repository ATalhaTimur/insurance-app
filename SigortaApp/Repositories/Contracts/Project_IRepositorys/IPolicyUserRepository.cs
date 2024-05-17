
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts.Project_IRepositorys
{
    public interface IPolicyUserRepository : IRepositoryBase<PolicyUser>
    {
        IQueryable<PolicyUser> GetAllPolicyUsers(bool trackChanges);
        public PolicyUser GetPolicyUserWithPolicyUserId(int userId, bool trackChanges);
        IQueryable <PolicyUser> GetPolicyUserWithUserId(int userId, bool trackChanges);
        IQueryable<PolicyUser> GetPolicyUserWithPolicyId(int id, bool trackChanges);
        void CreatePolicyUser(PolicyUser policyUser);    
    }
}
