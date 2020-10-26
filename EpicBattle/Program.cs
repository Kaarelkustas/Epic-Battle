using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Bilbo Baggins", "Lara Croft" };
            string[] villains = { "Voldemort", "darth vader", "Sauron", "joker", "harley queen" };

            String hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            Console.WriteLine($"{hero} will fight {villain}");

            Random rnd = new.Random();
            int HeroHP = rnd.Next(5, 11);
            int villainHP = rnd.Next(5, 11);

        }

        public static GetCharacter(string [] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Lenght)];
            return randomString;
        }

        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }



    }
}
