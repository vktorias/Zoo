using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    //Skapar en klass som ärver både från basklassen Animal och underklassen Monkey
    //Denna klass ärvs med andra ord i två nivåer
    public class Gorilla : Monkey
    {
        //Klassens unika egenskap som tar fram gorillans styrka
        public string Strenght { get; set; }

        public Gorilla(string name = "gorilla", string color = "svart", int age = 0, string breed = "okänt", double weight = 0, 
            int iq = 0, string strenght = "okänt")
            : base(name, color, age, breed, weight, iq)
        {
            Strenght = strenght;
        }


        public override void IntroduceAnimal()
        {
            {
                Console.WriteLine($"Jag heter {Name} och är en Gorilla. Jag är av rasen {Breed} och har har färgen {Color}." +
                    $" Jag är {Age} år gammal och väger {Weight} kg. Det speciella med mig är mitt höga IQ som är på {IQ}. " +
                    $"Otroligt smart om jag får säga det själv! Dessutom är jag extremt stark, jag är {Strenght}.");
                    
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("OOhOhohHO!");
        }
        public override void Food()
        {
            Console.WriteLine("Jag livnär mig mest på frukt och örter! Men ibland även termiter och myror. Smaskens!");
        }

        public override void Family()
        {
            Console.WriteLine("Jag lever väldigt nära min familj, vi är runt 10 stycken i min skara.");
        }
        
        //Klassens unika metod som beskriver gorillans roll i sin flock
        public void SilverBack()
        {
            Console.WriteLine("Jag är nämligen den stora hanen i flocken och kallas för silverback. Jag har ansvaret att leda min flock!");
        }
    }
}

