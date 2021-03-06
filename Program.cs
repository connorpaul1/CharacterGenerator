﻿using CharacterGenerator.Menus;
using System;
using System.Collections.Generic;
using System.Threading;
using static CharacterGenerator.enums;

namespace CharacterGenerator
{
    class Program
    {
        public static List<PlayerCharacter> PlayerCharacters = new List<PlayerCharacter>();


        static void Main(string[] args)
        {

            PlayerCharacter character = new PlayerCharacter();

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
            character.CharacterName = charName;

            Console.WriteLine($"Welcome, {charName}!");

            Console.WriteLine("Let's begin your character creation journey!");
            Thread.Sleep(1000);
            Console.WriteLine("");


            var race = MainMenu.DisplayMenu();
            RaceDescriptions.DisplayRaceDescription(race);


            PlayerCharacters.Add(character);


        }
    }
}
