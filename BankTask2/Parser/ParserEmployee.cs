using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BankTask2
{
    class ParserEmployee : IParser
    {
        private string getFullName(string text)
        {
            string name;
            string surname;
            string lastname;

            string resName = "";

            Regex regex = new Regex(@"[А-Яа-яёЁ]+");
            MatchCollection matches = regex.Matches(text);
            List<string> nameInit = new List<string>();

            if (matches.Count == 3)
            {
                name = matches[0].Value;
                surname = matches[1].Value;
                lastname = matches[2].Value;

                resName = name + " " + surname + " " + lastname;
            }
            return resName;
        }

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

                Employee emp = new Employee (getFullName(MatchName[i].Value), birthyear );

                resultdata.Add(emp);
            }
            return resultdata;
        }
    }
}


           



         

