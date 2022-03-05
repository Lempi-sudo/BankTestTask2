using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            findMaxAge();
            findMinAge();
        }

        private void findMaxAge()
        {
            foreach (Employee emp in _data)
            {
                if (emp.Age > maxAgeEmployee)
                {
                    maxAgeEmployee = emp.Age;
                }
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

        private void findMinAge()
        {
            minAgeEmployee = maxAgeEmployee;
            foreach (Employee emp in _data)
            {
                if (emp.Age < minAgeEmployee)
                {
                    minAgeEmployee = emp.Age;
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

    
    
