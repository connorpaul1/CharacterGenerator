﻿using CharacterGenerator.Menus;
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

            while (choice != Enum.GetNames(typeof(Races)).Length + 1) 
            {

                var menuChoice = RaceMenu.DisplayMenu();

                var raceName = String.Empty;

                switch (menuChoice)
                {

                    case Races.Dragonborn:

                        raceName = Races.Dragonborn.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        
                       var numberOption = RaceMenu.RaceMenuChoice(raceName);
                        if (numberOption == 2)
                        {
                            RaceMenu.DisplayMenu();
                        }
                        else
                        {
                            Console.WriteLine("Valid Choice Selected");
                            Thread.Sleep(1000);
                        }

                        // run method RaceMenuChoice here, without clearing console
                        // store resulting playerRaceChoice variable

                        break;

                    case Races.Dwarf:

                        raceName = Races.Dwarf.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;

                    case Races.Elf:

                        raceName = Races.Elf.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;

                    case Races.Gnome:

                        raceName = Races.Gnome.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;

                    case Races.Half_Elf:

                        raceName = Races.Half_Elf.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;

                    case Races.Half_Orc:

                        raceName = Races.Half_Orc.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;

                    case Races.Halfling:

                        raceName = Races.Halfling.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;

                    case Races.Human:

                        raceName = Races.Human.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;


                    case Races.Tiefling:

                        raceName = Races.Tiefling.ToString();

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
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Increase two Ability Scores by 1 point.");
                        Console.WriteLine("You gain Proficiency in one Skill of your choice.");
                        Console.WriteLine("You gain one Feat of your choice.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        RaceMenu.RaceMenuChoice(raceName);

                        break;

                    default:
                        break;
                }



            }



        }
    }
}
