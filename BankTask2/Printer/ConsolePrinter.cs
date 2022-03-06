using System;
using System.Collections.Generic;

namespace BankTask2
{
    class ConsolePrinter : IPrinter
    {
        public void PrintData(List<DataToPrint> data)
        {
            var maxLenName = 0;
            foreach(DataToPrint tmp in data)
            {
                if (tmp.Name.Length > maxLenName) maxLenName = tmp.Name.Length;
            }

            int standartSpace = 4;

            Console.WriteLine("=========== TABLE EMPLOYEE ====================================\n");
            Console.WriteLine("        ФИО                Лет до пенсии\n");

           
            foreach (DataToPrint tmp in data )
            {
                string str = "";
                int raznica = maxLenName - tmp.Name.Length;
                string spaceBetweenColumns = str.PadLeft(standartSpace + raznica);
                Console.WriteLine($"\t{tmp.Name} {spaceBetweenColumns}  {tmp.YearsUntilPension}");
            }
            
        }
    }
}



