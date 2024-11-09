// See https://aka.ms/new-console-template for more information
using CarClassLibrary;


Console.WriteLine("Hello, World!");


//01. GENERIC INSTANCE
Car car01 = new Car();

// Tha call is made by referencing the instante object and then the function
Console.WriteLine("Car stored is" + car01.Make + car01.Model + car01.Price);

//02. PARAMETRIZED INSTANCE
//The instance of the object is pre-made with the parameters
Car car02 = new Car(" Artemis ", " Peugeot ", 1200);
//The parameters substitute the standard in the constructor
Console.WriteLine("Car stored is" + car02.Make + car02.Model + car02.Price);

Console.ReadLine();
