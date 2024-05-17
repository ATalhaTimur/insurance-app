using Entities.Models;
using Repositories.Contracts.Project_IRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Project_Repositorys
{
    public class UsersRepository : RepositoryBase<Users>, IUsersRepository
    {
        public UsersRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateUser(Users user) => Create(user);       

        public IQueryable<Users> GetAllUsers(bool trackChanges) => FindAll(trackChanges).OrderBy(u => u.Id);

        public Users GetUserWithUserId(int userId, bool trackChanges) => FindByCondition(u => u.Id.Equals(userId), trackChanges).SingleOrDefault();

        public Users GetValidateUserWithMail(string email, string password, bool trackChanges) => FindByCondition(u => u.Email.Equals(email) && u.Password.Equals(password), trackChanges).SingleOrDefault();
        public Users GetValidateUserWithPhoneNumber(string phone_number, string password, bool trackChanges) => FindByCondition(u => u.PhoneNumber.Equals(phone_number) && u.Password.Equals(password), trackChanges).SingleOrDefault();
        
    }
   
}
