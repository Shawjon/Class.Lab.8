using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab._8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesNo = true;
            ///make a new string with the class size and three spots (name, location, fav food
            string[,] devBuildClass = new string[,]
            {
                    { "Michael Hern", "Canton, MI", "Chicken Wings" } ,
                    { "Taylor Everts", "Caro, MI", "Cordon Bleu"},
                    { "Joshua Zimmerman", "Taylor, MI", "Turkey" },
                    { "Lin-Z Chang", "Toledo, OH", "Ice Cream" },
                    { "Madelyn Hilty", "Oxford, MI", "Croissent" },
                    { "Nana Banahene", "Guana", "Empanadas" },
                    { "Rochelle Toles", "Mars", "Space Cheese" },
                    { "Shah Shahid", "Newark, NJ", "Chicken Wings" },
                    { "Tim Broughton", "Detroit, MI", "Chicken Parm" },
                    { "Abby Wessels", "Traverse City, MI", "Soup" },
                    { "Blake Shaw", "Los Angeles, CA", "Cannolis" },
                    { "Bob Valentic", "St. Clair Shores, MI", "Pizza" },
                    { "Jordan Owiesny", "Warren, MI", "Burgers" },
                    { "Jay Stiles", "Macomb, MI", "Pickles" },
                    { "Jon Shaw", "Huntington Woods, MI", "Ribs"},
            };
            while (yesNo == true)
            {
                try
                {
                    Console.WriteLine("Welcome to our C# class. \nWhich student would you like to learn more about? ");
                    Console.Write("(enter a number 1-15): ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Student " + x + " is " + devBuildClass[x - 1, 0]);
                    Console.Write("What do you want to know about " + devBuildClass[x - 1, 0] + "?  ");
                    Console.Write("(enter \"Hometown\" or \"Favorite Food\"): ");
                    string entry = (Console.ReadLine());
                    while (entry.ToLower() != "favorite food" || entry.ToLower() != "hometown" )
                    {
                        if (entry.ToLower() == "favorite food" )
                        {
                            Console.WriteLine("The Favorite Food of " + devBuildClass[x - 1, 0] + " is " + devBuildClass[x - 1, 2] + ".");
                            break;
                        }
                        else if (entry.ToLower() == "hometown")
                        {
                            Console.WriteLine("The Hometown of " + devBuildClass[x - 1, 0] + " is " +devBuildClass[x - 1, 1] + ".");

                            break;
                        }
                        else
                        {
                            Console.Write("That is not a valid answer. Please enter \"Hometown\" or \"Favorite Food\": ");
                            entry = Console.ReadLine();
                           
                        }
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is not a vaild number in the student range");
                }


                Console.Write("Would you like to know about another student? (y/n): ");
                string end = Console.ReadLine() ;
                while (end.ToLower() != "n" || end.ToLower() != "y" || end.ToLower() != "no" || end.ToLower() != "yes")
                {
                    if (end.ToLower() == "n" || end.ToLower() == "no")
                    {
                        yesNo = false;
                        Console.WriteLine("Thank you, have a good day!");
                        break;
                    }
                    else if (end.ToLower() == "y" || end.ToLower() == "yes")
                    {
                        yesNo = true;
                        break;
                    }
                    else
                    {
                        Console.Write("That is not a valid answer, Would you like to know about another student? (y/n):  ");
                        end = Console.ReadLine();
                    }
                }
            }
        }
    }
}
        
    




    

