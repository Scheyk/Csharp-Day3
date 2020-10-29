using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Csharp_Day3.Samira
{
    class SamiraTask
    {
        public void FirstTask()
        {
            //Create a string with the value “5920”. Now convert it into char and print the result in the console window. 
            try { 
            string num = "5920";
            char myChar = Convert.ToChar(num);
            Console.WriteLine(myChar);}
            catch(Exception output)
            {
                Console.WriteLine(output.Message);

            }
        }


        public string SecondTask(string Name, string Ocup)
        {

          return "Hello, my name is" + Name +".I am a " + Ocup;
            
        }



        public void ThirdTask( string myName, String myLast, double year)
        {
            // Hello, my name is < first name + last name >.I was born in < year of birth>, so I am < currentYear - year of birth> years old.”.
            double age = 2020 - year;
            Console.WriteLine(" Hello, my name is " + myName +" " + myLast + " I was born in " + year + " so I am " + age + " years old.");

        }




























    }
}
