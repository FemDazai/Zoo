
using Zoo.Animals;
using Zoo.Optionss;

namespace Zoo
{
    public class Aviary
    {
        public string Name { get; protected set; }
        public BiomeType Biome { get; protected set; }
        public int Square { get; protected set; }
        public int FilledSquare { get; protected set; }
        public AnimalFoodType AnimalFoodType { get; set; }
        public List<AbstractAnimal>Animals { get; set;}
        protected int _filledSquare;
        public Aviary(string name, BiomeType biome, int requiredSquare, AnimalFoodType animalFoodType)

        {
            Name = "Herbivores";
            Biome = BiomeType.Savanna ;
            Square = 450;
            AnimalFoodType = animalFoodType;
        }
        public void AddAnimal(AbstractAnimal animal)
        {
            if (AnimalFoodType==AnimalFoodType.Herbivore)
            Animals.Add(animal);
        }
    }
}
