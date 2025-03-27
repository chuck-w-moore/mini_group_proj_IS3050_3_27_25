/*
 
 
 
 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_group_proj_IS3050_3_27_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kush drink = new Kush();  //Declare and instantiate the class

            drink.Gatorade_flavor = "lemon lime"; //Invoke the setter
            Console.WriteLine("The flavor of my gatorade is " + drink.Gatorade_flavor); // getter
        }
    }
}
