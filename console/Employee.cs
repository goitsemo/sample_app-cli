using System;

namespace ConsoleApp
{
    // cannot be instantiated
    abstract class Employee
    {
        // can override method
        public virtual void Login()
        {
            Console.WriteLine("Employee login");
        }

        // must override method
        public abstract void Hire();


        // private member variables
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;


        // member variable public properties:
        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
        
        public string FirtsName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}