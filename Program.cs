using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        private static void Main(string[] args)
        {
            string stringdata;

            //Choose action
            Console.WriteLine("1. Enter password");
            Console.WriteLine("2. Delete password");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Choose (1-3): ");

            stringdata = Console.ReadLine();

            if (stringdata == "1")
            {
                List<string> passwordchars = new List<string>();
                string passwordname;

                //Settings
                Console.WriteLine();
                Console.WriteLine("Enter settings:");
                Console.WriteLine("Password name: ");

                stringdata = Console.ReadLine();

                if (stringdata == "")
                {
                    return;
                }

                Console.WriteLine();
                passwordname = stringdata;
                Console.WriteLine("Password name: " + passwordname);

                //Generate password
                Console.WriteLine();
                Console.WriteLine("Enter to generate password");

                stringdata = Console.ReadLine();

                if (stringdata != "")
                {
                    return;
                }

                Console.WriteLine();
                Console.WriteLine("Generating...");

                Random random = new Random();

                string first = "a";
                string second = "a";
                string third = "a";
                string fourth = "a";
                string fifth = "a";
                string sixth = "a";
                string seventh = "a";

                int one = random.Next(1, 27);
                int two = random.Next(1, 27);
                int three = random.Next(1, 27);
                int four = random.Next(1, 27);
                int five = random.Next(1, 27);
                int six = random.Next(1, 27);
                int seven = random.Next(1, 27);

                //Setup chars list
                passwordchars.Add("a");
                passwordchars.Add("b");
                passwordchars.Add("c");
                passwordchars.Add("d");
                passwordchars.Add("e");
                passwordchars.Add("f");
                passwordchars.Add("g");
                passwordchars.Add("h");
                passwordchars.Add("i");
                passwordchars.Add("j");
                passwordchars.Add("k");
                passwordchars.Add("l");
                passwordchars.Add("m");
                passwordchars.Add("n");
                passwordchars.Add("o");
                passwordchars.Add("p");
                passwordchars.Add("q");
                passwordchars.Add("r");
                passwordchars.Add("s");
                passwordchars.Add("t");
                passwordchars.Add("u");
                passwordchars.Add("v");
                passwordchars.Add("w");
                passwordchars.Add("x");
                passwordchars.Add("y");
                passwordchars.Add("z");

                passwordchars.Add("1");
                passwordchars.Add("2");
                passwordchars.Add("3");
                passwordchars.Add("4");
                passwordchars.Add("5");
                passwordchars.Add("6");
                passwordchars.Add("7");
                passwordchars.Add("8");
                passwordchars.Add("9");
                passwordchars.Add("0");

                passwordchars.Add("A");
                passwordchars.Add("B");
                passwordchars.Add("C");
                passwordchars.Add("D");
                passwordchars.Add("E");
                passwordchars.Add("F");
                passwordchars.Add("G");
                passwordchars.Add("H");
                passwordchars.Add("I");
                passwordchars.Add("J");
                passwordchars.Add("K");
                passwordchars.Add("L");
                passwordchars.Add("M");
                passwordchars.Add("N");
                passwordchars.Add("O");
                passwordchars.Add("P");
                passwordchars.Add("Q");
                passwordchars.Add("R");
                passwordchars.Add("S");
                passwordchars.Add("T");
                passwordchars.Add("U");
                passwordchars.Add("V");
                passwordchars.Add("W");
                passwordchars.Add("X");
                passwordchars.Add("Y");
                passwordchars.Add("Z");

                //Setup chars in password
                one = random.Next(1, passwordchars.Count);
                two = random.Next(1, passwordchars.Count);
                three = random.Next(1, passwordchars.Count);
                four = random.Next(1, passwordchars.Count);
                five = random.Next(1, passwordchars.Count);
                six = random.Next(1, passwordchars.Count);
                seven = random.Next(1, passwordchars.Count);

                first = passwordchars[one];
                second = passwordchars[two];
                third = passwordchars[three];
                fourth = passwordchars[four];
                fifth = passwordchars[five];
                sixth = passwordchars[six];
                seventh = passwordchars[seven];

                string password = first + second + third + fourth + fifth + sixth + seventh;

                Console.WriteLine();
                Console.WriteLine("Generating completed");

                Console.WriteLine();
                Console.WriteLine("Results:");

                Console.WriteLine();
                Console.WriteLine("Password name: " + passwordname);
                Console.WriteLine("Password data: " + password);

                //Saving password
                string programpath = Directory.GetCurrentDirectory();
                string passwordfilepath = programpath + "\\passwords.txt";

                Console.WriteLine("Saving password...");

                Console.WriteLine();
                File.AppendAllText(passwordfilepath, passwordname + " - " + password + "\n");
                Console.WriteLine("Password saved at path: " + passwordfilepath);

                //Exit from program
                bool isCanExit = false;

                Console.WriteLine();
                Console.WriteLine("Press enter for exit");

                stringdata = Console.ReadLine();

                if (stringdata != null)
                {
                    isCanExit = true;
                }

                while (!isCanExit)
                {
                    Console.ReadLine();
                }

                if (isCanExit)
                {
                    Console.WriteLine("Exiting...");
                }
            }

            if (stringdata == "2")
            {
                string passwordfilepath = Directory.GetCurrentDirectory() + "\\passwords.txt";

                Console.WriteLine();
                Console.WriteLine("Are you sure you want DELETE ALL your PASSWORDS?");
                Console.Write("Choose (y/n): ");

                stringdata = Console.ReadLine();

                if (stringdata == "y" || stringdata == "Y")
                {
                    File.Delete(passwordfilepath);
                    Console.WriteLine();
                    Console.WriteLine("Passwords deleted at path: " + passwordfilepath);
                    File.Create(passwordfilepath);
                    Console.WriteLine("Press enter for exit");

                    stringdata = Console.ReadLine();

                    if (stringdata != null)
                    {
                        Console.WriteLine("Exiting...");
                    }
                }

                if (stringdata == "n" || stringdata == "N")
                {
                    Console.WriteLine("Exiting...");
                }
            }

            if (stringdata == "3")
            {
                Console.WriteLine("Exiting..");
            }
        }
    }
}
