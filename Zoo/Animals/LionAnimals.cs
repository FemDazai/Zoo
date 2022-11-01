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
        public LionAnimals(string name, int age,int requiredSquare, int amountOfFood) : base(name, age, requiredSquare,  amountOfFood)
        {
                Biome = BiomeType.Tundra;
                List <string> food=new List<string>() { "Meat", "Birds" };
                _sound = "Rrar";
        }

        public override void DoPlay()
        {
                Console.WriteLine($"{Name} run");
        }
    }
}
