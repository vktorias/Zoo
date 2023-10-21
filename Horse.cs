using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Skapar en ny klass som ärver av basklassen Animal
    public class Horse : Animal
    {
        public override bool IsWild => false;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override string Breed { get; set; }
        public override double Weight { get; set; }

        //Klassens unika egenskap som framhäver hästens förmåga att springa
        public int Speed { get; set; }

        public Horse(string name = "häst", string color = "vit", int age = 0, string breed = "okänt", double weight = 0, int speed = 0)
            : base(name, color, age, breed, weight)
        {
            Speed = speed;
        }

        public override void IntroduceAnimal()
        {
            Console.WriteLine($"Jag heter {Name} och är en häst. Jag är av rasen {Breed} och har har färgen {Color}." +
                $" Jag är {Age} år gammal och väger {Weight} stadiga ton. Jag är känd för hur snabb jag är. Jag kan nämligen springa" +
                $" {Speed} km/h. ");
        }
        public override void MakeSound()
        {
            Console.WriteLine("B-rRn!");
        }
        public override void Food()
        {
            Console.WriteLine("Jag äter ett specialhö eftersom att jag tränar så hårt... Men ibland till helgsnackset fuskar jag " +
                "med ett gäng morötter! hehe");
        }

        //Klassens unika metod som beskriver att hästen är en tävlingshäst
        public void Race()
        {
            Console.WriteLine($"Jag är en tävlingshäst som vunnit många lopp! En av anledningarna till att jag kan springa så snabbt som" +
                $" {Speed} km/h!");
        }
    }
}
