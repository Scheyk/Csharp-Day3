using System;
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
            Morning = 1,
            Afternoon,
            Evening
        }

         
        public void theSwitch()
        {
            //timeOfday afternoon = timeOfday.Afternoon;
            //timeOfday morning = timeOfday.Morning;
            //timeOfday evening = timeOfday.Evening;

            Console.WriteLine("Choose a number to get your greetings. (1 = Morning, 2 = Afternoon or 3 = Evening)");
            var choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("now, give me yor name to get the personal greeting");
            string name = Console.ReadLine();

            var enumVal = (timeOfday)choose;

            switch (enumVal)
            {
                case timeOfday.Afternoon:
                    Console.WriteLine($"Hello {name}. The {timeOfday.Afternoon} is here. so, time to sleep");
                    break;
                case timeOfday.Morning:
                    Console.WriteLine($"Hello {name}. The {timeOfday.Morning} is perfect for sport!");
                    break;
                case timeOfday.Evening:
                    Console.WriteLine($"Hello {name}. The {timeOfday.Evening} is good to eat some staks! numnumnum");
                    break;
                default:
                    Console.WriteLine($"try it again. maybe you have a typo? ");
                    break;
            }
        }
        

        

    }
}
