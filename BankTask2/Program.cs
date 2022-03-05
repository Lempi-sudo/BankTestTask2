using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using ClosedXML.Excel;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;


namespace BankTask2
{
    class Program
    {


        public class ProgrammingLanguage
        {
            public string FullName { get; set; }
            public string  Age { get; set; }
        }


        static void Main(string[] args)
        {

            var pathCsvFile = "D:/Code/C#/BankTask2/BankTask2/Список_имен.csv";

            var rawCsv =  System.IO.File.ReadAllText(pathCsvFile, Encoding.GetEncoding(1251));

            string s = rawCsv;
            Regex regex = new Regex(@"[А-Яа-я\s]*;\d*");
            MatchCollection matches = regex.Matches(s);

           

            foreach (Match match in matches)
                Console.WriteLine(match.Value);

            List<string> rowName = new List<string>();
            List<string> rowAge = new List<string>();

            for (int i = 0; i<matches.Count; i++)
            {
                rowName.Add(matches[i].Value.Split(';').First());
                rowAge.Add(matches[i].Value.Split(';').Last());
            }







            //var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            //{
            //    Delimiter = ";",
           


            //};

            //using (StreamReader streamReader = new StreamReader(pathCsvFile))
            //{
            //    using (CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture ))
            //    {
               
                    
                    
            //        // получаем строки
            //        IEnumerable programmingLanguages =
            //            csvReader.GetRecords<ProgrammingLanguage>().ToList();
            //    }

            //}
        }
    }
}

