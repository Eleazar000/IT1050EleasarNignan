using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab6EleasarNignan
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Compare and contrast the if single-selection statement and the while repetition statement.  How are these two statements similar?  How are they different? (2 Points).
            // If statement is a selection statement and the while statement is a repetition statement.With the IF statement the code is run once but with the While statement the code is run several times until the condition is met.They are both conditional statements and they accept a Boolean value as a parameter.


            // 2.Write an if statement that displays “SLOW NOW” 

            /* int speedLimit;
             int speed;

             speedLimit = 35;
             speed = 42;

             if (speed > speedLimit)
             {
                 Console.WriteLine("SLOW NOW");
             }
             
            // 3.Write a program that declares and assigns a value to a Boolean variable called isTrue.

            bool isTrue;

            isTrue = false;
            if (isTrue == true)
           {
               Console.WriteLine("It is True!");
           }
           else
           {
               Console.WriteLine("It is False!");
           }
           
            // 4. Write a program that converts a Fahrenheit temperature to Celsius
          
           double Far;
           double Cel;

           Console.WriteLine("Enter the temperature in Farhenheit");
            Far=Convert.ToDouble(Console.ReadLine());
           if (Far < 40)
           {
               Console.WriteLine("It is cold");
           }
           else if (Far>90)
           {
               Console.WriteLine("It is hot");
           }
           Cel = (Far - 32d) * 5d / 9d;
           Console.WriteLine("The result in Celsius is " + Cel);
             
            // 5. Write a while loop that outputs values 1-10.  Increment by 1 
           int i;
           i = 1;
           while(i<=10)
           {
               Console.WriteLine(i);
               i = i + 1;
           }
            
            // 6.	Write a while loop that outputs values 60 to 20.  Decrement by 1 
            int i;
            i = 60;
            while (i >= 20)
           {
               Console.WriteLine(i);
               i = i - 1;


           }
           */
            // 7. Create a while that outputs values 10-20 
            int i;
            i = 10;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
    }
}
