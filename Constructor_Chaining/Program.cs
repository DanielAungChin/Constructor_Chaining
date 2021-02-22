using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("This is MY WORLD", "WEARMLY WELCOME.");
            Console.WriteLine();
            Console.ReadLine();
        }

        class User
        {
            public User()
            {
                Console.Write("Hello!!!");
            }

            public User(string s) : this()
            {
                Console.Write(s);
            }
            public User(string s1,string s2) : this("Welcome...")
            {
                Console.Write(s1 + ">>>" + s2);
            }
        }
    }
}
