
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class LionAnimals: AbstractAnimal
    {
        public LionAnimals(string name, int age) : base(name, age, 30,  6)
        {
               Biome = BiomeType.Savanna;
               Kind = AnimalFoodType.Predator;
               FoodType = new List<string>() { "Meat", "Birds" };
               _sound = "Rrar";
        }

        public override void DoPlay()
        {
                Console.WriteLine($"{Name} run");
        }
    }
}
