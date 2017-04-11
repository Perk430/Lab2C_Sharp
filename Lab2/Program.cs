using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input from user
            string name;
            int num;

            Console.WriteLine("Hello!  Please tell me your name!");

            name = (Console.ReadLine());

            Console.WriteLine("Hi, " + name + ".  Enter an integer between 1 and 100");

            // Validating input is actually an integer.

            string numString = Console.ReadLine();
            if (!int.TryParse(numString, out num)) 
            {
                Console.WriteLine("Sorry, " + name + ", that is NOT an integer.  Please enter an INTEGER between 1 and 100.");
            }

            num = int.Parse(Console.ReadLine());

            // Determining if input is within the required range of 1 and 100

            if ((num < 1 ) || (num > 100))
                    {
                Console.WriteLine("Sorry, " + name + ", please enter an integer within the desired range: 1 to 100.");
            return;
            }

            // Determining whether input is ODD or Even
            if (num % 2 == 1)
            {
                Console.WriteLine(name + ", " + num + " is ODD");

            }
            else if (num % 2 == 0 && (2 <= num) && (num <= 25))

            {
                Console.WriteLine(name + ", " + num + " is Even and less than 25");
            }

            else if (num % 2 == 0 && (26 <= num) && (num < 60))
            {
                Console.WriteLine(name +  ", " + num + " is Even");
            }
            else if (num % 2 == 0 && (num > 60))

            {
                Console.WriteLine(num + " Even");
            }
            else if (num %  2 ==1 && (num >60))

            {
                Console.WriteLine(num + " Odd");
            }
            
        }
    }
}
