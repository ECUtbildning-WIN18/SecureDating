using System;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class Profile 
    {
        public string Owner { get; }

        public string UserInfo { get; internal set; }

        public List<string> Inbox { get; set; }

        public Profile(string owner)
        {
            Owner = owner;
            Inbox = new List<string>();
        }

        public void SendMessage(User reciever, string message)
        {
            reciever.Profile.Inbox.Add(message);
        }

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
