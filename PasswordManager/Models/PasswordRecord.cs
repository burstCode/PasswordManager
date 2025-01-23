using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Models
{
    public class PasswordRecord
    {
        public string Service { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public PasswordRecord(string service, string login, string password)
        {
            Service = service;
            Login = login;
            Password = password;
        }
    }
}
