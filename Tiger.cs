using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Skapar en ny klass som ärver från Animal
    public class Tiger : Animal
    {
        public override bool IsWild => true;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override string Breed { get; set; }
        public override double Weight { get; set; }

        //Klassens unika egenskap som framhäver tigerns livslängd
        public int LifeSpan { get; set; }


        public Tiger(string name = "tiger", string color = "orange", int age = 0, string breed = "okänt", double weight = 0, int lifeSpan = 15)
            : base(name, color, age, breed, weight)
        {
            LifeSpan = lifeSpan;
        }

        public override void IntroduceAnimal()
        {
            Console.WriteLine($"Jag heter {Name} och är en tiger. Jag är av rasen {Breed} och har har färgen {Color}." +
            $" Jag är {Age} år gammal och väger {Weight} kg. Jag hoppas jag lever i ca {LifeSpan} år som de flesta" +
            "tigrar gör.");
        }
        public override void MakeSound()
        {
            Console.WriteLine("RAWWWR!");
        }
        public override void Food()
        {
            Console.WriteLine("Det jag tycker är riktigt mumsigt är stora/medelstora klövdjur som hjortar och vildsvin. " +
                "men jag gillar även apor, harar och fisk också!");
        }

        //Klassens unika metod
        public void Hunting()
        {
            Console.WriteLine("Jag jagar alltid ensam och jag brukar smyga mig på mina byten!");
        }
    }
    
}
