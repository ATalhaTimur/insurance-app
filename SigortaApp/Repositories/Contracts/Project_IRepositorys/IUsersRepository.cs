using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts.Project_IRepositorys
{
    public interface IUsersRepository : IRepositoryBase<Users>
    {
        IQueryable<Users> GetAllUsers(bool trackChanges);
        public Users GetUserWithUserId(int userId, bool trackChanges);
         public Users GetValidateUserWithMail(string email, string password, bool trackChanges);
         public Users GetValidateUserWithPhoneNumber(string phone_number, string password, bool trackChanges);
        void CreateUser(Users user);      
    }
}
