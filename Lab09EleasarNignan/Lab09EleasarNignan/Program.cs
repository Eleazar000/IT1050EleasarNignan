using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09EleasarNignan
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath GetResult1 = new MyMath();
            MyMath GetResult2 = new MyMath();
            MyMath GetResult3 = new MyMath();
            MyMath GetResult4 = new MyMath();

            

            GetResult1.Multiply(100, 2);
            GetResult2.Divide(100, 2);
            GetResult3.Substract(100, 2);
            GetResult4.Add(100, 2);

            Console.WriteLine("The result of multiplication is "+GetResult1.result);
            Console.WriteLine("The result of division is " + GetResult2.result);
            Console.WriteLine("The result of substraction is " + GetResult3.result);
            Console.WriteLine("The result of addition is " + GetResult4.result);
        }
    }
}
