using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BankTask2
{
    enum Gender
    {
        Male,
        Female,
        Other
    }


    class Employee
    {
        private string _fullName;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            private set
            {
                _fullName = value;
            }
        }

        private string _surnameInitials;
        public string SurnameInitials
        {
            get
            {
                return _surnameInitials;
            }

            private set
            {
                _surnameInitials = value;
            }
        }

        public int BirthYears { get; private set; }

        public Gender gender { get; private set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                int currentYear = DateTime.Now.Year;
                _age = currentYear - value;
            }
        }

        private int _yearBeforPension;
        public int YearBeforePension
        {
            get
            {
                return _yearBeforPension;
            }
            private set
            {
                _yearBeforPension = value;
            }

        }

        public Employee(string FullName, int BirthYears)
        {
            this.FullName = FullName;
            this.BirthYears = BirthYears;
            this.Age = BirthYears;
            this.SurnameInitials = getSurnameInitialByFullName(FullName);
            this.gender = determineGenderByName(FullName);
        }

        private string getSurnameInitialByFullName(string FullName)
        {
            string resName="";
            var listnames = getNameSurnameLastname(FullName);
            if (listnames.Count == 3)
            {
                resName = listnames[0] + " " + firstCharWord(listnames[1]) + ". " + firstCharWord(listnames[2]) + '.';
                return resName;
            }
            Console.WriteLine("ErrorTrace : getSurnameInitialByFullName ошибка не полный список ");
            return resName;
        }
        private Gender determineGenderByName(string FullName)
        {
            var listNames = getNameSurnameLastname(FullName);

            if (listNames.Count == 3)
            {
                string surname = listNames[0];
                string name= listNames[1];
                string lastname= listNames[2];

               

                if (lastSymbolName(name) == "а" || lastSymbolName(name) == "я") return Gender.Female;
                else return Gender.Male;
                
            }

            Console.WriteLine("ErrorTrace : getSurnameInitialByFullName ошибка не полный список ");
            return Gender.Other;
        } 


        private List<string> getNameSurnameLastname(string FullName)
        {
            List<string> res = new List<string>();
            Regex regex = new Regex(@"[А-Яа-яёЁ]+");
            MatchCollection matches = regex.Matches(FullName);
            List<string> nameInit = new List<string>();

            foreach(Match match in matches)
            {
                res.Add(match.Value);
            }
            return res;
        }
        private string lastSymbolName(string name)
        {
            List<string> res = new List<string>();
            Regex regex = new Regex(@"[а-яё]$");
            MatchCollection matches = regex.Matches(name);
            if (matches.Count != 0)
            {
                string lastSymbol = matches[0].Value;
                return lastSymbol;
                

            }
            return "";
        }
        private string firstCharWord(string word)
        {
            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(word))
            {
           
                return Char.ToString(word[0]);
            }
            return "";
        }

        public void SetYearsUntilPension(int maleageuntilpension, int femaleageuntilpension)
        {
            if (gender == Gender.Female)
            {
                YearBeforePension = 0;
                if (femaleageuntilpension - this.Age > 0)
                {
                    YearBeforePension = femaleageuntilpension - this.Age;
                }
               
            }
            else if (gender == Gender.Male)
            {
                YearBeforePension = 0;
                if (maleageuntilpension - this.Age > 0)
                {
                    YearBeforePension = maleageuntilpension - this.Age;
                }
             
            }
            else
            {
                Console.WriteLine("Информации для такого гендера нет");
            }
        }





       


    }
}


            
         




          






            
           

            

          


            



       



