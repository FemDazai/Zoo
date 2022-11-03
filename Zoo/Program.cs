using Zoo;
using Zoo.Optionss;
using Zoo.Animals;


//Console.WriteLine(BiomeType.Savanna);
////Console.WriteLine(FoodType.Grass);
ZebraAnimals zebra = new ZebraAnimals("Marty", 5, 12, 8);
//a.Name = "jj";
//a.Name = " g";
//zebra.Age = -4;
//a.TheAmountOfFoodConsumedPerDay = 2;
//a.DoSound();

LionAnimals lion = new LionAnimals("Alex", 3,55,88);
LemurAnimals lemur = new LemurAnimals("Julien", 5,12,2);
zebra.DoSound();
lion.DoSound();
zebra.DoPlay();
zebra.DoEating("Meat");
lemur.DoEating("Fruits");

lion.DoPlay();
