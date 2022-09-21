using System;

namespace textbased_adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" _____    _        _     _                        _             _                 _  ");
            Console.WriteLine(@"|_   _|  | |      | |   | |                      | |           | |               | | ");
            Console.WriteLine(@"  | | ___| | _____| |_  | |__   __ _ ___  ___  __| |   __ _  __| |_   _____ _ __ | |_ _   _ _ __ ___ ");
            Console.WriteLine(@"  | |/ _ \ |/ / __| __| | '_ \ / _` / __|/ _ \/ _` |  / _` |/ _` \ \ / / _ \ '_ \| __| | | | '__/ _ \ ");
            Console.WriteLine(@"  | |  __/   <\__ \ |_  | |_) | (_| \__ \  __/ (_| | | (_| | (_| |\ V /  __/ | | | |_| |_| | | |  __/");
            Console.WriteLine(@"  \_/\___|_|\_\___/\__| |_.__/ \__,_|___/\___|\__,_|  \__,_|\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|");

            Console.WriteLine("\n What is your name");
            string CharacterName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("is your name: " + CharacterName +" Y/N");
            string NameCheck = Console.ReadLine();
            if (NameCheck.ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("your name is : " + CharacterName);
            }
            else if(NameCheck.ToLower() == "n")
            {
                Console.Clear();
                Console.WriteLine("What is your name: ");
                CharacterName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("your name is : " + CharacterName);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please Fill in Y or N");
                
            }
            Console.Read();
        }
    }
}
