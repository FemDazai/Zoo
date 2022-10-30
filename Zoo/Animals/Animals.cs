using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Optionss;

namespace Zoo.Animals
{
    public abstract class AbstractAnimals
    {
        private string _name;
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (value != " ")
                    {
                    _name = value;
                    }
                    else
                    {
                        throw new ArgumentException("You can't leave an animal without a name.");
                    }
                }
            }
        private int _age;
            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
                    if (value >= 0)
                    {
                        _age = value;
                    }
                    else
                    {
                        throw new ArgumentException("You can't enter a negative number like age.");
                    }
                }
            }

            public BiomeType Biome { get; protected set; }

            public FoodType Food { get; set; }

            public string RequiredArea { get; protected set; }

            public int TheAmountOfFoodConsumedPerDay { get; set; }

            public bool IsPradator { get; protected set; }

            protected string _sound;

        public AbstractAnimals(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DoSound()
            {
                Console.WriteLine($"{Name}, makes sounds {_sound}");
            }

        public abstract void DoPlay();
          

            public void DoEating()
            {
                Console.WriteLine("Eat");
            }
        }
}
