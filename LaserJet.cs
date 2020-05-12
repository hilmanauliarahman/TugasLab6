using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TugasLab6
{
    public class LaserJet : IPrinterWindows
    {

        public void Show()
        {
            Console.Write("Laserjet display dimension : ");
            string nomorPrinter = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("LaserJet printer printing ....");
        }
    }
}
