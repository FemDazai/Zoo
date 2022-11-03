
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class ZebraAnimals:AbstractAnimal 
    {
        public ZebraAnimals(string name, int age, int requiredSquare, int amountOfFood) : base(name, age, requiredSquare, amountOfFood)
        {
            Biome = BiomeType.Savanna;
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
