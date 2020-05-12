using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab6
{
    public class Printer
    {
        public string nomorPrinter { get; set; }
        public void Show()
        {
            Console.Write("Laserjet display dimension : ");
            string nomorPrinter = Console.ReadLine();
        }
        public void Startprint()
        {
            Console.WriteLine("LaserJet printer printing ....");
        }
    }
}
