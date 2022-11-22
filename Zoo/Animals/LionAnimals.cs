
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class LionAnimals: AbstractAnimal
    {
        public LionAnimals(string name, int age) : base(name, age, 30,  6)
        {
            Species = "Lion";
               Biome = BiomeType.Savanna;
            IsPredator = true;
            FoodType = new List<string>() { "Meat", "Birds" };
               _sound = "Rrar";
        }
        public override Message DoPlay()
        {
            return new Message()
            {
                Text = $"{Name} run",
                SenderName = Name,
                SenderType = "Lion",
                MessageType = MessageType.AnimalDoPlay,
            };
        }
    }
}
