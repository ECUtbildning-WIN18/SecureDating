using System;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class User
    {
        public Profile Profile { get; set; }

        public string FirstName { get; internal set; }

        public string LastName { get; internal set; }

        public DateTime Birthdate { get; set; }

        private string UserName { get; }

        private string Password { get; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Profile = new Profile();
        }

        public void SetFullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    }

}
