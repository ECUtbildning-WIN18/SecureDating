using System;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class User
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string fristName, string lastName, DateTime birthdate, string userName, string password)
        {
            FristName = fristName;
            LastName = lastName;
            Birthdate = birthdate;
            UserName = userName;
            Password = password;
        }

        public void Inbox()
        {

        }
    }

    
}
