using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Zoo
{   //Viktoria Wallström .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar en lista av Animal som sparas i "AnimalsInZoo"
            List<Animal> AnimalsInZoo = new List<Animal>()
            {
                //Skapar nya instanser av olika djurklasser med de specifika egenskaperna
                new Monkey("Simon", "brun", 35, "Schimpans", 50, 130),
                new Giraffe("Lina", "beige med stora rödbruna fläckar", 17, "masai", 1.100, 4.2),
                new Elephant("Ellen", "grå", 60, "skogselefant", 2000, 16),
                new Tiger("Daniel", "orangeröd med vita fläckar i nacken och svarta ränder på rygg", 6, "malayatiger", 300, 15),
                new Gorilla("Artur", "svart med silverfärgad rygg", 20, "bergsgorilla", 200, 132, "starkare än 15 vuxna tillsammans"),
                new Orangutang("Oliver", "Orange med svart ansikte", 25, "pongo pygmaeus", 90, 129, "regnskogens trädtoppar"),
                new Horse("Speedy", "ljusbrun", 14, "holländsk varmblod", 426, 71),
                new Goat("Ragnar", "grå och vit", 8, "lappget", 50, 1.60),
            };

            //Djuren filtreras i två kategorier beroende på om dessa djur är tam eller vild 
            var wildAnimals = AnimalsInZoo.Where(animal => animal.IsWild);
            var domesticatedAnimals = AnimalsInZoo.Where(animal => !animal.IsWild);

            Console.WriteLine("* Hej och välkommen till detta Zoo! \n" +
                "Du kommer nu få lära känna massor av intressanta djur *"); //Skriver ut i början av programmet
            Console.WriteLine(); //För att skapa space i programmet
            Console.WriteLine("-- Här är en presentation av våra tama djur: --");
            Console.WriteLine();

            //En foreach loop som skriver ut information om de tama djuren
            foreach (var animal in domesticatedAnimals)
            {
                PrintAnimal(animal);
            }
            Console.WriteLine("-- Här är en presentation av våra vilda djur: --");
            Console.WriteLine();

            //En foreach loop som skriver ut information om de vilda djuren
            foreach (var animal in wildAnimals)
            {
                PrintAnimal(animal);
            }
            Console.WriteLine("--------------------------------------------------------------------------"); //Skrivs ut i slutet
            Console.WriteLine("Hoppas du tyckte det var ett roligt besök på detta Zoo. \nVälkommen åter! "); 
        }
            //Skapar en ny metod 
            public static void PrintAnimal(Animal animal)
            {
                //Anropar metoderna från basklassen som skrivs ut för varje djur
                animal.IntroduceAnimal();
                animal.Food();
                animal.MakeSound();
                
                //En if-sats som kollar om djuret finns och skriver ut specifik information beroende på vilket djur som skapats
                if (animal is Monkey monkey)
                {
                    monkey.Family();
                    if (animal is Gorilla gorilla)
                    {
                        gorilla.SilverBack();
                    }
                    else if (animal is Orangutang orangutang)
                    {
                        orangutang.ToolSkills();
                    }
                }
                else if (animal is Giraffe giraffe)
                {
                    giraffe = (Giraffe)animal;
                    giraffe.ToungeLenght();
                }
                else if (animal is Elephant elephant)
                {
                    elephant.SwimmingSkills();
                }
                else if (animal is Tiger tiger)
                {
                    tiger.Hunting();
                }
                else if (animal is Horse horse)
                {
                    horse.Race();
                }
                else if (animal is Goat goat)
                {
                    goat.GetCheese();
                }

                //Använder en Console.Writeline(); utanför ifsatsen för att den efter varje gång programmet körs skapar space mellan textraderna
                Console.WriteLine();
            }
    }
}