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

namespace ZooTest
{
    public class DoSoundTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractAnimal animal = new LionAnimals("Alex", 5);
            Message expectedMessage = new Message()
            {
                Text = $"Alex, makes sounds Rrar",
                SenderName = "Alex",
                SenderType = "AbstractAnimals",
                MessageType = MessageType.AnimalDoSound
            };

            yield return new object[] { animal,  expectedMessage };
        }
    }
}
