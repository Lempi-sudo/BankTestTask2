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


        public class Person
        {
            public string FullName { get; set; }
            public string  Age { get; set; }

            public  Person(string name,  string age)
            {
                FullName = name;
                Age = age;
            }
        }


        static void Main(string[] args)
        {

            var pathCsvFile = "D:/Code/C#/BankTask2/BankTask2/Список_имен.csv";

            var rawCsv =  System.IO.File.ReadAllText(pathCsvFile, Encoding.GetEncoding(1251));

           
            Regex regex = new Regex(@"[А-Яа-яёЁ\s]+");
            MatchCollection matchesName = regex.Matches(rawCsv);

            Regex regex2 = new Regex(@"\d+");
            MatchCollection matchesAge = regex2.Matches(rawCsv);


            List<Person> data = new List<Person>();

            for(int i = 0; i< matchesAge.Count;i++)
            {
                data.Add(new Person(matchesName[i].Value, matchesAge[i].Value));
            }


            Console.ReadKey();






            //foreach (Match match in matches)
            //    Console.WriteLine(match.Value);

            //List<string> rowName = new List<string>();
            //List<string> rowAge = new List<string>();

            //for (int i = 0; i<matches.Count; i++)
            //{
            //    rowName.Add(matches[i].Value.Split(';').First());
            //    rowAge.Add(matches[i].Value.Split(';').Last());
            //}







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

