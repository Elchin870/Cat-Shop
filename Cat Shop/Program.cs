namespace Cat_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetShop petShop = new PetShop();

            CatHouse house1 = new CatHouse();
            CatHouse house2 = new CatHouse();

            Cat cat1 = new Cat("Whiskers", 2, "Male", 50, 100.0m, 5);
            Cat cat2 = new Cat("Snowball", 1, "Female", 40, 120.0m, 6);

            house1.AddCat(cat1);
            house2.AddCat(cat2);

            petShop.AddCatHouse(house1);
            petShop.AddCatHouse(house2);

            Console.WriteLine($"Total cost of all cats: {petShop.CalculateTotalCatCost()}");
            Console.WriteLine($"Total meal quantity needed: {petShop.CalculateTotalMealQuantity()}");

            cat1.Play();
            cat2.Eat();
        }
    }
}
