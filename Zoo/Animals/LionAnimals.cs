using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class LionAnimals: AbstractAnimals
    {
            public LionAnimals(string name, int age) : base(name, age)
            {
                Biome = BiomeType.Tundra;
                Food = FoodType.Meat;
                _sound = "Rrar";
             
            }

            public override void DoPlay()
            {
                Console.WriteLine($"{Name} run");
            }
        }
}
