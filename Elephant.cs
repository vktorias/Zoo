using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Skapar en ny klass som ärver från basklassen Animal
    public class Elephant : Animal
    {
        public override bool IsWild => true;
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override string Breed { get; set; }
        public override double Weight { get; set; }

        //Klassens unika egenskap
        public int Hearing { get; set; }

        public Elephant(string name = "elefant", string color = "grå", int age = 0, string breed = "okänt", double weight = 0, int hearing = 0)
            : base(name, color, age, breed, weight)
        {
            Hearing = hearing;
        }

        public override void IntroduceAnimal()
        {
            Console.WriteLine($"Jag heter {Name} och är en stor elefant. Jag är av rasen {Breed} och har har färgen {Color}." +
                $" Jag är {Age} år gammal och väger {Weight} stadiga ton. Det speciella med mig är min grymma hörsel. Jag kan höra under {Hearing} Hertz, " +
            "ingen vågar snacka skit bakom min rygg!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("YyY-m!");
        }
        public override void Food()
        {
            Console.WriteLine("Jag äter mycket stora mängder om dagen. Ca 150-200 kg mat som består av det jag hittar, det kan vara blad, " +
                "bark, kvistar och grenar. Ibland hittar jag frukt och då blir jag extra glad!");
        }

        //Klassens unika metod
        public void SwimmingSkills()
        {
            Console.WriteLine($"Fun fact: Jag älskar att simma! Det trodde du inte om mig och mina {Weight} ton va?");
        }
    }
}
