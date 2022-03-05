using System;


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

        public string FullName { get; set; }
        public int BirthYears { get; set; }

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

        private Gender gender;

        public Employee(string Name, int BirthYears)
        {
            this.FullName = Name;
            this.BirthYears = BirthYears;
            this.Age = BirthYears;
            this.gender = determineGenderByName(Name);
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

            
        public Gender determineGenderByName(string Name)
        {
            return Gender.Male;

        } 
    }
}



       



