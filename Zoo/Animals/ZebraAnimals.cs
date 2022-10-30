using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Zoo.Optionss;

namespace Zoo.Animals
{
    public class ZebraAnimals:AbstractAnimals 
    {
        public ZebraAnimals(string name, int age):base(name, age)
        {
            Biome = BiomeType.Savanna;
            Food = FoodType.Grass;
            _sound = "Firf-Firf";
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} run and jump");
        }
    }

}
