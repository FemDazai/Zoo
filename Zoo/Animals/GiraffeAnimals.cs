
using Zoo.Optionss;

namespace Zoo.Animals
{
    public  class GiraffeAnimals: AbstractAnimal
    {
        public GiraffeAnimals(string name, int age) : base(name, age, 40, 14)
        {
            Biome = BiomeType.Savanna;
            Kind = AnimalFoodType.Herbivore;
            FoodType = new List<string>() { "Leaves" };
            _sound = "aa-aa-aa";
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} run");
        }
    }
}
