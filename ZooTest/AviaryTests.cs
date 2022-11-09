using NUnit.Framework;
using Zoo;
using Zoo.Animals;
using Zoo.Optionss;

namespace ZooTest
{
    public class AviaryTests
    {
        [TestCaseSource(typeof(AddAnimalTestSource))]
        public void AddAnimalTest(AbstractAnimal animal ,Aviary aviary, Aviary expectedAviary, Message expectedMessage)
        {
            Message actualMessage =aviary.AddAnimal(animal);
            Aviary actualAviary = aviary;
            Assert.AreEqual(expectedAviary, actualAviary);
            Assert.AreEqual(expectedMessage, actualMessage);  

        }

        [TestCaseSource(typeof(RemoveAnimalTestSource))]
        public void RemoveAnimalTest(AbstractAnimal animal, Aviary aviary, Aviary expectedAviary, Message expectedMessage)
        {
            Message actualMessage = aviary.RemoveAnimal(animal);
            Aviary actualAviary = aviary;
            Assert.AreEqual(expectedAviary, actualAviary);
            Assert.AreEqual(expectedMessage, actualMessage);

        }
    }
}