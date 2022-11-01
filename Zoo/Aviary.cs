using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo.Optionss;

namespace Zoo
{
    public class Aviary
    {
        public string AviaryName { get; protected set; }
        public BiomeType AviaryBiome { get; protected set; }

        public int AviaryRequiredSquare { get; protected set; }
        public Aviary(string name, BiomeType biome, int requiredSquare)

        {
            AviaryName = "Herbivores";
            AviaryBiome = BiomeType.Savanna ;
            AviaryRequiredSquare = 450;
        }

        public List<AbstractAnimals>Animals { get; set; }
    }
}
