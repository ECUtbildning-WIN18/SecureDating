using System;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class Profile 
    {
        public User Owner { get; }

        public string UserInfo { get; internal set; }

        public void AddUserInfo()
        {
            Console.Write("Type your profile: ");
            string userInfo = Console.ReadLine();
            UserInfo = userInfo;
            
        }
        public void EditUserInfo()
        {
            Console.Write("Edit profile: ");
        }
        public void RemoveUserInfo()
        {
            Console.WriteLine("Profile deleted");
           // UserProfile = "";
        }

    }
}
