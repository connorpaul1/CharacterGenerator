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
            Console.WriteLine("");

            // I want to move each submenu, like "race selection" into its own individual class and create a corresponding method, then call on the method created seperately back into the "Main" method.

            RaceMenu.DisplayMenu();
            RaceDescriptions.DisplayRaceDescription();

            



        }
    }
}
