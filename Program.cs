﻿using System;

namespace inheritTwoClass
{
    class Mobile
    {
        public string brand = "Android";
        public void Config() 
        {
            Console.WriteLine("Hello! welcome to class..");
        }
    }
    class Samsung : Mobile
    {
        public string modelName = "Samsung J5";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Samsung mobile = new Samsung();
            mobile.Config();
            Console.WriteLine(mobile.brand + " " + mobile.modelName);
        }
    }
}
