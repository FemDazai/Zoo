using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class LemurAnimals : AbstractAnimal
        {
        public LemurAnimals(string name, int age) : base(name, age, 10, 1)
            {
            Species = "Lemur";
            Biome = BiomeType.Tundra;
            IsPredator = false;
            FoodType = new List<string>() { "Flowers", "Fruits", "Leaves" };
               _sound = "Aq-Aq-Aq";
            }
        public override Message DoPlay()
        {
            return new Message()
            {
                Text = $"{Name} run and jump",
                SenderName = Name,
                SenderType = "Lemur",
                MessageType = MessageType.AnimalDoPlay,
            };
        }
    }
}
