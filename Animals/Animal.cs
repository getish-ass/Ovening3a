using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    
    public interface IPerson
    {
        void Talk();
    }
    abstract class Animal 
    {
         
         public String Name { get; set; }
         public float Weight { get; set; }
         public uint Age { get; set; }


         public Animal(string name, float weight, uint age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
         public abstract void DoSound();
        public virtual string Stats()
        {
            return $"name:{Name} weight: {Weight} age: {Age}";
        }

    }

    class Horse : Animal
    {
        string HorseType { get; set; }
        public Horse(string name, float weight, uint age, string horsetype) : base(name, weight, age)
        {
            HorseType = horsetype;
        }
       
        public override void DoSound()
        {
            Console.WriteLine("ehihihihi");
        }
        public override string Stats()
        {
            return base.Stats() + $"Horse Type:{HorseType}";
        }
    }
    class Dog : Animal 
    {
        public string DogType { get; set; }

        public Dog(string name, float weight, uint age, string dogtype) : base(name, weight, age)
        {
            DogType = dogtype;
        }
        public override void DoSound()
        {
            Console.WriteLine("wowowowowow...");
        }
        public override string Stats()
        {
            return base.Stats() + $"Dog Type:{DogType}";
        }
    }
    class Hedgehog : Animal
    {
        public uint NrOfSpikes { get; set; }

        public Hedgehog(string name, float weight, uint age, uint nrofspikes ) : base(name, weight, age)
        {
            NrOfSpikes = nrofspikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("wetsweths...");
        }
        public override string Stats()
        {
            return base.Stats() + $"NrOfSpikes:{NrOfSpikes}";
        }
    }
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, float weight, uint age, bool ispoisonous) : base(name, weight, age)
        {
            IsPoisonous = ispoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("chichi...");
        }
        public override string Stats()
        {
            return base.Stats() + $"Poisonous status: {IsPoisonous}";
        }
    }
    class Bird : Animal
    {
        
        public float WingSpan { get; set; }

        public Bird(string name, float weight, uint age, float wingspan) : base(name, weight, age)
        {
            WingSpan = wingspan; 
        }
        public override void DoSound()
        {
            Console.WriteLine("wiowio...");
        }
        public override string Stats()
        {
            return base.Stats() + $"Wing Span:{WingSpan}";
        }
    }
    class Wolf : Animal
    {
        public string WolfType { get; set; }

        public Wolf(string name, float weight, uint age, string wolftype) : base(name, weight, age)
        {
            WolfType = wolftype;
        }
        public override void DoSound()
        {
            Console.WriteLine("Ouuuuuuu...");
        }
        public override string Stats()
        {
            return base.Stats() + $"Wolf Type:{WolfType}";
        }
    }
    class Pelican: Bird
    {
       private float PelicanLength { get; set; }

       public Pelican(string name, float weight, uint age, float wingspan, float pelicanlength) : base(name, weight, age, wingspan)
        {
            PelicanLength = pelicanlength;
        }
        public override string Stats()
        {
            return base.Stats() + $"Pelican Length:{PelicanLength}";
        }
    }
    class Flamingo : Bird
    {
       private float FlamingoLength { get; set; }
        public Flamingo(string name, float weight, uint age, float wingspan, float flamingolength) : base(name, weight, age, wingspan)
        {
            FlamingoLength = flamingolength;
        }
        public override void DoSound()
        {
            Console.WriteLine("kakakakaka...");
        }
       
        public override string Stats()
        {
            return base.Stats() + " " + $"Flamingo Length:{FlamingoLength}";
        }
    }
    class Swan : Bird 
    {
      private float SwanLength { get; set; }
      
      public Swan(string name, float weight, uint age, float wingspan, float swanlength) : base(name, weight, age, wingspan)
        {
            SwanLength = swanlength;
        }
        public override string Stats()
        {
            return base.Stats() + $"Swan Length:{SwanLength}";
        }

    }

    internal class WolfMan : Wolf, IPerson
    {
        public string Hairiness { set; get; } 
        public WolfMan(string name, float weight, uint age, string wolftype, string hairiness) : base(name, weight, age, wolftype)
        {
            Hairiness = hairiness;
        }
        public void Talk()
        {
            Console.WriteLine("The wolfman can talk");
        }
        public override string Stats()
        {
            return base.Stats() + " " + $"Hairiness: {Hairiness}";
        }
    }




}
