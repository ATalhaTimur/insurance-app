using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IUsersService
    {
        IQueryable<Users> GetAllUsers(bool trackChanges);
        public Users GetUserWithUserId(int userId, bool trackChanges);
        public Users GetValidateUserWithMail(string email, string password, bool trackChanges);
        public Users GetValidateUserWithPhoneNumber(string phone_number, string password, bool trackChanges);
        Users CreateUser(Users user);
    }
}
