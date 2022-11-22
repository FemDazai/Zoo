using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo;
using Zoo.Optionss;
using System.Xml.Linq;
//using static System.Net.Mime.MediaTypeNames;

namespace ZooTest
{
    public class AddAnimalTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractAnimal animal = new LionAnimals("Alex", 5);
            Aviary aviary = new Aviary("Predators", BiomeType.Savanna, 70, "Lion");
            Aviary expectedAviary = new Aviary("Predators", BiomeType.Savanna, 70, "Lion");
            expectedAviary.Animals.Add(new LionAnimals("Alex", 5));
            Message expectedMessage = new Message()
            {
                Text = $" In Predators settle Lion Alex",
                SenderName = "Predators",
                SenderType = "Aviary",
                MessageType = MessageType.AnimalAdd,
            };

            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };


            animal = new FoxAnimals("Pic", 8);
            aviary = new Aviary("Predators", BiomeType.Savanna, 50, "Lion");
            aviary.Animals.Add(new LionAnimals("Zuba", 4));
            expectedAviary = new Aviary("Predators", BiomeType.Savanna, 50, "Lion");
            expectedAviary.Animals.Add(new LionAnimals("Zuba", 4));
            expectedMessage = new Message()
            {
                Text = $" In Predators didn't settle Fox Pic due to biome",
                SenderName = "Predators",
                SenderType = "Aviary",
                MessageType = MessageType.BiomesAreNotEqual,
            };

            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };


            animal = new LionAnimals("Zuba", 8);
            aviary = new Aviary("Predators", BiomeType.Savanna, 50, "Lion");
            aviary.Animals.Add(new LionAnimals("Alex", 4));
            expectedAviary = new Aviary("Predators", BiomeType.Savanna, 50, "Lion");
            expectedAviary.Animals.Add(new LionAnimals("Alex", 4));
            expectedMessage = new Message()
            {
                Text = $" In Predators didn't settle Lion Zuba due to  lack of space",
                SenderName = "Predators",
                SenderType = "Aviary",
                MessageType = MessageType.LittleFreeSpace,
            };

            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };


            animal = new GiraffeAnimals("Melman", 6);
            aviary = new Aviary("Predators", BiomeType.Savanna, 90, "Lion");
            aviary.Animals.Add(new LionAnimals("Alex", 4));
            expectedAviary = new Aviary("Predators", BiomeType.Savanna, 90, "Lion");
            expectedAviary.Animals.Add(new LionAnimals("Alex", 4));
            expectedMessage = new Message()
            {
                Text = $" In Predators didn't settle Giraffe Melman due neighbours",
                SenderName = "Predators",
                SenderType = "Aviary",
                MessageType = MessageType.NeighborsDontFit,
            };

            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };
        }
    }

    public class RemoveAnimalTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractAnimal animal = new LionAnimals("Zuba", 5);
            Aviary aviary = new Aviary("Predators", BiomeType.Savanna, 90, "Lion");
            aviary.Animals.Remove(new LionAnimals("Zuba", 5));
            aviary.Animals.Add(new LionAnimals("Lil", 5));
            Aviary expectedAviary = new Aviary("Predators", BiomeType.Savanna, 90, "Lion");
            expectedAviary.Animals.Add(new LionAnimals("Lil", 5));
            Message expectedMessage = new Message()
            {
                Text = $"Lion Zuba evicted from Predators",
                SenderName = "Predators",
                SenderType = "Aviary",
                MessageType = MessageType.AnimalRemove,
            };

            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };

            animal = new LionAnimals("Zuba", 5);
            aviary = new Aviary("Predators", BiomeType.Savanna, 90, "Lion");
            aviary.Animals.Remove(new LionAnimals("Zuba", 5));
            expectedAviary = new Aviary("Predators", BiomeType.Savanna, 90, "Lion");
            expectedAviary.Animals.Remove(new LionAnimals("Zuba", 5));
            expectedMessage = new Message()
            {
                Text = $"Empty Predators aviary ,no one to evict",
                SenderName = "Predators",
                SenderType = "Aviary",
                MessageType = MessageType.EmptyAviary,
            };

            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };
        }
    }

    //public class DoSoundTestSource : IEnumerable
    //{
    //    public IEnumerator GetEnumerator()
    //    {
           
    //    }
    //}

}
