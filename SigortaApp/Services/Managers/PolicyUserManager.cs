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
    public class PolicyUserManager : IPolicyUserService
    {
        private readonly IRepositoryManager _manager;

        public PolicyUserManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public PolicyUser CreatePolicyUser(PolicyUser policyUser)
        {
            _manager.PolicyUser.CreatePolicyUser(policyUser);
            _manager.Save();
            return policyUser;
        }

        public IEnumerable<PolicyUser> GetAllPolicyUsers(bool trackChanges)
        {
            return _manager.PolicyUser.GetAllPolicyUsers(trackChanges);
        }

        public IEnumerable<PolicyUser> GetPolicyUserWithPolicyId(int id, bool trackChanges)
        {
           return _manager.PolicyUser.GetPolicyUserWithPolicyId(id, trackChanges);
        }

        public PolicyUser GetPolicyUserWithPolicyUserId(int userId, bool trackChanges)
        {
            return _manager.PolicyUser.GetPolicyUserWithPolicyUserId(userId, trackChanges);
        }

        public IEnumerable<PolicyUser> GetPolicyUserWithUserId(int userId, bool trackChanges)
        {
            return _manager.PolicyUser.GetPolicyUserWithUserId(userId, trackChanges);
        }
    }
}
