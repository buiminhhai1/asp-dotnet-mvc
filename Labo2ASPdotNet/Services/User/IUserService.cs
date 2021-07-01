using System.Collections.Generic;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Services
{
    public interface IUserService
    {
        public bool VerifyUser(LoginModel model, bool isAdmin = false);

        public bool CreateOne(RegisterModel model);

        public List<User> GetAll();

        public void ChangeActiveStatus(int id, bool value);

        public User GetById(int id);

        public AuthenticateResponse Authenticate(LoginModel model);

    }
}
