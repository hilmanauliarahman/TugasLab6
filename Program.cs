using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TugasLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Canon printer = new Canon();
            IPrinterWindows doprint;
            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1-3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            

            if (nomorPrinter == 1)
            {
                doprint = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                doprint = new Canon();
            }
            else if (nomorPrinter == 3)
            {
                doprint = new LaserJet();
            }
            else {
                Console.WriteLine("\nInput Salah\n");
                return;
            }
            doprint.Show();
            doprint.Print();

            Console.ReadKey();
        }
    }
}
