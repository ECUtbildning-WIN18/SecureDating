using System;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string firstName, string lastName, DateTime birthdate, string userName, string password)
        {
            FirstName = firstName;
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
