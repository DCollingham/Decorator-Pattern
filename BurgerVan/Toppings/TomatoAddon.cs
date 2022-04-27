using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerVan.Toppings
{
    //Can not exist alone
    public class TomatoAddon : Decorator.BurgerDecorator
    {
        /*Instance variable that is set to what is passed through the constructor. Immutable. 
         Can only be set during construction*/
        private readonly Burger _burger;

        /*Constructor takes Burger object as an argument
         and sets instance variable to argument*/
        public TomatoAddon(Burger burger)
        {
            this._burger = burger;
        }

        //Takes passed-in description and adds topping to it
        public override string Description => _burger.Description + " + Tomatoes";

        /*Takes the cost of the burger(may already have toppings) passed in through 
         the constructor and adds cost the cost this topping*/
        public override double Cost()
        {
            return this._burger.Cost() + 0.30;
        }
    }
}
