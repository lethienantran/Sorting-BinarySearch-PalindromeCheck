using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SortSearchAndTwoPointers
{
    class AllOptionMenu
    {
        public static void Option(string option, string message)
        {
            Console.Write(option);
            Console.WriteLine(". " + message);
        }
        //Palindrome Menu
        public static void PalindromeHomeMenu()
        {
            for (; ; )
            {
                string userString = "";
                Console.WriteLine("Enter a word you want to check for Palindrome");
                userString = Console.ReadLine();
                if (AllMethods.CheckPalindrome(userString))
                {
                    Console.WriteLine("It is Palindrome!");
                }
                else
                {
                    Console.WriteLine("It is not Palindrome!");
                }
                Console.WriteLine("Want to check again? Press any key...");
                Console.ReadKey(true);
                Option("1", "Check Another Word?");
                Option("2", "Back To Home Menu!");
                Option("3", "Quit");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    continue;
                }
                else if (option == "2")
                {
                    Program.MainMenu();
                }
                else if (option == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again: ");
                }
            }
        }

        //General sorting Menu 
        public static void SortingHomePage()
        {
            for (; ; )
            {
                string userString = "";
                Option("1", "Sorting Number");
                Option("2", "Sorting Alphabetical");
                Option("3", "Back To Home Page");
                Option("4", "Quit");
                userString = Console.ReadLine();
                if (userString == "1")
                {
                    Console.Clear();
                    SortingNumberMenu();
                }
                else if (userString == "2")
                {
                    Console.Clear();
                    SortingAlphabeticalMenu();
                }
                else if (userString == "3")
                {
                    Console.Clear();
                    Program.MainMenu();
                }
                else if (userString == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again: ");
                }
            }
        }

        //Sorting Number Menu
        public static void SortingNumberMenu()
        {
            for (; ; )
            {
                string userString = "";
                Option("1", "Sorting Ascending Number");
                Option("2", "Sorting Descending Number");
                Option("3", "Back To Home Page");
                Option("4", "Quit");
                userString = Console.ReadLine();
                if (userString == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Enter size of index:");
                    int a = int.Parse(Console.ReadLine());
                    int[] index = new int[a];
                    Console.WriteLine("Enter number until the last number: \n press 'Enter' to type new number");
                    for (int i = 0; i < index.Length; i++)
                    {
                        index[i] = int.Parse(Console.ReadLine());
                    }
                    AllMethods.SortingAscendingNum(ref index, a);
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write(index[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to sort again? Press any key...");
                    Console.ReadKey(true);
                }
                else if (userString == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Enter size of index:");
                    int a = int.Parse(Console.ReadLine());
                    int[] index = new int[a];
                    Console.WriteLine("Enter number until the last number: \n press 'Enter' to type new number");
                    for (int i = 0; i < index.Length; i++)
                    {
                        index[i] = int.Parse(Console.ReadLine());
                    }
                    AllMethods.SortingDescendingNum(ref index, a);;
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write(index[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to sort again? Press any key...");
                    Console.ReadKey(true);
                }
                else if (userString == "3")
                {
                    Console.Clear();
                    Program.MainMenu();
                }
                else if (userString == "4")
                {
                   Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again: ");
                }
            }

        }
        public static void SortingAlphabeticalMenu()
        {
            for (; ; )
            {
                string userString = "";
                Option("1", "Sorting Ascending Words");
                Option("2", "Sorting Descending Words");
                Option("3", "Back To Home Page");
                Option("4", "Quit");
                userString = Console.ReadLine();
                if (userString == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Enter size of index:");
                    int a = int.Parse(Console.ReadLine());
                    string[] index = new string[a];
                    Console.WriteLine("Enter words until the last number: \n press 'Enter' to type new word");
                    for (int i = 0; i < index.Length; i++)
                    {
                        index[i] = Console.ReadLine();
                    }
                    AllMethods.SortingAZ(ref index, a);
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write(index[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to sort again? Press any key...");
                    Console.ReadKey(true);
                }
                else if (userString == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Enter size of index:");
                    int a = int.Parse(Console.ReadLine());
                    string[] index = new string[a];
                    Console.WriteLine("Enter words until the last number: \n press 'Enter' to type new word");
                    for (int i = 0; i < index.Length; i++)
                    {
                        index[i] = Console.ReadLine();
                    }
                    AllMethods.SortingZA(ref index, a);
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write(index[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to sort again? Press any key...");
                    Console.ReadKey(true);
                }
                else if(userString == "3")
                {
                    Console.Clear();
                    Program.MainMenu();
                }
                else if (userString == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again: ");
                }
            }

        }
        public static void SearchingNumberMenu()
        {
            for (; ; )
            {
                string userString = "";
                Option("1", "Let's start searching");
                Option("2", "Back To Home Page");
                Option("3", "Close App");
                userString = Console.ReadLine();
                if (userString == "1")
                {
                    Console.Clear();
                    Console.WriteLine("We have a secret list of number!");
                    Console.WriteLine("Enter a number that you want to search in the list: ");
                    int userInput = int.Parse(Console.ReadLine());
                    if (AllMethods.BinaryNumberSearch(userInput) != -1)
                    {
                        Console.WriteLine("You have found it, and it located at index " + AllMethods.BinaryNumberSearch(userInput));
                        Console.WriteLine();
                        Console.WriteLine("Do you want to find another one? Press any key...");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine("Not found!");
                        Console.WriteLine();
                        Console.WriteLine("Do you want to try again? Press any key...");
                        Console.ReadKey(true);
                    }
                        
                }
                else if (userString == "2")
                {
                    Console.Clear();
                    Program.MainMenu();
                }
                else if (userString == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again: ");
                } 
            }
        }
    }
}
