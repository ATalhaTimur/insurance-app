using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Services.Contracts
{
    public interface IPolicyService
    {
        IEnumerable<Policies> GetAllPolicies(bool trackChanges);
        Policies GetPolicyWithPolicyId(int id, bool trackChanges);
        IEnumerable<Policies> GetPoliciesWithUserId(int userId, bool trackChanges);
        Policies CreatePolicy(Policies policy);


        
    }
}
