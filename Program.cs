using System;
using System.Threading;

namespace CharacterGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // The "Main" Method is going to be used to display the "Main" menu, of sorts, after the character's name is input. Something like this:
            // **************************************
            // Character's Name: 
            // Character's Race:
            // Character's Class:
            // Character's Background: 
            //
            // Character's Height:
            // Character's Weight:
            // Character's Age:
            // **************************************


            Console.WriteLine("Welcome to the Item Pouch Character Generator!");
            Console.Write("Please enter your character's name: ");

            string charName = Console.ReadLine();

            Console.WriteLine($"Welcome, {charName}!");

            Console.WriteLine("Let's begin your character creation journey!");
            Thread.Sleep(1000);
            Console.WriteLine();

            // I want to move each submenu, like "race selection" into its own individual class and create a corresponding method, then call on the method created seperately back into the "Main" method.
            int choice = 1;

            while(choice < 11 || choice > 0 || choice != 11) 
            {
                Console.Clear();
                Console.WriteLine($"Choose your Race: ");
                Console.WriteLine("1. Human");
                Console.WriteLine("2. Dragonborn");
                Console.WriteLine("3. Dwarf");
                Console.WriteLine("4. Elf ");
                Console.WriteLine("5. Half-Elf");
                Console.WriteLine("6. Orc");
                Console.WriteLine("7. Half-Orc");
                Console.WriteLine("8. Halfling");
                Console.WriteLine("9. Gnome");
                Console.WriteLine("10. Tiefling");
                Console.WriteLine(" ");
                Console.WriteLine("11. Skip Race Selection");

                Console.Write("Enter your choice: ");
                int menuChoice = int.Parse(Console.ReadLine());

                //Exception pops here if User presses "Enter" without input, or enters anything that is not a number between 1 and 11. 

                switch (menuChoice)
                {
                    case 1:

                        string raceChoice = "Human";

                        Console.Clear();
                        Console.WriteLine($"You've chosen {raceChoice}");
                        Console.WriteLine($" {raceChoice} Description: In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that's why they build their mighty empires on the foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceChoice} Features");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Age: Humans reach adulthood in their late teens and live less than a century.");
                        Console.WriteLine("Alignment: Humans tend toward no particular alignment. The best and the worst are found among them.");
                        Console.WriteLine("Size: Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.");
                        Console.WriteLine("Speed: Your base walking speed is 30 feet.");
                        Console.WriteLine("Languages: You can speak, read, and write Common and one extra language of your choice.");
                        Console.WriteLine("");

                        Console.WriteLine($"Finalize {raceChoice} as your race?");

                        Console.WriteLine("1. Continue");
                        Console.WriteLine("2. Go Back");
                        int raceMenuChoice = int.Parse(Console.ReadLine());

                        if (raceMenuChoice == 1)
                        {
                            string playerRace = raceChoice;
                            Console.WriteLine($"You are now a {playerRace}!");
                            
                        }
                        // Need to program next step > choose character class that proceeds from here

                        if (raceMenuChoice == 2)
                        {
                            Console.WriteLine("Headed back to Race menu...");
                            Thread.Sleep(500);

                        }
                        // Application exits without looping to race menu, need to loop back to race menu with choices

                        else
                        {
                            Console.WriteLine("Invalid menu selection, please retry.");
                            return;
                        }
                        // Exception Here that pops up if user enters anything besides a number, need to handle

                        return;

                    case 11:
                        Console.WriteLine("Exiting Character Creation");
                        choice = 11;
                        break;

                }

                if (choice == 11)
                {
                    break;
                }


            }



        }
    }
}
