using Zoo;
using Zoo.Optionss;
using Zoo.Animals;

//Console.WriteLine(BiomeType.Savanna);
//Console.WriteLine(FoodType.Grass);
//Zebra a = new Zebra("Marty");
//a.Name = "jj";
//a.Name = " g";
//a.Age = -4;
//a.TheAmountOfFoodConsumedPerDay = 2;
//a.DoSound();
ZebraAnimals zebra = new ZebraAnimals("Marty",5);
LionAnimals lion = new LionAnimals("Alex", 3);
zebra.DoSound();
lion.DoSound();
zebra.DoPlay();
lion.DoPlay();
