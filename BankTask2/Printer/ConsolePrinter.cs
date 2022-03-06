using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask2
{
    class ConsolePrinter : IPrinter
    {
        public void PrintData(List<DataToPrint> data)
        {
            Console.WriteLine("========= Tables =========\n");
            Console.WriteLine("        ФИО           Лет до пенсии\n");
            foreach (DataToPrint tmp in data )
            {
                Console.WriteLine($"\t{tmp.Name} \t\t{tmp.YearsUntilPension}");
            }
            
        }
    }
}
