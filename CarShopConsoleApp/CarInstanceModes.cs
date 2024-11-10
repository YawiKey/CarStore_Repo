using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    public class CarInstanceModes
    {
        // OLD MAIN 
        static void Main(String[] args)
        {

       
            //01. GENERIC INSTANCE
            Car car01 = new Car();

            // Tha call is made by referencing the instante object and then the function
            Console.WriteLine("Car stored is" + car01.Make + car01.Model + car01.Price);

            //02. PARAMETRIZED INSTANCE
            //The instance of the object is pre-made with the parameters
            Car car02 = new Car(" Artemis ", " Peugeot ", 1200);
            //The parameters substitute the standard in the constructor
            Console.WriteLine("Car stored is" + car02.Make + car02.Model + car02.Price);

            Car car03 = new Car(" Pegasus ", " BMW ", 4500);
            //03. STORE OPEN INIT.
            Store s = new Store();


            s.ShoppingList.Add(car02);
            s.ShoppingList.Add(car03);

            //04. Checkout Call (the cars pass the price with the previous initializacion)
            decimal total = s.Checkout();


            Console.WriteLine("Store value is: " + total);

            Console.ReadLine();

        }
    }
}
