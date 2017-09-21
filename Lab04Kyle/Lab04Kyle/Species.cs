using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04Kyle
{
    abstract class Species

    {
        //public string Location { get; set; }
        //public int HoursOfOperation { get; set; }
        //public int MaxOccupancy { get; set; }

        abstract public void Eats();

        abstract public void Sleeps();

        abstract public void HowIHunt();
    }
}