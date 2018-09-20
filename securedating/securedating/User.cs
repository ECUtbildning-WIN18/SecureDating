using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class User
    {
<<<<<<< HEAD
        public Profile Profile { get; set; }

        public string FirstName { get; internal set; }

        public string LastName { get; internal set; }

=======
        public string FirstName { get; set; }
        public string LastName { get; set; }
>>>>>>> develop
        public DateTime Birthdate { get; set; }

<<<<<<< HEAD
        private string UserName { get; }

        private string Password { get; }

        public User(string userName, string password)
        {
=======
        public User(string firstName, string lastName, DateTime birthdate, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
>>>>>>> develop
            UserName = userName;
            Password = password;
            Profile = new Profile(userName);
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
