using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerVan.Concrete
{
    //Chicken burger can exist without decorator. Inherits from abstract class
    public class ChickenBurger : Burger
    {
        //Sets description (Replaces Unknown Burger)
        public ChickenBurger()
        {
            Description = "Chicken Burger";
        }

        //This is the base cost for the burger
        public override double Cost()
        {
            return .99;
        }
    }
}
