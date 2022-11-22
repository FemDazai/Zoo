
using Zoo.Optionss;
using Zoo.Animals;
using static System.Net.Mime.MediaTypeNames;

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
        public override Message DoPlay()
        {
            return new Message()
            {
                Text = $"{Name} run",
                SenderName = Name,
                SenderType = "Giraffe",
                MessageType = MessageType.AnimalDoPlay,
            };
        }
    }
}
