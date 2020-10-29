using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Cornel
{

    enum WeekHours
    {
        Morning = 6,
        Afternoon = 11,
        Evening = 18

    }

    
    class Greeting
    {

        public void method1()
        {

            Console.WriteLine("Hello");
        }
        public void method2(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public void method3(string name,int tim)

        {
            switch(tim)
            {
                case int i when i > (int)WeekHours.Morning && i < (int)WeekHours.Afternoon:
                    Console.WriteLine("it is Morning!");
                    break;

                case int i when i > (int)WeekHours.Afternoon && i < (int)WeekHours.Evening:
                    Console.WriteLine("it is Afternoon!");
                    break;

                case int i when i > (int)WeekHours.Evening && i < 24:
                    Console.WriteLine("it is Evening");
                    break;

                default:
                   throw new Exception ("Go to sleep");
            }
        }
    }
}
