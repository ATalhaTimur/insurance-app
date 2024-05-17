using Entities.Models;
using Repositories.Contracts.Project_IRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Project_Repositorys
{
    public class PolicyUserRepository : RepositoryBase<PolicyUser>, IPolicyUserRepository
    {
        public PolicyUserRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreatePolicyUser(PolicyUser policyUser) => Create(policyUser);        

        public IQueryable<PolicyUser> GetAllPolicyUsers(bool trackChanges) => FindAll(trackChanges);

        public IQueryable<PolicyUser> GetPolicyUserWithPolicyId(int id, bool trackChanges) => FindByCondition(p => p.PolicyId == id, trackChanges);
        public PolicyUser GetPolicyUserWithPolicyUserId(int userId, bool trackChanges) => FindByCondition(p => p.Id == userId, trackChanges).SingleOrDefault();

        public IQueryable<PolicyUser> GetPolicyUserWithUserId(int userId, bool trackChanges) => FindByCondition(p => p.UsersId == userId, trackChanges);
        

       
    }
}
