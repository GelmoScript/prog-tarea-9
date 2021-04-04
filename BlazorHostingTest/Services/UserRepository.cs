using System;
using System.Collections.Generic;
using System.Linq;
using BlazorHostingTest.Contexts;
using BlazorHostingTest.Entities;

namespace BlazorHostingTest.Services
{
    public class UserRepository : IUserRepository
    {
        private UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public void AddUser(User userToAdd)
        {
            _context.Users.Add(userToAdd);
            _context.SaveChanges();
        }

        public void DeleteUser(User userToRemove)
        {
            _context.Users.Remove(userToRemove);
            _context.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Where(u => u.Id == userId).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void UpdateUser(User userToUpdate)
        {
            _context.Users.Update(userToUpdate);
            _context.SaveChanges();
        }
    }
}
