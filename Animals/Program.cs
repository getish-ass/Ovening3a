using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bird bird = new Bird("kiki", 12, 5, 12);
            //bird.Age = 10;
            //bird.WingSpan = 15.2f;
            //bird.DoSound();
            //Console.WriteLine("The bird's age is " + bird.Age);
            //Console.WriteLine("The bird's wing span is " + bird.WingSpan);
            //Console.WriteLine("The bird sings");
            //WolfMan wolfman = new WolfMan("Wolfi", 75, 15, "Alaskan", "HalveHairy");
            //wolfman.Talk();
            //Console.WriteLine(wolfman.Stats());
            //
            //Flamingo flamingo = new Flamingo("Longi", 40, 10, 150, 180);
            //flamingo.DoSound();
            //Console.WriteLine(flamingo.Stats());
            List<Animal> animal = new List<Animal>();

            animal.Add(new Bird("kk", 30, 12, 19));
            animal.Add(new Horse("Shiney", 600, 14, "Mustang"));
            animal.Add(new Dog("Bingo", 35, 5, "bulldog"));
            animal.Add(new Wolf("xxx", 45, 12, "Dingo"));
            animal.Add(new WolfMan("yyy", 67, 36, "Tundra", "Full"));

            //animal[4].Talk();


            NewMethod(animal);

        }

        private static void NewMethod(List<Animal> animal)
        {
            foreach (var jur in animal)
            {

                 jur.DoSound();
                 //jur.Stats(); 

            }
        }
    }
}
