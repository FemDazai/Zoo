
using System.Security.Cryptography.X509Certificates;
using Zoo.Animals;
using Zoo.Optionss;
using static System.Net.Mime.MediaTypeNames;

namespace Zoo
{
    public class Aviary
    {
        public string Name { get; protected set; }
        public BiomeType Biome { get; protected set; }
        public int Square { get; protected set; }
        public List<AbstractAnimal>Animals { get; protected set;}
        protected string _sound;
        public Aviary(string name, BiomeType biome, int square,string species )
        {
            Name = name;
            Biome = BiomeType.Savanna ;
            Square = square;
            Animals = new List<AbstractAnimal>();
        }

        public Message AddAnimal(AbstractAnimal animal)
        {
            if (Biome != animal.Biome)
            {
                return new Message()
                {
                    Text = $" In {Name} didn't settle {animal.Species} {animal.Name} due to biome",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.BiomesAreNotEqual,
                };
            }
            else if  ( FreeArea () < animal.Square)
            {
                return new Message()
                {
                    Text = $" In {Name} didn't settle {animal.Species} {animal.Name} due to  lack of space",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.LittleFreeSpace,
                };
            }
            else if (!Neighbours(animal))
            {
                return new Message()
                {
                    Text = $" In {Name} didn't settle {animal.Species} {animal.Name} due neighbours",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.NeighborsDontFit,
                };
            }
            else
            {  
                Animals.Add(animal);
                return new Message()
                {
                    Text = $" In {Name} settle {animal.Species} {animal.Name}",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AnimalAdd,
                };
            }  
        }

        protected int FreeArea()
        { 
             int freeArea= Square;
            foreach (AbstractAnimal a in Animals)
            {
                freeArea -= a.Square;
            }
            return freeArea;                       
        }

        protected bool Neighbours(AbstractAnimal animal )
        {
            foreach(AbstractAnimal a in Animals)
            {
                if ((a.IsPredator || animal.IsPredator ) && a.Species != animal.Species)
                {
                    return false;
                }              
            }
            return true;
        }
        public Message RemoveAnimal(AbstractAnimal animal)
        {
            if (Animals.Count != 0)
            {
                Animals.Remove(animal);
                return new Message()
                {
                    Text = $"{animal.Species} {animal.Name} evicted from {Name}",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AnimalRemove,
                };
            }
            else
            {
                return new Message()
                {
                    Text = $"Empty {Name} aviary ,no one to evict",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.EmptyAviary,
                };
            }
        }

        public void AnimalsDoSound()
        {
            foreach (AbstractAnimal a in Animals)
            {
                Console.WriteLine(a.DoSound);
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Aviary aviary &&
                   Name == aviary.Name &&
                   Biome == aviary.Biome &&
                   Square == aviary.Square &&
                   Animals.Count == aviary.Animals.Count;
        }
    }
}
