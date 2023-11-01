using System;

namespace ConsoleApp
{
    class DrinksMachine
    {
        
        // class constructor
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        // declaring private member variables
        private string _location;

        // member variable properties
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // declare public methods
        public void MakeCappaccino()
        {
            // create method implementation
            Console.WriteLine("Capaccino is made.");
        }
        public void MakeExpresso()
        {
            // method logic:
        }
    }
}
