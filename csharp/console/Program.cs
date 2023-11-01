using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("kitchen", "Sony", "DM1000");
            // myMachine.Location = "kitchen";
            // myMachine.Model = "DM1000";
            // myMachine._make = "Sony";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappaccino();

            // cannot instantiate abstract class Employee
            // inherit, Impliment from sublclass
            // Employee newEmp = New Employee();
            // NewEmp.Login();

            Manager myManager = new Manager();
            myManager.Login();
            myManager.Hire();

        }
    }
}
