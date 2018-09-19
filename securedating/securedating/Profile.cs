using System;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class Profile //ska ärva från user
    {

        public string profile { get; set; } = $"{User} didn't add a profile yet";
        
       
        public void CreateProfile()
        {
            profile = ""; //flush
            Console.Write("Type your profile: ");
            profile = Console.ReadLine();
        }
        public void EditProfile()
        {
            Console.Write("Edit profile: ");
        }
        public void RemoveProfile()
        {
            Console.WriteLine("Profile deleted");
            profile = "";
        }

    }
}
