using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TugasLab6
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.Write("Canon display dimension : ");
            string nomorPrinter = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing ....");
        }
    }
}
