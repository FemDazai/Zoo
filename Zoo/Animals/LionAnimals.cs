
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class LionAnimals: AbstractAnimal
    {
        public LionAnimals(string name, int age,int requiredSquare, int amountOfFood) : base(name, age, requiredSquare,  amountOfFood)
        {
                Biome = BiomeType.Tundra;
               FoodType = new List<string>() { "Meat", "Birds" };
                _sound = "Rrar";
        }

        public override void DoPlay()
        {
                Console.WriteLine($"{Name} run");
        }
    }
}
