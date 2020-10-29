using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Cornel
{
    class ClassII
    {



        enum WeekHours
        {
            Morning = 1,
            Afternoon = 2,
            Evening = 3

        }
        public void method3(String name,int i)
        {

            Console.WriteLine((WeekHours)i+ " " + name);
        }
    }
}
