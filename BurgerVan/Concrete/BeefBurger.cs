using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerVan.Concrete
{
    //Beef burger can exist without decorator. Inherits from abstract class
    public class BeefBurger : Burger
    {
        //Sets description (Replaces Unknown Burger)
        public BeefBurger()
        {
            Description = "Beef Burger";
        }

        //This is the base cost for a beef burger
        public override double Cost()
        {
            return 1.99;
        }
    }
}
