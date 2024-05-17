using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IPolicyUserService
    {
        IEnumerable<PolicyUser> GetAllPolicyUsers(bool trackChanges);
        PolicyUser GetPolicyUserWithPolicyUserId(int userId, bool trackChanges);
        IEnumerable<PolicyUser> GetPolicyUserWithUserId(int userId, bool trackChanges);
        IEnumerable<PolicyUser> GetPolicyUserWithPolicyId(int id, bool trackChanges);
        PolicyUser CreatePolicyUser(PolicyUser policyUser);
    }
}
