
using Zoo.Optionss;

namespace Zoo.Animals
{
    public  class GiraffeAnimals: AbstractAnimal
    {
        public GiraffeAnimals(string name, int age) : base(name, age, 40, 14)
        {
            Species = "Giraffe";
            Biome = BiomeType.Savanna;
           IsPredator = false;
            FoodType = new List<string>() { "Leaves" };
            _sound = "aa-aa-aa";
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} run");
        }
    }
}
