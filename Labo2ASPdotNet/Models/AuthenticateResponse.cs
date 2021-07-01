using System;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public Role AccontType { get; set; }

        public string Token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Email = user.Email;
            IsActive = user.IsActive;
            AccontType = user.AccontType;
            Token = token;
        }
    }
}
