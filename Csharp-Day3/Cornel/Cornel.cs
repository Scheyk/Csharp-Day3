using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Cornel
{
    class CornelTask
    {


       



        public void Exercise_01()
        {
            try
            {
                string name = "Cornel";
                char v = Convert.ToChar(name);
                
                Console.WriteLine(v);
            }

            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }

        public void Exercise_02(string name,string occupation)
        {

            Console.WriteLine($"Hallo my name is {name} and i am {occupation}.");


        }

        public void Exercise_03(string firstName,string lastName,int birthYear)
        {

            int age = 2020 - birthYear;

            Console.WriteLine($"Hello,my name is {firstName} {lastName}.I was born in {birthYear},so i am {age} years old.");

        }

        public void Exercise_04()
        {

       
            var date = DateTime.Now;
            Console.WriteLine(date.Hour);
            
           // Console.WriteLine(WeekDays.Monday);
           // Console.WriteLine((int)WeekDays.Tuesday);
           // Console.WriteLine((WeekDays)1);
           
        }



    }
}
