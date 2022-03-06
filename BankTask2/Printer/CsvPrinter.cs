using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace BankTask2
{
    class CsvPrinter : IPrinter
    {
        public string Path { get; set; }

        public CsvPrinter(string path)
        {
            Path = path;
        }

        public void PrintData(List<DataToPrint> data)
        {
            string path = @"C:\Users\"+Environment.UserName + @"\Documents\Результирующий Документ.csv";
            
            using (var writer = new StreamWriter(path, false, Encoding.GetEncoding("windows-1251")))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("ru-RU"))
                {
                    HasHeaderRecord = false,
                    Delimiter = ";"
                };
               
                using(var csv = new CsvWriter(writer, csvConfig))
                {
                    csv.WriteRecords(data);
                }

            }
        }
    }
}
       



