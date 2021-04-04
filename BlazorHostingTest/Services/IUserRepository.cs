using System;
using System.Collections.Generic;
using BlazorHostingTest.Entities;

namespace BlazorHostingTest.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int userId);
        void AddUser(User userToAdd);
        void UpdateUser(User userToUpdate);
        void DeleteUser(User userToRemove);
    }
}
