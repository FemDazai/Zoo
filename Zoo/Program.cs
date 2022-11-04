using Zoo;
using Zoo.Optionss;
using Zoo.Animals;


////Console.WriteLine(BiomeType.Savanna);
//////Console.WriteLine(FoodType.Grass);
//ZebraAnimals zebra = new ZebraAnimals("Marty", 5);
////a.Name = "jj";
////a.Name = " g";
////zebra.Age = -4;
////a.TheAmountOfFoodConsumedPerDay = 2;
////a.DoSound();

//LionAnimals lion = new LionAnimals("Alex", 3);
//LemurAnimals lemur = new LemurAnimals("Julien", 5);
//zebra.DoSound();
//lion.DoSound();
//zebra.DoPlay();
//zebra.DoEating("Grass",12);
//lemur.DoEating("Fruits",1);

//lion.DoPlay();
Aviary aviary = new Aviary("Volier1", BiomeType.Savanna, 60);
GiraffeAnimals giraffe = new GiraffeAnimals("Melman", 2);
Console.WriteLine(aviary.AddAnimal(giraffe));

