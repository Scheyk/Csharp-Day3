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
            //Cornel();
            //Samira();
            Kathi();
        }

        static void Cornel()
        {
            CornelTask tasks = new Cornel.CornelTask();
           
        }

        static void Samira()
        {
            SamiraTask tasks = new Samira.SamiraTask();
        }

        static void Kathi()
        {
            KathiTasks tasks = new Kathi.KathiTasks();

            //tasks.TaskOne();
            //tasks.TaskTwo();
            //tasks.TaskThree();

            Greeting newClass = new Kathi.Greeting();
            //newClass.sayHello();
            newClass.theSwitch();

            NewClass theTry = new Kathi.NewClass();
            //theTry.Main();
        }
    }
}
