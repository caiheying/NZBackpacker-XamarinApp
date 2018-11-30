using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NZBackpackerApp.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string Username, string Password)
        {
            //Console.WriteLine($"...{Username}      {Password}");
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInfomation()
        {
            if (string.IsNullOrEmpty(this.Username) || string.IsNullOrEmpty(this.Password))
                return false;
            else
                return true;
        }
    }


}
