using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Name { get; set; }
        public int BirthYears { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
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

        private Gender gender;

        public Employee(string Name, int BirthYears)
        {
            this.Name = Name;
            this.BirthYears = BirthYears;
            this.Age = BirthYears;
            this.gender = determineGenderByName(this.Name);
        }

        public int CalculateHowManyYearsUntilPension(int maleageuntilpension, int femaleageuntilpension)
        {
            if (gender == Gender.Female)
            {
                return femaleageuntilpension - this.Age;
            }
            else if (gender == Gender.Male)
            {
                return maleageuntilpension - this.Age;
            }
            else
            {
                Console.WriteLine("Информации для такого гендера нет");
                return 0;
            }
        }

        public Gender determineGenderByName(string Name)
        {
            return Gender.Other;

        } 



    }
}
