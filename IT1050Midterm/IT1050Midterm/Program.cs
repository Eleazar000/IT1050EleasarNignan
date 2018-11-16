using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            

           // 1.	Create an infinite while loop.


           bool KeepLooking = true;
           do
           {
               Console.WriteLine(KeepLooking);

           }
           while (KeepLooking ==true);


          /* // 2.	Write a while loop to prints 2 through 128 in brackets, each on a new line

           int i = 2;
           while (i<248)
           {
               Console.WriteLine("[{0}]",i);
               i = i * 2;
           }



           // 3.	Write a for loop that prints 49 through 1 separated by a comma

           for (int i = 49; i > 1; --i)
           {

               Console.Write("{0},",i);

           }



           //4.	Write a while loop that prints all odd numbers 1 through 21

           int i;
           for ( i = 1; i <= 21; i=i+2)
           {
               Console.Write("{0}   ",i);

           }




           //  5.	Implement the following code using a while loop.

           int n = 8;
           int i = 10; // initialize
           do
           {
               Console.Write("*");
               i++; // update!
           } while (i < n); // test condition

           int n = 8;
           int i = 10;

           while (i<n)
           {
               Console.Write("*");
               i = i + 1;
           }
           // the difference between a while loop and a do while loop is that the do while loop will execute the code at least one time even if the condition is not met
           // however, the while loop will verify the condition before to execute the code.





           // 6.	Use and and or (&& and ||) to write an if statement that outputs “Let’s go outside!”

           bool icyRain = false;
           bool tornadoWarning = false;

           if (!(icyRain && tornadoWarning))
           {
               Console.WriteLine("Let's go outside 1");
           }

           if (!(icyRain || tornadoWarning))
           {
               Console.WriteLine("Let's go outside");
           }*/



            // 7.	Extra Credit: Use nested loops to print the following to the console:
            int numberoflayer = 5, Space, Number;

            for (int i = 5; i >= 1; i--) // Total number of layer for pramid  
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value  
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
                    Console.Write(Number);
                Console.WriteLine();
            }
        }
    }
}
