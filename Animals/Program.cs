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
            List<Animal> animals = new List<Animal>();

            animals.Add(new Bird("kk", 30, 12, 19));
            animals.Add(new Pelican("kk1", 30, 12, 19, 34));
            animals.Add(new Flamingo("kk123", 30, 12, 19, 431));
            animals.Add(new Swan("kk1321", 30, 12, 19, 431));
            animals.Add(new Horse("Shiney", 600, 14, "Mustang"));
            animals.Add(new Dog("Bingo", 35, 5, "bulldog"));
            animals.Add(new Wolf("xxx", 45, 12, "Dingo"));
            animals.Add(new WolfMan("yyy", 67, 36, "Tundra", "Full"));

            foreach (var animal in animals)
            {
                animal.DoSound();
                animal.Stats();

                if (animal is Dog)
                {
                    Dog doggy = (Dog)animal;
                    doggy.DoTrick();
                }

                if (animal is IPerson)
                {
                    IPerson hybrid = (IPerson)animal;
                    hybrid.Talk();
                }
            }


           

            //List<UserError> usererror = new List<UserError>();
            //usererror.Add(new NumericInputError());
            //usererror.Add(new TextInputError());
            //usererror.Add(new LongLengthInputError());
            //usererror.Add(new ShortLengthInputError());
            //usererror.Add(new WrongInputError());

            ////Console.WriteLine(usererror[0].UEMessage());

            //foreach(var temp in usererror)
            //{
            //    Console.WriteLine( temp.UEMessage());
            //}

        }


    } 
}
