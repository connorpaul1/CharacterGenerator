using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    public class MainMenu
    {
        public int MyProperty { get; set; }


        public static PlayerCharacter DisplayMenu()
        {

            PlayerCharacter character = new PlayerCharacter();

            Console.Clear();
            Console.WriteLine($"1. Create new Character");
            Console.WriteLine($"2. Randomly create new Character");
            Console.WriteLine($"3. List exising Characters");
            Console.WriteLine($"{Environment.NewLine} X: Exit Tool");



        }


    }
}
