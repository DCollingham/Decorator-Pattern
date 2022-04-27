using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerVan
{
    //Base class can not be used to create objects
    public abstract class Burger
    {
        //Can be overidden by any class that inherts it
        //Derived classes have the ability to set Description
        public virtual string Description { get; protected set; } = "Unknown Burger";
        public abstract double Cost();
    }
}
