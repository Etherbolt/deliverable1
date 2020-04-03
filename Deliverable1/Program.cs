using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What kind of vacation would you like to go on, musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine();
            // input responds to: "musical", "tropical", and "adventurous", it is case sensitive

            Console.WriteLine("How many are in your group?");
            int groupSize = int.Parse(
            Console.ReadLine()
            );
            // input responds to any integer value

            string flight1 = "First Class Flight";
            string flight2 = "Helicopter Flight";
            string flight3 = "Charter Flight";
            string destination1 = "New Orleans";
            string destination2 = "Beach Vacation in Mexico";
            string destination3 = "Go Whitewater Rafting in the Grand Canyon"; {

                if (groupSize >= 1 && groupSize < 3 && vacationType == "musical")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + flight1 + " to " + destination1);
                }
                else if (groupSize >= 1 && groupSize < 3 && vacationType == "tropical")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + flight1 + " to " + destination2);
                }
                else if (groupSize >= 1 && groupSize < 3 && vacationType == "adventurous")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a " + flight1 + " to " + destination3);
                }
                else if (groupSize >= 3 && groupSize < 6 && vacationType == "musical")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + flight2 + " to " + destination1);
                }
                else if (groupSize >= 3 && groupSize < 6 && vacationType == "tropical")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + flight2 + " to " + destination2);
                }
                else if (groupSize >= 3 && groupSize < 6 && vacationType == "adventurous")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a " + flight2 + " to " + destination3);
                }
                else if (groupSize >= 6 && vacationType == "musical")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + flight3 + " to " + destination1);
                }
                else if (groupSize >= 6 && vacationType == "tropical")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + flight3 + " to " + destination2);
                }
                else if (groupSize >= 6 && vacationType == "adventurous")
                {
                    Console.WriteLine("Since you're a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a " + flight3 + " to " + destination3);
                }
            }
            // The string result would not print correctly, however, if used as an if else statement, the program functions as intended
            string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a (flight type) to (destination type)";
        }     
            
        
    }
}
