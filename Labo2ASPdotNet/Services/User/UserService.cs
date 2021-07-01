using System;
using System.Collections.Generic;
using System.Linq;
using BC = BCrypt.Net.BCrypt;
using Labo2ASPdotNet.Database;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using Labo2ASPdotNet.Wrappers.Helpers;
using Microsoft.Extensions.Options;
using Labo2ASPdotNet.Wrappers.JwtHelpers;
using Microsoft.AspNetCore.Http;

namespace Labo2ASPdotNet.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context = null;
        private readonly AppSettings _appSettings;
        

        public UserService(DataContext context, IOptions<AppSettings> settings)
        {
            _context = context;
            _appSettings = settings.Value;
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
                IsActive = true,
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

        public void ChangeActiveStatus(int id, bool value)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                throw new DllNotFoundException("User not found");
            }
            user.IsActive = value;
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public User GetById(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }


        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret.ToString());
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public AuthenticateResponse Authenticate(LoginModel model)
        {
            var user = _context.Users.FirstOrDefault(a => a.Username == model.Username);

            if (user != null && BC.Verify(model.Password, user.Password))
            {
                var token = generateJwtToken(user);
                return new AuthenticateResponse(user, token);
            }

            return null;
        }
    }
}
