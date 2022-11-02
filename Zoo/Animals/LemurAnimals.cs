using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class LemurAnimals : AbstractAnimals
        {
        public LemurAnimals(string name, int age, int requiredSquare, int amountOfFood) : base(name, age, requiredSquare, amountOfFood)
            {
                Biome = BiomeType.Tundra;
            FoodType = new List<string>() { "Flowers", "Fruits", "Leaves" };
                _sound = "Aq-Aq-Aq";
            }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} run");
        }
    }
}
