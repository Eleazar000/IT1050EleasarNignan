﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        private int Speed;
        private string Make;
        private string Model;
        private int Year;

        public Car(string make, string model, int year,int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Speed = speed;
            this.Year = year;
        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public int SpeedUp()
        {


            { this.Speed++; }

            return 0;
        }

        public int SlowDown()
        {
            if(Speed>0)

            { this.Speed--; }

            return 0;
        }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }



    }
}
