using NUnit.Framework;
using Zoo;
using Zoo.Animals;
using Zoo.Optionss;

namespace ZooTest
{
    public class AbstractAnimalTests
    {
        [TestCaseSource(typeof(DoSoundTestSource))]
        public void DoSoundTest( AbstractAnimal animal ,Message expectedMessage)
        {
            Message actualMessage = animal.DoSound();
            AbstractAnimal actualAbstractAnimal = animal;
            Assert.AreEqual(expectedMessage, actualMessage);

        }
    }
}
