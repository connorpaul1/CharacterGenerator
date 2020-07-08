using CharacterGenerator.Menus;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using static CharacterGenerator.enums;

namespace CharacterGenerator
{
    class RaceDescriptions
    {

        public static void DisplayRaceDescription()
        {
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
                        Console.WriteLine($" {raceName} Description: Born of dragons, as their name proclaims, the dragonborn walk proudly through a world that greets them with fearful incomprehension. Shaped by draconic gods or the dragons themselves, dragonborn originally hatched from dragon eggs as a unique race, combining the best attributes of dragons and humanoids. Some dragonborn are faithful servants to true dragons, others form the ranks of soldiers in great wars, and still others find themselves adrift, with no clear calling in life.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Features");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Age: Young dragonborn grow quickly. They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach adulthood by 15. They live to be around 80.");
                        Console.WriteLine("Alignment: Dragonborn tend to extremes, making a conscious choice for one side or the other in the cosmic war between good and evil (represented by Bahamut and Tiamat, respectively). Most dragonborn are good, but those who side with Tiamat can be terrible villains.");
                        Console.WriteLine("Size: Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging almost 250 pounds. Your size is Medium.");
                        Console.WriteLine("Speed: Your base walking speed is 30 feet.");
                        Console.WriteLine("Languages: You can speak, read, and write Common and Draconic. Draconic is thought to be one of the oldest languages and is often used in the study of magic. The language sounds harsh to most other creatures and includes numerous hard consonants and sibilants.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Ability Score Increase: Your Strength score increases by 2, and your Charisma score increases by 1");
                        Console.WriteLine("Draconic Ancestry: You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage resistance are determined by the dragon type, as shown in the table.");
                        Console.WriteLine("Breath Weapon: You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your draconic ancestry. The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can’t use it again until you complete a short or long rest. ");
                        Console.WriteLine("Damage Resistance: You have resistance to the damage type associated with your draconic ancestry.");
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
                        Console.WriteLine($" {raceName} Description: Kingdoms rich in ancient grandeur, halls carved into the roots of mountains, the echoing of picks and hammers in deep mines and blazing forges, a commitment to clan and tradition, and a burning hatred of goblins and orcs—these common threads unite all dwarves.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Features");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Age: Dwarves mature at the same rate as humans, but they’re considered young until they reach the age of 50. On average, they live about 350 years.");
                        Console.WriteLine("Alignment: Most dwarves are lawful, believing firmly in the benefits of a well-ordered society. They tend toward good as well, with a strong sense of fair play and a belief that everyone deserves to share in the benefits of a just order.");
                        Console.WriteLine("Size: Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.");
                        Console.WriteLine("Speed: Your base walking speed is 25 feet. Your speed is not reduced by wearing heavy armor.");
                        Console.WriteLine("Languages: You can speak, read, and write Common and Dwarvish. Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Darkvision: Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");
                        Console.WriteLine("Dwarven Resilience: You have advantage on saving throws against poison, and you have resistance against poison damage.");
                        Console.WriteLine("Dwarven Combat Training: You have proficiency with the battleaxe, handaxe, light hammer, and warhammer.");
                        Console.WriteLine("Tool Proficiency: You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.");
                        Console.WriteLine("Stonecunning: Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Subraces");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Hill Dwarf");
                        Console.WriteLine("Ability Score Increase: Your Wisdom score increases by 1.");
                        Console.WriteLine("Dwarven Toughness: Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.");
                        Console.WriteLine("");
                        Console.WriteLine("Mountain Dwarf");
                        Console.WriteLine("Ability Score Increase: Your Strength score increases by 2.");
                        Console.WriteLine("Dwarven Armor Training: You have proficiency with light and medium armor.");
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
                        Console.WriteLine($" {raceName} Description: Elves are a magical people of otherworldly grace, living in the world but not entirely part of it. They live in places of ethereal beauty, in the midst of ancient forests or in silvery spires glittering with faerie light, where soft music drifts through the air and gentle fragrances waft on the breeze. Elves love nature and magic, art and artistry, music and poetry, and the good things of the world.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Features");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Age: Although elves reach physical maturity at about the same age as humans, the elven understanding of adulthood goes beyond physical growth to encompass worldly experience. An elf typically claims adulthood and an adult name around the age of 100 and can live to be 750 years old.");
                        Console.WriteLine("Alignment: Elves love freedom, variety, and self-expression, so they lean strongly toward the gentler aspects of chaos. They value and protect others’ freedom as well as their own, and they are more often good than not. The drow are an exception; their exile into the Underdark has made them vicious and dangerous. Drow are more often evil than not.");
                        Console.WriteLine("Size: Elves range from under 5 to over 6 feet tall and have slender builds. Your size is Medium.");
                        Console.WriteLine("Speed: Your base walking speed is 30 feet.");
                        Console.WriteLine("Languages: You can speak, read, and write Common and Elvish. Elvish is fluid, with subtle intonations and intricate grammar. Elven literature is rich and varied, and their songs and poems are famous among other races. Many bards learn their language so they can add Elvish ballads to their repertoires.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Starting Traits");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Darkvision: Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");
                        Console.WriteLine("Keen Senses: You have proficiency in the Perception skill.");
                        Console.WriteLine("Fey Ancestry: You have advantage on saving throws against being charmed, and magic can’t put you to sleep.");
                        Console.WriteLine("Trance: Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep.");
                        Console.WriteLine("");
                        Console.WriteLine($"{raceName} Subraces");
                        Console.WriteLine("--------------");
                        Console.WriteLine("");
                        Console.WriteLine("Eladrin");
                        Console.WriteLine("Ability Score Increase: Your Intelligence score increases by 1.");
                        Console.WriteLine("Elf Weapon Training: You have proficiency with the longsword, shortsword, shortbow, and longbow.");
                        Console.WriteLine("Fey Step: You can cast the misty step spell once using this trait. You regain the ability to do so when you finish a short or long rest.");
                        Console.WriteLine("");
                        Console.WriteLine("High Elf");
                        Console.WriteLine("Ability Score Increase: Your Intelligence score increases by 1.");
                        Console.WriteLine("Elf Weapon Training: You have proficiency with the longsword, shortsword, shortbow, and longbow.");
                        Console.WriteLine("Cantrip: You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.");
                        Console.WriteLine("Extra Language: You can speak, read, and write one extra language of your choice.");
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
                        Console.WriteLine($" {raceName} Description: A constant hum of busy activity pervades the warrens and neighborhoods where gnomes form their close-knit communities. Louder sounds punctuate the hum: a crunch of grinding gears here, a minor explosion there, a yelp of surprise or triumph, and especially bursts of laughter. Gnomes take delight in life, enjoying every moment of invention, exploration, investigation, creation, and play.");
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
