using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04Kyle
{
   abstract class Avian : Species
    {
        public bool HasWings()
        {
            return true;
        }
        abstract public void CanFly();
        abstract public void MakesSound();
    } 
}
