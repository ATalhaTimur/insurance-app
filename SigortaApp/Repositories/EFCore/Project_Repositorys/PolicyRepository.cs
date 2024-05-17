using Entities.Models;
using Repositories.Contracts.Project_IRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Project_Repositorys
{
    public class PolicyRepository : RepositoryBase<Policies>, IPolicyReposityory

    {
        public PolicyRepository(RepositoryContext context) : base(context)
        {

        }

        public void CreatePolicy(Policies policy) => Create(policy);       

        public IQueryable<Policies> GetAllPolicies(bool trackChanges) => FindAll(trackChanges);

        public IQueryable<Policies> GetPoliciesWithUserId(int userId, bool trackChanges) => FindByCondition(p => p.UsersId == userId, trackChanges);

        public Policies GetPolicyWithPolicyId(int id, bool trackChanges) => FindByCondition(p => p.Id == id, trackChanges).SingleOrDefault();

       
    }

}
