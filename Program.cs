﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Program{
    class Program{
        public static void Main(string[] args){
            double pi = 3.14;
            int int_pi = Convert.ToInt32(pi);
            string str_pi = Convert.ToString(pi);
            Console.WriteLine("PI as an integer is: "+ int_pi + int_pi.GetType());
            Console.WriteLine("Pi as a string is: "+str_pi.GetType());
        }
    }
}
