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
        private int minAgeEmployee=0;

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
    }
}

    
    
