using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Samira
{
    class NewClass
    {
        public void One()
        {
            Console.WriteLine("Hi I am the new class you created");
        }

        public void Two(string myName)
        {
            Console.WriteLine("Hi I am the new class " + myName + " created");
        }

         public enum TimeOfDay { Morning, Afternoon, Evening };
        public void Three(string name, TimeOfDay dayTime)
        {
            //Console.WriteLine(TimeOfDay.Morning);
           // Console.WriteLine("Hallo " + name +", good " + TimeOfDay.Morning);
            switch(dayTime) {
                case TimeOfDay.Morning:
                    Console.WriteLine("Hallo " + name + ", good " + TimeOfDay.Morning);
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine("Hallo " + name + ", good " + TimeOfDay.Afternoon);
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Hallo " + name + ", good " + TimeOfDay.Evening);
                    break;

            }
                

        }

    }
}
