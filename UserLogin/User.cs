using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string facultyNumber { get; set; }
        public int role { get; set; }
        public DateTime created { get; set; }
        public DateTime expire { get; set; }
        
        public User() { }

        public User(string username, string password, string facultyNumber, int role)
        {
            this.username = username;
            this.password = password;
            this.facultyNumber = facultyNumber;
            this.role = role;
        }

        public override string ToString()
        {
            return "Username: " + username + " faculty number: " + facultyNumber + " role number: " + role;
        }
    }
}
