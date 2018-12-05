using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW11EleasarN
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] students = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
             Console.WriteLine(students[1]);
             Console.WriteLine(students[students.Length - 1]);
             


            string[] months = new string[12];

            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "Ocotber";
            months[10] = "November";
            months[11] = "December";

            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + months[i]);
            }
            



            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }
            */

            int[] randomNum = new int[1000];
            Random random = new Random();

            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = random.Next(0, 1000);
            }

            foreach (int r in randomNum)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
