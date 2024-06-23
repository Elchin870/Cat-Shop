using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Shop
{
    internal class Cat
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Energy { get; private set; }
        public decimal Price { get; set; }
        public int MealQuantity { get; set; }

        public Cat(string nickname, int age, string gender, int energy, decimal price, int mealQuantity)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }

        public void Eat()
        {
            Energy += MealQuantity;
            Console.WriteLine($"{Nickname} has eaten and now has {Energy} energy.");
        }

        public void Sleep()
        {
            Energy += 20;
            Console.WriteLine($"{Nickname} slept and now has {Energy} energy.");
        }

        public void Play()
        {
            Energy -= 15;
            Console.WriteLine($"{Nickname} played and now has {Energy} energy.");
            if (Energy <= 0)
            {
                Energy = 0;
                Console.WriteLine($"{Nickname} is tired and needs to sleep.");
            }
        }
    }
}

