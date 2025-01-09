using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.Models
{
    public class Airplane : Vehicle
    {
        public int NumberOfPassengers { get; set; }
        public int NumberOfEngines { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Airplane engine started");
        }

        public override void Drive()
        {
            Console.WriteLine("Airplane is flying");
        }

        public override void Stop()
        {
            Console.WriteLine("Airplane stopped");
        }

        public void TakeOff()
        {
            Console.WriteLine("Airplane took off");
        }

        public void Land()
        {
            Console.WriteLine("Airplane landed");
        }
    }
}
