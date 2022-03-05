using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BankTask2
{
    class ParserEmployee : IParser
    {
        public List<Employee> ParseString(string datastring)
        {
            List<Employee> resultdata = new List<Employee>();


            Regex regex = new Regex(@"[А-Яа-яёЁ\s]+");
            MatchCollection MatchName = regex.Matches(datastring);

         

            Regex regex2 = new Regex(@"\d+");
            MatchCollection BirthYear = regex2.Matches(datastring);

           
            for (int i = 0; i < BirthYear.Count; i++)
            {
                int birthyear = int.Parse(BirthYear[i].Value);

                Employee emp = new Employee (MatchName[i].Value, birthyear );

                resultdata.Add(emp);
            }
           
            return resultdata;

        }
    }
}
