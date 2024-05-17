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
    public class PolicyManager : IPolicyService
    {
        private readonly IRepositoryManager _manager;

        public PolicyManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Policies CreatePolicy(Policies policy)
        {
           _manager.Policy.CreatePolicy(policy);
            _manager.Save();
            return policy;
        }

        public IEnumerable<Policies> GetAllPolicies(bool trackChanges)
        {
            return _manager.Policy.GetAllPolicies(trackChanges);
             
        }

        public IEnumerable<Policies> GetPoliciesWithUserId(int userId, bool trackChanges)
        {
            return _manager.Policy.GetPoliciesWithUserId(userId, trackChanges);
        }

        public Policies GetPolicyWithPolicyId(int id, bool trackChanges)
        {
            return _manager.Policy.GetPolicyWithPolicyId(id, trackChanges);
        }
    }
}
