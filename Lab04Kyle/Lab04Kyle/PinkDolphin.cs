using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04Kyle
{
    class PinkDolphin : FreshWater
    {

        public override void CanOnlyLive()
        {
            Console.WriteLine("I can only live in fresh water.");
        }

        public override bool CanSwim()
        {
            Console.WriteLine("I can swim!");
            return true;
        }

        public override void Eats()
        {
            Console.WriteLine("I eat fish.");
        }

        public override void Sleeps()
        {
            Console.WriteLine("I am Echo the pink dolphin and I sleep at night.");
        }

        public override void HowIHunt()
        {
            Console.WriteLine("I hunt schools of fish.");
        }
    }
}
