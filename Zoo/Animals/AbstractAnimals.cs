
using Zoo.Optionss;
using static System.Net.Mime.MediaTypeNames;

namespace Zoo.Animals
{
    public abstract class AbstractAnimal
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

        public string Species { get;  protected set; }

        public BiomeType Biome { get; protected set; }

        public int Square { get; protected set; }

        public int AmountOfFood { get; protected set; }

        public bool IsPredator { get; protected set; }

        public  List<string> FoodType;

        public AbstractAnimal(string name, int age, int square , int amountOfFood)   

        {
            Name = name;
            Age = age;
            Square = square;
            AmountOfFood = amountOfFood;
        }
        protected string _sound;

        public virtual Message DoSound()
        {
            return new Message()
            {
                Text = $"{Name}, makes sounds {_sound}",
                SenderName = Name,
                SenderType ="AbstractAnimals",
                MessageType=MessageType.AnimalDoSound
            };
        }

        public Message DoEating(string food, int amountOfFood)
        {
            if (!FoodType.Contains(food))
            {
                return new Message()
                {
                    Text = $"{Name} don't eats {amountOfFood} kg {food}",
                    SenderName = Name,
                    SenderType = "AbstractAnimals",
                    MessageType = MessageType.DifferentTypeOfFood
                };
            }
            else if (amountOfFood > AmountOfFood)
            {
                return new Message()
                {
                    Text = $"{amountOfFood} kg  {food} , is too much for {Name}",
                    SenderName = Name,
                    SenderType = "AbstractAnimals",
                    MessageType = MessageType.ToMuchFood
                };
            }
            else
            {
                return new Message()
                {
                    Text = $"{Name} eats {amountOfFood} kg {food}",
                    SenderName = Name,
                    SenderType = "AbstractAnimals",
                    MessageType = MessageType.AnimalDoEating
                };
            }
        }
        public abstract Message DoPlay();
    }
}