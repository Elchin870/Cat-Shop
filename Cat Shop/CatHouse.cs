using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Shop
{
    internal class CatHouse
    {
        public List<Cat> Cats { get; private set; }
        public int CatCount => Cats.Count;

        public CatHouse()
        {
            Cats = new List<Cat>();
        }

        public void AddCat(Cat cat)
        {
            Cats.Add(cat);
            Console.WriteLine($"{cat.Nickname} has been added to the cat house.");
        }

        public void RemoveByNickname(string nickname)
        {
            Cat catToRemove = Cats.Find(cat => cat.Nickname == nickname);
            if (catToRemove != null)
            {
                Cats.Remove(catToRemove);
                Console.WriteLine($"{nickname} has been removed from the cat house.");
            }
            else
            {
                Console.WriteLine($"No cat with the nickname {nickname} found.");
            }
        }
    }
}
