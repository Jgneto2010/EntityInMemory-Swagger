using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class User
    {
        public User()
        {

        }
        public User(string name, string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Password = password;
        }

        public Guid Id { get; private set; }
        public string Name { get;  set; }
        public string Password { get;  set; }
    }
}
