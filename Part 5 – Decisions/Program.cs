using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer;
            int age;


            Console.WriteLine("Please enter your age.");
            age = Convert.ToInt32(Console.ReadLine());



            if (age >= 18)

                Console.WriteLine("You are an adult.");


            else if (age < 18)

                Console.WriteLine("you are a Teen.");


            else if (age <= 5)
                Console.WriteLine("You are a Toddler");

            else if (age <= 10)

                Console.WriteLine("you are a Child");

            else if (age > 5)

                Console.WriteLine("you are a preteen");




            Console.ReadLine();

        }
    }
}
