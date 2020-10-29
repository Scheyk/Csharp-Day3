using Csharp_Day3.Cornel;
using Csharp_Day3.Kathi;
using Csharp_Day3.Samira;
using System;

namespace Csharp_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cornel();
            //Samira();
            //Kathi();
        }

        static void Cornel()
        {
            var date = DateTime.Now;
            CornelTask tasks = new Cornel.CornelTask();
            //tasks.Exercise_01();
            //tasks.Exercise_02("Cornel", "Programmer");
            //tasks.Exercise_03("Cornel", "Gurin", 1988);
            //tasks.Exercise_04();
            Greeting task2 = new Cornel.Greeting();
            //task2.method3("Cornel", date.Hour);

            //Cars carnumber_01 = new Cornel.Cars("Bmw","Green","Germany",250,2000,true,true,false);
            //Cars carnumber_02 = new Cornel.Cars("Toyota", "Blue", "Japan", 220, 2200, false, true, false);
            //Cars carnumber_03 = new Cornel.Cars("Ford", "Black", "Usa", 320, 3000, true, true, true);

            //carnumber_03.displayProduct(carnumber_03.name, carnumber_03.color, carnumber_03.countryMade, carnumber_03.horsepower, carnumber_03.engine, carnumber_03.tractionControl, carnumber_03.fourwd, carnumber_03.automaticGearbox);

            ClassII task_03 = new Cornel.ClassII();
            task_03.method3("Cornel", 3);

        }

        static void Samira()

        {
            NewClass myClass = new Samira.NewClass();
            //myClass.One();
            //myClass.Two("samira");
            //myClass.Three("Samira", NewClass.TimeOfDay.Morning);
            //myClass.Three("Samira", NewClass.TimeOfDay.Afternoon);
            //myClass.Three("Samira", NewClass.TimeOfDay.Evening);


            SamiraTask tasks = new Samira.SamiraTask();
            //tasks.FirstTask();
           // Console.WriteLine(tasks.SecondTask("samira", "EventManager"));
            //tasks.SecondTask("samira","EventManager");
            //tasks.ThirdTask("Samira","Khadem", 1983);

        }

        static void Kathi()
        {
            KathiTasks tasks = new Kathi.KathiTasks();
        }
    }
}
