using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Skapar en ny klass som ärver från basklassen Animal
    public class Monkey : Animal
    {
        public override bool IsWild => true;
        public override string Name {get; set;} 
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override string Breed { get; set; }
        public override double Weight { get; set; }

        //Klassens unika egenskap som tar fram apans IQ
        public int IQ { get; set; }

        public Monkey(string name = "Apa", string color = "brun", int age = 0, string breed = "okänt", double weight = 0, int iq = 0)
            :base(name, color, age, breed, weight)
        {
            IQ = iq;
        }

        public override void IntroduceAnimal()
        {
            {
                Console.WriteLine($"Jag heter {Name} och är en apa. Jag är av rasen {Breed} och har färgen {Color}." +
                    $" Jag är {Age} år gammal och väger {Weight} kg. Det speciella med mig är mitt höga IQ som är på {IQ}. " +
                    $"Otroligt smart om jag får säga det själv!");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("OooOaaA!");
        }
        public override void Food()
        {
            Console.WriteLine("Det jag mest gillar att äta är frukt - fikon och citrusfrukter är min favoit!");
        }

        //Klassens unika metod som beskriver apans flockstorlek
        public virtual void Family()
        {
            Console.WriteLine("Jag är ett flockdjur och vi är omkring 20 i min flock.");
        }

    }

    
}
