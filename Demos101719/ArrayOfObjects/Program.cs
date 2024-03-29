﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of polymorphism
            int i = 123;
            double d = 456.789;
            string s = "some string";
            MyClass mc = new MyClass();

            //establish an object array with size and define
            Object[] myArray = new object[4];
            myArray[0] = i;
            myArray[1] = d;
            myArray[2] = s;
            myArray[3] = mc;

            // example of polymorphism
            foreach (object o in myArray)
            {
                Console.WriteLine(o.GetType());
                Console.WriteLine(o.ToString());
                Console.WriteLine();
            }
        }
    }
}
