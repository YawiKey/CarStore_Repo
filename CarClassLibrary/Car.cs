namespace CarClassLibrary
{
    public class Car
    {
        //Propierties
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        // Default Constructor
        public Car()
        {
            this.Make = " - ";
            this.Model = " - ";
            this.Price = 0.00M;


        }

        //Parametrized Constructor

        public Car(string a, string b, decimal c)
        {

            this.Make = a;
            this.Model = b;
            this.Price = c;
        }

        //Override - Full Car class string
        override public string ToString()
        {
            return "Make: " + Make + ",Model: " + Model + ",Price: $" + Price;
        }
    }
}
