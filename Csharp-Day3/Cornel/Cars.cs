using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Day3.Cornel
{
    class Cars
    {
        public string name;
        public string color;
        public string countryMade;
        public float horsepower;
        public float engine;

        public Boolean tractionControl;
        public Boolean fourwd;
        public Boolean automaticGearbox;

        public Cars(string name,string color,string countryMade,float horsepower,float engine,Boolean tractionControl,Boolean fourwd,Boolean automaticGearbox)
        {
            this.name = name;
            this.color = color;
            this.countryMade = countryMade;
            this.horsepower = horsepower;
            this.engine = engine;
            this.tractionControl = tractionControl;
            this.fourwd = fourwd;
            this.automaticGearbox = automaticGearbox;
        }

        public void displayProduct(string a,string b,string c,float d,float e,Boolean g,Boolean h,Boolean m)
        {
            Console.WriteLine(" name: "+a+" color: "+b+" contryMade: "+c+" horsepower: "+ d + " engine " + e + " tractionControl: "+ g + " fourwd: " + h + " automaticGearbox: " + m);
        }
    }
}
