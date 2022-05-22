using System;
using System.Collections.Generic;

#nullable disable

namespace StudentsBackend.Models
{
    public partial class User
    {
        public User(int id, string username, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }

        public User(){}

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
