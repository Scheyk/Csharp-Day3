using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Kathi
{
    class KathiTasks
    {
        public void TaskOne()
        {
            //string toConvert = "5920";
            //char[] getString = toConvert.ToCharArray();

            try
            {
                string toConvert = "5920";
                char[] getString = toConvert.ToCharArray();

                foreach (char toPrint in getString)
                    Console.Write(toPrint);                

            } catch (Exception output)
            {
                Console.WriteLine(output);
            }
        }

        public void TaskTwo()
        {
            Console.WriteLine("The methode with two parameters \n");
            Console.WriteLine("First parameter is the name. So, please enter your name :)");
            string name = Console.ReadLine();
            Console.WriteLine("Thanks. Now, the second parameter is your occupation. Please, enter it :)");
            string occupation = Console.ReadLine();
            Console.WriteLine("Thanks!. \n Now, the result is- see below ;)");
            Console.WriteLine($"Hello, my name is {name} . I am a {occupation}.");
        }

        public void TaskThree()
        {
            Console.WriteLine("Calculate the age. Are you honest? \n");
            Console.WriteLine("At first, i need your first name.");
            string fName = Console.ReadLine();
            Console.WriteLine("Thanks! \n Now, your last name.");
            string lName = Console.ReadLine();
            Console.WriteLine("Thanks! \n Your year of birth. - honest??");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now, the day of your birth.");
            var day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and now, the month of your birth.");
            var month = Convert.ToInt32(Console.ReadLine());

            int currentMonth = DateTime.Today.Month;
            int currentDay = DateTime.Today.Day;
            int currentYear = DateTime.Today.Year;

            int age = currentYear - year;

            if (currentMonth < month || currentMonth == month && currentDay < day)
                age--;
            
            Console.WriteLine($"Hello, my name is {fName} {lName}.I was born in {year}, so I am {age} years old");
        }
    }
}
