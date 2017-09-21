using Lab04Kyle;
using System;

namespace Lab04_Kyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are my animals in a zoo.");
            //this is my shark
            Shark GreatWhite = new Shark();
            GreatWhite.CanSwim();
            GreatWhite.HowIHunt();
            Owl GreatHornedOwl = new Owl();
            GreatHornedOwl.CanFly();
            PinkDolphin Echo = new PinkDolphin();
            Echo.Sleeps();

 
            Console.Read();
        }

    }
}
