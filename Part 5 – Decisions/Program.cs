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
            Random generator = new Random();


            string answer;
            int age;
            int catagory;
            int Random;
            int numerator;
            string answer2;
            Console.Write("How old are you?");
            answer = Console.ReadLine();

            { 

            if (int.TryParse(answer, out age)) 
            
               


                if (age >= 18)

                    Console.WriteLine("Adult");

                else if (age > 12)

                    Console.WriteLine("Teen");

                else if (age <= 5)

                    Console.WriteLine("Toddler");

                else if (age <= 10)

                    Console.WriteLine("Child");

                else if (age <= 12)

                    Console.WriteLine("Preteen");


             else

                Console.WriteLine("Error");

            Console.WriteLine("________________________________________________________________");

                Console.WriteLine("Pick a number 1-5 to get that catagory hurricane and learn about it.");
                answer = Console.ReadLine();


                int.TryParse(answer, out catagory);

                switch (catagory)

                {
                    case 1:
                        Console.WriteLine("Catagory 1 hurricane. It goes 84 mph/72 kts/135 kmph.");
                        break;
                    case 2:
                        Console.WriteLine("Catagory 2 hurricane. It goes 98 mph/85 kts/156 kmph.");
                        break;
                    case 3:
                        Console.WriteLine("Catagory 3 hurricane. It goes 123 mph/106 kts/197 kmph.");
                        break;
                    case 4:
                        Console.WriteLine("Catagory 4 hurricane. It goes 154 mph/133 kts/247 kmph.");
                        break;
                    case 5:
                        Console.WriteLine("Catagory 5 hurricane. It goes 437 mph/379 kts/702 kmph.");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("______________________________________________________________________");

                Random = generator.Next(2, 6);

                Console.WriteLine($"Please enter a number greater than {Random} to see if it is divisable.");

                answer2 = Console.ReadLine();

                if(int.TryParse(answer2, out numerator));

                    if (numerator % Random ==0)

                    Console.WriteLine($"It is divisable.");
            
                else if (numerator < Random)
            
                Console.WriteLine($"Number is smaller than random number so not divisable.");
            
            else if (numerator % Random != 0)
            
                Console.WriteLine($"Not divisable.");


            
            
            else
            
                Console.WriteLine("Error");









                Console.ReadLine();

            }
        }
    }
}
