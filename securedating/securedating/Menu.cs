using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;



namespace securedating
{
    class Menu
    {
        public static List<Tuple<string, string>> users = new List<Tuple<string, string>>();

        public static Dictionary<string, User> Accounts = new Dictionary<string, User>();

        public static User LoggedUser { get; set; }
        
        public static void Intro()
        {
       
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("             ##");
            Console.WriteLine("           ##  ##");
            Console.WriteLine("          #      #");
            Console.WriteLine("          #      #");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    ########    ########");
            Console.WriteLine("   ##########  ##########");
            Console.WriteLine("  ########################");
            Console.WriteLine("   ######################");
            Console.WriteLine("    ########    ########");
            Console.WriteLine("     #######    #######");
            Console.WriteLine("      #######  #######");
            Console.WriteLine("       #####   ######");
            Console.WriteLine("        ############");
            Console.WriteLine("         ##########");
            Console.WriteLine("          ########");
            Console.WriteLine("           ######");
            Console.WriteLine("            ####");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("        Secure Dating");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
            Thread t = new Thread(new ThreadStart(Music));
            t.Start();
        }

        private static void Music()
        {
            Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }

        private static void Music2()
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(880, 500);
            Console.Beep(440, 350);
            Console.Beep(440, 150);
            Console.Beep(880, 500);
            Console.Beep(830, 250);
            Console.Beep(784, 250);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(740, 250);
            Console.Beep(455, 250);
            Console.Beep(622, 500);
            Console.Beep(587, 250);
            Console.Beep(554, 250);
            Console.Beep(523, 125);
            Console.Beep(466, 125);
            Console.Beep(523, 250);
            Console.Beep(349, 125);
            Console.Beep(415, 500);
            Console.Beep(349, 375);
            Console.Beep(440, 125);
            Console.Beep(523, 500);
            Console.Beep(440, 375);
            Console.Beep(523, 125);
            Console.Beep(659, 1000);
            Console.Beep(880, 500);
            Console.Beep(440, 350);
            Console.Beep(440, 150);
            Console.Beep(880, 500);
            Console.Beep(830, 250);
            Console.Beep(784, 250);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(740, 250);
            Console.Beep(455, 250);
            Console.Beep(622, 500);
            Console.Beep(587, 250);
            Console.Beep(554, 250);
            Console.Beep(523, 125);
            Console.Beep(466, 125);
            Console.Beep(523, 250);
            Console.Beep(349, 250);
            Console.Beep(415, 500);
            Console.Beep(349, 375);
            Console.Beep(523, 125);
            Console.Beep(440, 500);
            Console.Beep(349, 375);
            Console.Beep(261, 125);
            Console.Beep(440, 1000);
        }

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  #### START ################");
            Console.WriteLine("  # Press to choose         #");
            Console.WriteLine("  # 1. Login                #");
            Console.WriteLine("  # 2. Registry             #");
            Console.WriteLine("  # 3. Quit                 #");
            Console.WriteLine("  ###########################");

            int choice = 0;

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Please don't be a jackass, press a number in the list!");
                //Console.WriteLine($"Exception: {e}");
                Console.ReadKey();
                Menu.Start();
            }

            switch (choice)
            {
                case 1: Menu.Login(); break;
                case 2: Menu.Registry(); break;
                case 3: Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please pick a number in the menu");
                    Menu.Start();
                    break;
            }
        }

        public static void Login()
        {
            Console.Clear();
            Console.WriteLine("#### LOGIN ####");
            Console.WriteLine();
            Console.Write("Username:");
            string userName = Console.ReadLine();
            Console.WriteLine();
            if (users.Exists(e => e.Item1 == userName))
            {

                int attempt = 1;
                do
                {
                    Console.Write("Password:");
                    string password = Console.ReadLine();
                    attempt++;
                    if (users.Exists(e => e.Item2 == password))
                    {
                        if (Accounts.ContainsKey(userName))
                        {
                            LoggedUser = Accounts[userName];
                        }

                        Menu.MainMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("wrong password");
                        Console.WriteLine($"You have {4 - attempt} attempt left!");
                    }
                } while (attempt < 4);
                Menu.Start();
            }
            else
            {
                Console.WriteLine("you are not a member");
                Console.ReadKey();
                Menu.Start();
            }
        }

        public static void Registry()
        {
            Console.Clear();

            Console.WriteLine("#### Registry ####");

            Console.WriteLine();

            Console.Write("Username:");

            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Password:");

            string password = Console.ReadLine();

            bool userNameExist = users.Any(m => m.Item1 == $"{userName}");
            //bool userNameExist = false;

            if (userNameExist)
            {
                Console.WriteLine("The username exist, please try again!");
                Console.ReadKey();
                Menu.Registry();
            }
            else
            {
                Console.Clear();

                Console.WriteLine($"Your username is [{userName}] and your password is [{password}]");

                Console.WriteLine();

                Console.WriteLine("Is this correct? Y/N");

                string correct = Console.ReadLine();

                if (correct == "y" || correct == "Y")
                {
                    users.Add(new Tuple<string, string>(userName, password));

                    Accounts.Add(userName, new User(userName, password));

                    Menu.Start();
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Try again!");

                    Console.ReadKey();

                    Menu.Registry();
                }

                

            }
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  #### Main Menu ############");
            Console.WriteLine("  # You Are in!             #");
            Console.WriteLine("  # 1. Member list          #");
            Console.WriteLine("  # 2. Send Message         #");
            Console.WriteLine("  # 3. View Inbox           #");
            Console.WriteLine("  # 4. Logout               #");
            Console.WriteLine("  ###########################");

            
            string choice2 = Console.ReadLine();

            switch (choice2)
            {
                case "1": Menu.Memberlist();
                    break;

                case "2":
                    SendMessage();
                    break;

                case "3": Menu.ViewInbox();
                    break;

                case "4": Menu.Start();
                    break;

                default:
                    Console.WriteLine("Please pick a number in the menu");
                    Menu.MainMenu();
                    break;
            }
        }
        public static void Memberlist()
        {
            Console.Clear();
            Console.WriteLine("#### Memberlist ####");
            Console.WriteLine();

            foreach (var element in users)
            {
                Console.WriteLine($"Username: {element.Item1} are looking for LOVE!");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to Continue... ");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Hint, 'any key' is not a special key");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("just press a damn key on your keyboard");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Menu.MainMenu();
        }

        public static void SendMessage()
        {
            Console.Clear();

            User sender = LoggedUser;

            User Reciever;

            Console.WriteLine("Send Message to:");

            foreach (var account in Accounts) // prints out all users
            {
                Console.WriteLine(account.Key);
            }

            string recipient = Console.ReadLine();
            if (Accounts.ContainsKey(recipient))
            {
                Reciever = Accounts[recipient];
            }

            bool userNameNotExist = users.Any(m => $"{recipient}" == m.Item1);

            if (userNameNotExist == false)
            {
                Console.WriteLine("That user doesn't exist, try again!");
                Console.ReadKey();
                SendMessage();
            }
            else
                Console.WriteLine("Write your message:");

            string message = Console.ReadLine();

            sender.Profile.SendMessage(Accounts[recipient], message);

            MainMenu();

        }

        public static void ViewInbox()
        {
            Console.Clear();
            Console.WriteLine("Your messages:");
            Console.WriteLine();

            foreach (string message in LoggedUser.Profile.Inbox)
            {
                Console.WriteLine(message);
            }

            Console.ReadLine();

        }

    }
}
