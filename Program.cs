using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInput();
        }
        static public void ReadInput()
        {
            int[] values = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the triangle side length number " + (i+1) + ": ");
                if (!int.TryParse(Console.ReadLine(), out values[i]))
                {
                    Console.WriteLine("You wrote a character that is not a number. Please press enter to try again!");
                    Console.ReadLine();
                    ReadInput();
                    return;
                }
                else if (values[i] <= 0)
                {
                    Console.WriteLine("Triangle can not have a side of length 0 or less. Please press enter to try again!");
                    Console.ReadLine();
                    ReadInput();
                    return;
                }
                    
            }
           
            CheckInput(values);
        }
        static public void CheckInput(int[] values)
        {
            if ( (values[0] + values[1]) <= values[2]
                || (values[1] + values[2]) <= values[0]
                || (values[0] + values[2]) <= values[1])
            {
                Console.WriteLine("A triangle can not be made with your given sides");
            }

            else if (values[0] == values[1] && values[1] == values[2])
            {
                Console.WriteLine("That is an equilateral triangle");
            }

            else if (((values[0] == values[1] && values[0] != values[2])
                || (values[1] == values[2] && values[1] != values[0])
                || (values[0] == values[2] && values[0] != values[1])))
            {
                Console.WriteLine("That is an isosceles triangle");
            }
            
            else
            {
                Console.WriteLine("That is an scalene triangle");
            }
            Console.WriteLine("Enter Y to try again or any key to close");
            string input = Console.ReadLine();
            if (String.Equals(input, "y", StringComparison.CurrentCultureIgnoreCase))
            {
                ReadInput();
                return;
            }
            
        }
    }
}
