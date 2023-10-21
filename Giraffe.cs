using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Skapar en ny klass som ärver från basklassen Animal
    public class Giraffe : Animal
    {
        //Använder override för att de ska kunna överskrivas från den abstracta basklassen. Override måste användas för att både egenskaperna och metoderna ska kunna ärvas från 
        //den abstracta basklassen Animal.
        public override bool IsWild => true;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override string Breed { get; set; }
        public override double Weight { get; set; }

        //Klassens unika egenskap som framhäver giraffens längd
        public double Lenght { get; set; }

        //Konstruktor för klassen som tilldelar namn till egenskaperna.
        //Sätter ett standard (default) värde för att kunna skapa en ny giraff utan att behöva fylla i specifika värden.
        //Använder ": base" för att programmet ska veta vilka egenskaper som ärvs från basklassen
        public Giraffe(string name = "Giraff", string color = "Orange", int age = 10, string breed = "Okänt", double weight = 700, double lenght = 3)
            : base(name, color, age, breed, weight)
        {
            Lenght = lenght;
        }

        //Metod som ärvts från basklassen Animal
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"Jag heter {Name} och är en Giraff. Jag är av rasen {Breed} och har har färgen {Color}." +
                    $" Jag är {Age} år gammal och väger {Weight} kg. Det speciella med mig är min längd som är hela {Lenght} m, den längden" +
                    " kan inte många djur slå!!");
        }
        //Metod som ärvts från basklassen Animal
        public override void MakeSound()
        {
            Console.WriteLine("Mitt läte är så lågt så människor kan inte höra mig.");
        }
        //Metod som ärvts från basklassen Animal
        public override void Food()
        {
            Console.WriteLine("Det jag gillar att mumsa på mest är blad från träd. Yummie!");
        }

        //Klassens unika metod
        public void ToungeLenght()
        {
            Console.WriteLine("Min blåa tunga är 43 cm lång!");
        }
    }
}
