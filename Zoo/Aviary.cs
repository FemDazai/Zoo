
using Zoo.Animals;
using Zoo.Optionss;

namespace Zoo
{
    public class Aviary
    {
        public string Name { get; protected set; }
        public BiomeType Biome { get; protected set; }
        public int Square { get; protected set; }
        public AnimalFoodType AnimalFoodType { get; set; }
        public List<AbstractAnimal>Animals { get; protected set;}
        protected int _filledArea;
        public Aviary(string name, BiomeType biome, int square)

        {
            Name = name;
            Biome = BiomeType.Savanna ;
            Square = square;
            Animals = new List<AbstractAnimal>();    
        }


        public string AddAnimal(AbstractAnimal animal)
        {
            if (Biome != animal.Biome)
            {
                return($" In {Name} didn't settle {animal.Name} due to biome");
            }
            else if ( _filledArea < Square)
            {
                return($" In {Name} didn't settle {animal.Name} due to  lack of space");
            }
            else
            { 
                Animals.Add(animal);
                return($" In {Name} settle {animal.Name }");
            }               
        }
    }
}
