using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        //Catalog of everything that can be bought
        public List<Car>CarList { get; set; }

        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        //ACTIONS

        public decimal Checkout()
        {
            //Initial cost of the Checkout
            decimal totalCost = 0;

            foreach (var c in ShoppingList)
            {
                totalCost = totalCost + c.Price;
            }

            //Empties all that was in the Shopping List (after the Checkout )
            ShoppingList.Clear();


            return totalCost;
        }

    }
      
}
