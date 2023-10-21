using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    //Skapar en ny klass som ärver från basklassen Animal
    public class Goat : Animal
    {
        public override bool IsWild => false;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override string Breed { get; set; }
        public override double Weight { get; set; }

        //Klassens unika egenskap som framhäver getens förmåga att hoppa
        public double Jump { get; set; }

        public Goat(string name = "get", string color = "vit", int age = 0, string breed = "okänt", double weight = 0, double jump = 0)
            : base(name, color, age, breed, weight)
            {
                Jump = jump;
            }

        public override void IntroduceAnimal()
        {
            Console.WriteLine($"Jag heter {Name} och är en get. Jag är av rasen {Breed} och har har färgen {Color}." +
                $" Jag är {Age} år gammal och väger {Weight} kg. Jag är en j*kel på att hoppa och kan nästan hoppa {Jump} m.");
        }
        public override void MakeSound()
        {
            Console.WriteLine("VaaAA-a");
        }
        public override void Food()
        {
            Console.WriteLine("Jag äter väldigt lite av mycket! Tillskillnad från andra betesdjur. Det godaste jag vet är löv");
        }

        //Klassens unika metod som beskriver vad geten producerar
        public void GetCheese()
        {
            Console.WriteLine("Jag producerar mjölk till människorna som dom sedan gör till ost.");
        }
    }
}