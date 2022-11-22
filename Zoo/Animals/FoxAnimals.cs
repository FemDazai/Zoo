
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class FoxAnimals : AbstractAnimal
    {
        public FoxAnimals(string name, int age) : base(name, age, 15, 5)
        {
            Species = "Fox";
            Biome = BiomeType.Forest;
            IsPredator = true;
            FoodType = new List<string>() { "Meat", "Birds","Beetles" };
            _sound = "Qruur";
        }
        public override Message DoPlay()
        {
            return new Message()
            {
                Text = $"{Name} run",
                SenderName = Name,
                SenderType = "Fox",
                MessageType = MessageType.AnimalDoPlay,
            };
        }
    }
}
