using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            IArmor armor = new Leather("Elven Leather Armor", 12);
            IWeapon sword = new Sword("Long sword", 5);

            IArmor armor1 = new Steel("Elven Steel Armor", 21);
            IWeapon dagger = new Dagger("Piercing dagger", 7);

            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);


            ICombatant goodGuy = new Fighter("Good Guy Gary", armor1, dagger);

            fighter.Attack(badGuy);
            goodGuy.Attack(fighter);
        }
    }
}
