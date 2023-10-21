using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Skapar en ny klass som ärver från både basklassen Animal och underklassen (subklassen) Monkey
    //Denna klass ärvs med andra ord i två nivåer
    public class Orangutang : Monkey
    {
        //Klassens unika egenskap som tar fram orangutangens förmåga att klättra
        public string Climb { get; set; }

        public Orangutang(string name = "orangutang", string color = "orange", int age = 0, string breed = "okänt", double weight = 0,
            int iq = 0, string climb = "okänt")
            : base(name, color, age, breed, weight, iq)
        {
            Climb = climb;
        }


        public override void IntroduceAnimal()
        {
            {
                Console.WriteLine($"Jag heter {Name} och är en Orangutang. Jag är av rasen {Breed} och har färgen {Color}." +
                    $" Jag är {Age} år gammal och väger {Weight} kg. Det speciella med mig är mitt höga IQ som är på {IQ}. " +
                    $"Otroligt smart om jag får säga det själv! Jag är stolt över att vara jag - jag är det största trädlevande " +
                    $"däggdjuret. Jag trivs bäst bland {Climb}!");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("ohohoh!");
        }
        public override void Food()
        {
            Console.WriteLine("Jag äter helst insekter, honung och frukt!");
        }

        public override void Family()
        {
            Console.WriteLine("Jag lever för det mesta ensam.");
        }

        //Klassens unika metod som beskriver orangutangens kunskaper att skapa verktyg
        public void ToolSkills()
        {
            Console.WriteLine("En specialitet jag har är att göra enkla verktyg för att klia mig. Jag brukar också använda lövfyllda grenar " +
                "för att skydda mig mot sol och regn!");
        }
    }
}

