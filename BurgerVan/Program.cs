using System;
using BurgerVan.Concrete;
using BurgerVan.Toppings;
namespace BurgerVan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Creates the object burger1 from the base class BeefBurger. 
            Undecorated */

            Burger burger5 = new ChickenBurger();
            Console.WriteLine(burger5.Description + " $" + burger5.Cost());

            Burger burger1 = new BeefBurger();
            Console.WriteLine(burger1.Description + " $" + burger1.Cost());



            //Creates the burger2 from the ChickenBurger class
            Burger burger2 = new ChickenBurger();
            //Object is then decorated 
            burger2 = new OnionAddon(burger2);
            Console.WriteLine(burger2.Description + " $" + burger2.Cost());
            burger2 = new TomatoAddon(burger2);
            Console.WriteLine(burger2.Description + " $" + burger2.Cost());

            /*Creates the decorated object burger3 by passing in 
             the concrete class ChickenBurger as an argument */
            Burger burger3 = new LettuceAddon(new BeefBurger());
            Console.WriteLine(burger3.Description + " $" + burger3.Cost());
            //Decorates with additional toppings
            burger3 = new TomatoAddon(burger3);
            Console.WriteLine(burger3.Description + " $" + burger3.Cost());
            burger3 = new LettuceAddon(burger3);

            Console.ReadKey();
        }
    }
}
