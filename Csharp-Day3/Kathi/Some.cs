using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Kathi
{
    class Some
    {
        
        enum ChooseDay
        {
            Morning = 1,
            Afternoon,
            Evening
        }

        public void Main()
        {            
            Console.WriteLine("Choose a number.  1 - for Morning, 2 - for Afternoon and 3 - for Evening");
            var choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter your name");
            string name = Console.ReadLine();

            var TheChoose = (ChooseDay)choose;

            Console.WriteLine($"Good {TheChoose} {name}");
        }
        
    }
}
