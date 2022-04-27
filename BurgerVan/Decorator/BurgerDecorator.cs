using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerVan.Decorator
{
    public abstract class BurgerDecorator : Burger
        //The burger decorator inherits from burger class
        
    {
        //Can not be instantiated. Oversides burger class description.
        public abstract override string Description { get; }
    }
}
