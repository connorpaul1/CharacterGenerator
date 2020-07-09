using System;
using System.Collections.Generic;
using System.Text;
using static CharacterGenerator.enums;

namespace CharacterGenerator
{
    public class PlayerCharacter
    {
        public string CharacterName { get; set; }

        public Races CharacterRace { get; set; }

        public Classes CharacterClass { get; set; }

        public Backgrounds CharacterBackground { get; set; }

        public int CharacterWeight { get; set; }

        public int CharacterHeight { get; set; }

        public int CharacterAge { get; set; }


    }
}
