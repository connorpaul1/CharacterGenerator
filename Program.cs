using CharacterGenerator.Menus;
using System;
using System.Threading;
using static CharacterGenerator.enums;

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
            // Start by choosing your race

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

                var menuChoice = RaceMenu.DisplayMenu();

                switch (menuChoice)
                {
                    case Races.Dragonborn:
                        break;

                    case Races.Dwarf:
                        break;

                    case Races.Elf:
                        break;

                    case Races.Gnome:
                        break;

                    case Races.Half_Elf:
                        break;

                    case Races.Half_Orc:
                        break;

                    case Races.Halfling:
                        break;

                    case Races.Human:

                        string raceName = Races.Human.ToString();

                        Console.Clear();
                        Console.WriteLine($"You've chosen {raceName}");
                        Console.WriteLine($" {raceName} Description: In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that's why they build their mighty empires on the foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Features");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Age: Humans reach adulthood in their late teens and live less than a century.");
                        Console.WriteLine("Alignment: Humans tend toward no particular alignment. The best and the worst are found among them.");
                        Console.WriteLine("Size: Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.");
                        Console.WriteLine("Speed: Your base walking speed is 30 feet.");
                        Console.WriteLine("Languages: You can speak, read, and write Common and one extra language of your choice.");
                        Console.WriteLine("");



                    case Races.Tiefling:
                        break;

                    default:
                        break;
                }



            }



        }
    }
}
