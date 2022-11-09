
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class ZebraAnimals:AbstractAnimal 
    {
        public ZebraAnimals(string name, int age) : base(name, age, 30, 10)
        {
            Species = "Zebra";
            Biome = BiomeType.Savanna;
            IsPredator = false;
            Age = age;
            FoodType = new List<string>() { "Grass", "Leaves","Bark" };
            _sound = "Firf-Firf";
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} run and jump");
        }
    }

}
