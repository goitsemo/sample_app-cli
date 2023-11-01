using System;

namespace ConsoleApp
{
    class Manager : Employee
    {
        // chose to override
        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }

        
        // have to override
        public override void Hire()
        {
            Console.WriteLine("Hire Someone");
        }
    }
}