// See https://aka.ms/new-console-template for more information
using CarClassLibrary;

//MAIN
Console.WriteLine("Welcome to the Car Store. First you need to input the cars to the car inventory, Only then you may add some cars to your shopping list \n After that you can access the checkout that will give you the total value of your shopping list ");

//Initializes the store 
Store s = new Store();

/*
// 04. Option Loop 
int option = chooseOption();
while (option != 0)
{
    Console.WriteLine("You chose - " + option);
    //Stops the infinite loop as rewritten
    option = chooseOption();
}
*/

//05.Option Loop with Actions
int option = chooseOption();
while (option != 0)
{
    Console.WriteLine("You chose - " + option + "\n");

    switch (option)
    {
        //INVENTORY ADDING
        //01. Parameters to Pass
        //02.Input from the user to Fill those Parameters
        //03.Pass the parameters to the Class within its Constructor
        //04.Add to the Inventory Lists (to store)
        //05.(Optional)Prints the inventory
        case 1:
            Console.WriteLine("You choose to add a new car to Inventory.\n");

            //Parameters to pass
            String carMake = "";
            String carModel = "";
            Decimal carPrice = 0;

            //Asks the user for its input in the previous parameters
            Console.WriteLine("What is the car Manufacturer? Ford,GM,Nissan,etc");
            carMake = Console.ReadLine();
            Console.WriteLine("What is the car Model? Corvette,Pegasus,Ranger");
            carModel = Console.ReadLine();
            Console.WriteLine("What is the car Price?");
            carPrice = int.Parse(Console.ReadLine());

            // Inputs it as an instance of the Car Class and pass its parameter to the constructor
            Car newCarToInventory = new Car(carMake,carModel,carPrice);

            //Adds to List Constructor on the Store Class
            s.CarList.Add(newCarToInventory);

            //Shows the inventory
            printInventory(s);
            break;

        //CART ADDING
        //01.Input the user chosen to a Variable
        case 2:
            Console.WriteLine("You choose to add a car to your Cart. \n Below you have the current Inventory.\n");
            printInventory(s);
            Console.WriteLine("Which item would you like to buy? Choose by the number\n");
            //Input the user chosen car
            int carChosen = int.Parse(Console.ReadLine());

            //Adds the CarList car onto the ShoppingList by the previous order of input of the user
            s.ShoppingList.Add(s.CarList[carChosen]);

            printShoppingCart(s);
            break;

        case 3:
            Console.WriteLine("\n You chose to check out your Cart as follows:\n");
            printShoppingCart(s);
            Console.WriteLine("The total cost of your items is: " + s.Checkout());
            break;

        default:
            break;

    }

    //Stops the infinite loop as rewritten
    option = chooseOption();
}





//FUNCTIONS
static int chooseOption()
{
    //int is initialized to 0 so you can get out of the loop if next 0 input
    int choice = 0;
    Console.WriteLine("\n 0. Exit \n 1. Add new Car to Inventory \n 2. Add Car to Cart \n 3. Checkout ");

    //translates the input from the user
    choice = int.Parse(Console.ReadLine());
    return choice;
}
void printInventory(Store s)
{

    for (int i = 0;i<s.CarList.Count;i++)
    {
        //option A to print the Inventory (the other is the ToString )
        //Console.WriteLine("Car: " + item.Make + "" + item.Model + "" + item.Price);
        Console.WriteLine("Car Nº: " + i +" " +  s.CarList[i]);
    }
}

void printShoppingCart(Store s)
{
    Console.WriteLine("Here are the items you selected for the Cart\n");
    for (int i = 0; i < s.ShoppingList.Count; i++)
    {
        //option A to print the Inventory (the other is the ToString )
        //Console.WriteLine("Car: " + item.Make + "" + item.Model + "" + item.Price);
        Console.WriteLine("Car Nº: " + i + " " + s.ShoppingList[i]);
    }


}
/*OLD INVENTORY PRINT
void printInventory(Store s)
{
    
    foreach (var item in s.CarList)
    {
        //option A to print the Inventory (the other is the ToString )
        //Console.WriteLine("Car: " + item.Make + "" + item.Model + "" + item.Price);
        Console.WriteLine("Car: " + item);
    }
}
*/

