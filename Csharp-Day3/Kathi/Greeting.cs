﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Kathi
{
    class Greeting
    {
        public void sayHello()
        {
            Console.WriteLine("Before we start, please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("what do you want to tell the world?");
            string tell = Console.ReadLine();
            Console.WriteLine($"Hy {name} ! \n Your message to the world is: '{tell}'");
        }

        public void someGreeting()
        {
            Console.WriteLine("Time for greetings! \n Please, enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hy {name} ! \n I greet you warmly :)");
        }

        
        enum timeOfday
        {
            Morning,
            Afternoon,
            Evening
        }
        
        

    }
}