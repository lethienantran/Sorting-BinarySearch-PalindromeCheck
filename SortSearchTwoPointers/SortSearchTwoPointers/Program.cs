using System;
using System.Collections.Generic;

namespace SortSearchAndTwoPointers; 
class Program
{
   
    public static void Main(string[] args)
    {
        
        MainMenu();
        
    }
    public static void MainMenu()
    {
        Console.Clear();
        string userInput = "";
        Console.WriteLine("WELCOME TO OUR MENU");
        AllOptionMenu.Option("1", "Checking Palindrome Word");
        AllOptionMenu.Option("2", "Sorting Number & Letters");
        AllOptionMenu.Option("3", "Searching Number Game!");
        AllOptionMenu.Option("4", "Quit!");
        userInput = Console.ReadLine();
        if (userInput == "1")
        {
            Console.Clear();
            AllOptionMenu.PalindromeHomeMenu();
        }
        else if (userInput == "2")
        {
            Console.Clear();
            AllOptionMenu.SortingHomePage();
        }
        else if (userInput == "3")
        {
            Console.Clear();
            AllOptionMenu.SearchingNumberMenu();
        }
        else if (userInput == "4")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Wrong Input. Try again!");
        }
    }
}
