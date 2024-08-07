using System;
namespace backend.Models
{
    public class User
    {
        public User(string identifiant, string password)
        {
            Identifiant = identifiant;
            Password = password;
        }

        public string Identifiant { get; set; }

        public string Password { get; set; }
    }
}

