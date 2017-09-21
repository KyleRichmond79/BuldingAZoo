using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04Kyle
{
    class Shark : SaltWater
    {

        public override void CanOnlyLive()
        {
            Console.WriteLine("I can only live in salt water.");
        }

        public override bool CanSwim()
        {
            Console.WriteLine("I'm a shark and I can swim!");
            return true;
        }

        public override void Eats()
        {
            Console.WriteLine("I will eat any animal I see.");
        }

        public override void Sleeps()
        {
            Console.WriteLine("I sleep at night.");
        }

        public override void HowIHunt()
        {
            Console.WriteLine("I hunt weaker prey.");
        }
    }
}
