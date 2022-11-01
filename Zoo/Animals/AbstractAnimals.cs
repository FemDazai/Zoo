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

        public int RequiredSquare { get; protected set; }

        public int AmountOfFood { get; protected set; }

        public bool IsPradator { get; protected set; }
        List<string> FoodType;
        public AbstractAnimals(string name, int age, int requiredSquare, int amountOfFood)

        {
            Name = name;
            Age = age;
            RequiredSquare = requiredSquare;
            AmountOfFood = amountOfFood; 
            //FoodType = new List<string>();
            //{
            //   "Meat",
            //  "Birds",
            //  "Flowers",
            //  "Fruits",
            //  "Leaves",
            //  "Grass", 
            //  "Leaves",
            //  "Bark"
            //};  
        }
        protected string _sound;

        public virtual void DoSound()
        {
            Console.WriteLine($"{Name}, makes sounds {_sound}");
        }
        
        public void DoEating(string food)
        {
            if (FoodType.Contains(food))
            {
                Console.WriteLine($" {Name} eats  {food}");
            }
            else
            {
                Console.WriteLine($" {Name} don't eats  {food}");
            }
        }
        public abstract void DoPlay();

    }
}