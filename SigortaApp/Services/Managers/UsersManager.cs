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
    public class UsersManager : IUsersService
    {
        private readonly IRepositoryManager _manager;

        public UsersManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Users CreateUser(Users user)
        {
           _manager.Users.CreateUser(user);
            _manager.Save();
            return user;
        }

        public IQueryable<Users> GetAllUsers(bool trackChanges)
        {
            return _manager.Users.GetAllUsers(trackChanges);
        }

        public Users GetUserWithUserId(int userId, bool trackChanges)
        {
            return _manager.Users.GetUserWithUserId(userId, trackChanges);
        }

        public Users GetValidateUserWithMail(string email, string password, bool trackChanges)
        {
            return _manager.Users.GetValidateUserWithMail(email, password, trackChanges);
        }

        public Users GetValidateUserWithPhoneNumber(string phone_number, string password, bool trackChanges)
        {
            return _manager.Users.GetValidateUserWithPhoneNumber(phone_number, password, trackChanges);
        }
    }
}
