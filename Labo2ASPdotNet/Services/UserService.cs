using System;
using System.Collections.Generic;
using System.Linq;
using BC = BCrypt.Net.BCrypt;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context = null;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public bool VerifyUser(LoginModel model, bool isAdmin = false)
        {
            var result = _context.Users.FirstOrDefault(a => a.Username == model.Username);
            
            if (result == null)
            {
                return false;
            }

            
            if (!isAdmin || result.AccontType != Role.Admin)
            {
                return false;
            }

            if (BC.Verify(model.Password, result.Password))
            {
                return true;
            }
            return false;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public bool CreateOne(RegisterModel model)
        {
            var password = BC.HashPassword(model.Password);
            var account = new User
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Username = model.Username,
                Password = password,
                AccontType = model.Role
            };

            _context.Add(account);
            try
            {
                _context.SaveChanges();
                return true;

            } catch (Exception e) {
                Console.WriteLine("error", e);
                return false;
            }
        }
    }
}
