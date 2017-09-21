using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04Kyle
{
    class Owl : Nocturnal
    {

        public override void CanFly()
        {
            Console.WriteLine("I can fly because I am an Great Horned Owl!");
        }

        public override void Eats()
        {
            Console.WriteLine("I eat rodents.");
        }

        public override void HowIHunt()
        {
            Console.WriteLine("I hunt by flying over my prey and catching them in my large talons.");
        }

        public override void MakesSound()
        {
            Console.WriteLine("I make a 'Hoooo' sound.");
        }

        public override void Sight()
        {
            Console.WriteLine("I see best at night.");
        }

        public override void Sleeps()
        {
            Console.WriteLine("I sleep during the day.");
        }
    }
}
