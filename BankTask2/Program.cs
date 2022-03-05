using System.Collections.Generic;
using System.Text;
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

            new Client().Main();

            var pathCsvFile = "D:/Code/C#/BankTask2/BankTask2/Список_имен.csv";

            var rawCsv =  System.IO.File.ReadAllText(pathCsvFile, Encoding.GetEncoding(1251));

           
            Regex regex = new Regex(@"[А-Яа-яёЁ\s]+");
            MatchCollection matchesName = regex.Matches(rawCsv);

            Regex regex2 = new Regex(@"\d+");
            MatchCollection matchesAge = regex2.Matches(rawCsv);


            List<string> fullname = new List<string>();

            List<Person> data = new List<Person>();

            string name1 = null ;
           

            for(int i = 0; i< matchesAge.Count;i++)
            {
                if (!string.IsNullOrEmpty(matchesName[i].Value))
                {
                    name1=matchesName[i].Value;
                }
            }


            Regex regex3 = new Regex(@"[А-Яа-яёЁ]+");
            MatchCollection matchesname21 = regex3.Matches(name1);
            List<string> funame = new List<string>();
            for (int i = 0; i < matchesname21.Count; i++)
            {
                if (!string.IsNullOrEmpty(matchesname21[i].Value))
                {
                  
                }
            }



            //CЛЕДУЮЩИЙ ВОПРОС КАК ПЕРЕВЕСТИ СТРОКУ В ЧИСЛО ????

            List<int> ageint = new List<int>();
             for (int i = 0; i < matchesAge.Count; i++)
            {


                ageint.Add(int.Parse(matchesAge[i].Value));
                
            }

            



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

