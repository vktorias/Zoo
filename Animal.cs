using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{

    //Skapar en basklass för djur
    public abstract class Animal
    {
        //Skapar egenskaper som alla andra klasser kommer ha gemensamt 
        
        public abstract bool IsWild { get; } //En bool som kollar om djuren är vilda eller tama. Behövs endast { get; } för att djuren kommer alltid vara antingen vilda eller tama
        public abstract string Name { get; set; } //{ get; } gör så man hämtar värdet. { set; } gör att man kan kan ändra värdet.
        public abstract string Color { get; set; }
        public abstract int Age { get; set; }
        public abstract string Breed { get; set; }
        public abstract double Weight { get; set; }

        //Konstruktor för klassen som tilldelar namn på egenskaperna
        public Animal(string name, string color, int age, string breed, double weight)
        {
            Name = name;
            Color = color;
            Age = age;
            Breed = breed;
            Weight = weight;
        }
        //Skapar metoder som alla andra klasser kommer ärva
        public abstract void IntroduceAnimal(); //Metod som introducerar alla djur

        public abstract void MakeSound(); //Metod som skriver ut djurens läte

        public abstract void Food(); //Metod som beskriver vad djuren äter

    }
}
