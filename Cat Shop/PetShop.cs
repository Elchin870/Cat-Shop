using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Shop
{
    internal class PetShop
    {
        public List<CatHouse> CatHouses { get; private set; }
        public int CatHouseCount => CatHouses.Count;

        public PetShop()
        {
            CatHouses = new List<CatHouse>();
        }

        public void AddCatHouse(CatHouse catHouse)
        {
            CatHouses.Add(catHouse);
            Console.WriteLine("A new cat house has been added to the pet shop.");
        }

        public decimal CalculateTotalCatCost()
        {
            decimal totalCost = 0;
            foreach (var catHouse in CatHouses)
            {
                foreach (var cat in catHouse.Cats)
                {
                    totalCost += cat.Price;
                }
            }
            return totalCost;
        }

        public int CalculateTotalMealQuantity()
        {
            int totalMealQuantity = 0;
            foreach (var catHouse in CatHouses)
            {
                foreach (var cat in catHouse.Cats)
                {
                    totalMealQuantity += cat.MealQuantity;
                }
            }
            return totalMealQuantity;
        }
    }
}
