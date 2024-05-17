using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts.Project_IRepositorys
{
    public interface IPolicyReposityory : IRepositoryBase<Policies>
    {
        IQueryable<Policies> GetAllPolicies(bool trackChanges);
        Policies GetPolicyWithPolicyId(int id, bool trackChanges);
        IQueryable<Policies> GetPoliciesWithUserId(int userId, bool trackChanges);
        void CreatePolicy(Policies policy);

    }
}
