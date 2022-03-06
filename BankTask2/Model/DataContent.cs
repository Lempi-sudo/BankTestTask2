using System;
using System.Collections.Generic;
using System.Linq;

namespace BankTask2
{
    class DataContent
    {
        private List<Employee> _data;

        public List<Employee> Data 
        {   
            get 
            {
                return _data ; 
            } 

            private set
            {
                _data = value;
            }
        }

        private int maxAgeEmployee=0;
        public int MaxAgeEmployee
        {
            get
            {
                return maxAgeEmployee;
            }
        }
        private int minAgeEmployee = 0;
        public int MinAgeEmployee
        {
            get
            {
                return minAgeEmployee;
            }
        }

        public DataContent(List<Employee> data)
        {
            Data = data;
            if (this.Data != null)
            {
                minAgeEmployee = _data.Min(e => e.Age); // минимальный возраст
                maxAgeEmployee = _data.Max(e => e.Age); // максимальный возраст
            }
        }

        private bool IsRangeOK(int index)
        {
            return (index < _data.Count && index >=0);
        }

        public Employee this[int index]
        {
            // Это аксессор get. Он оказался в итоге не нужен , но пусть будет 
            get
            {

                if (IsRangeOK(index))
                {
                   
                    return _data[index];

                }
                else
                {
                    throw new IndexOutOfRangeException(); 
                }
                
            }
        
        }

        public double meanYearsEmployee()
        {
            double tmp = (maxAgeEmployee - minAgeEmployee) / 2;
            return maxAgeEmployee - tmp;
        }

        public List<DataToPrint> GetDataToPrint()
        {
            List<DataToPrint> resdata = new List<DataToPrint>();

            var sortedEmp = _data.OrderBy(p => p.BirthYears);

            foreach (Employee emp in sortedEmp)
            {
                resdata.Add(new DataToPrint { Name = emp.SurnameInitials, YearsUntilPension = emp.YearBeforePension });
            }

            return resdata;
        }
    }
}



    
    
