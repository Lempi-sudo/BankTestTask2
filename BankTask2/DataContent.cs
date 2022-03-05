using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask2
{
    class DataContent
    {
        private List<DataContent> _data;

        public  List<DataContent> Data 
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

        private int maxYearEmployee;
        private int minYearEmployee;

        public double meanYearsEmployee()
        {
            double tmp = (maxYearEmployee - minYearEmployee) / 2;
            return maxYearEmployee -tmp;
        }

        public DataContent(List<DataContent> data)
        {
            Data = data;
        }

    }
}

    
    
