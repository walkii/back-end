using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndChalenge
{
    class Program
    {
        private enum function { User, Objectif, Task, View, Edit, Quit };
        static void Main(string[] args)
        {
            Information();
            string readInput = "";

            while (readInput != "quit")
            {
                readInput = Console.ReadLine();
                function func = (function)System.Enum.Parse(typeof(function), readInput);
                switch (func)
                {
                    case function.User:
                        UserFunction();
                        break;
                    case function.Quit:
                        quitFunction();
                        break;
                    default:
                        defaultFunction();
                        break;
                }
            }
        }

        static void Information()
        {
            Console.WriteLine("Welcome");
        }

        static void UserFunction()
        {

        }

        static void quitFunction()
        {
            Console.WriteLine("Thanks, press enter to quit.");
        }

        static void defaultFunction()
        {
            Console.WriteLine("Bad request, try again.");
        }
    }
}
