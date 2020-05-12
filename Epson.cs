using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TugasLab6
{
    public class Epson : IPrinterWindows
    {

        public void Show()
        {
            Console.Write("Epson display dimension : ");
            string nomorPrinter = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("Epson printer printing ....");
        }
    }
}
