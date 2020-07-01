using System;
using System.Collections.Generic;
using System.Text;
using static CharacterGenerator.enums;

namespace CharacterGenerator.Menus
{
    public class RaceMenu
    {
        public static Races DisplayMenu()

        {
            Console.Clear();
            Console.WriteLine($"Choose your Race: ");
            var races = Enum.GetValues(typeof(Races));
            for (int i = 0; i < races.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {races.GetValue(i)}");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"{Enum.GetNames(typeof(Races)).Length+1}. Skip Race Selection");

            Console.Write("Enter your choice: ");
            int.TryParse(Console.ReadLine(), out var menuChoice);
            return (Races)menuChoice-1;
        }


        public static int RaceMenuChoice(string raceName)
        {
            Console.WriteLine($"Finalize {raceName} as your race?");

            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Go Back");
            int.TryParse(Console.ReadLine(), out var raceMenuChoice);

            if (raceMenuChoice == 1)
            {
                string playerRace = raceName;
                Console.WriteLine($"You are now a {playerRace}!");
                break;
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

            }
            // Exception Here that pops up if user enters anything besides a number, need to handle
            break;

        }


        public static void Run()
        {


        }
    }
}
