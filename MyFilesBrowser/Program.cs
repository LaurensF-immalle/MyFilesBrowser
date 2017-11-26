using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFilesBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Geef een argument!");
            }
            else
            {
                switch (args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllFiles();
                        break;
                    case "-d":
                        SubDirectorys();
                        break;
                    case "-h":
                        ShowsHelp();
                        break;
                    default:
                        OnbekendArgument();
                        break;
                    case "":
                        ShowCurrentDirectory();
                        ShowAllFiles();
                        SubDirectorys();
                        break;
                    case "-exp":

                        break;
                }
            }
        }

        static void experimentje()
        {
            string[] woorden = { "dit", "is", "gewoon", "experimentje" };
            foreach (string woord in woorden)
            {
                Console.WriteLine(woord);
            }
        }


        static void ShowAllFiles()
        {
            Console.WriteLine("Alle files in huidige directory: " + Directory.GetFiles(" "));

        }

        static void ShowCurrentDirectory()
        {
            Console.WriteLine("Huidige Directory: " + Environment.CurrentDirectory);
        }

        static void OnbekendArgument()
        {
            Console.WriteLine("Onbekend argument");
        }

        static void SubDirectorys()
        {
            Console.WriteLine("Alle Subdirectories: ");
        }

        static void ShowsHelp()
        {
            Console.WriteLine("-----help------");
            Console.WriteLine("-c | Shows huidige directory");
            Console.WriteLine("-d | Shows alle Subdirectories in huidige directory");
            Console.WriteLine("-f | Shows alle files in huidige directory");
            Console.WriteLine("-h | Shows help");

        }


    }
}
