﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_One.Rectangle
{
    class Rectangle
    {
        // rectangle variables
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double getArea()
        {
            return length*width;
        }

        public void display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", getArea());
        }



    }
}
