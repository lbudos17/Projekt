using System.Security.Cryptography.X509Certificates;

namespace Program {
    class Character {
        public string characterClass;
        public string characterName;

        public Character (string characterClass, string characterName) {
            this.characterClass = characterClass;
            this.characterName = characterName;


        }
        public void print() {
            Console.WriteLine("Character class: " + characterClass + "\nCharacter name: " + characterName);
        }

    }
}