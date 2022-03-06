using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace BankTask2
{
    public class ManagerPension
    {
        public ManagerPension(int male, int female)
        {
            FemaleYear = female;
            MaleYear = male;
        }

        public readonly int FemaleYear;
        public readonly int MaleYear;
    }
    

    class Client
    {

        public void Main()
        {
            ManagerPension managerPension = new ManagerPension(65, 60);

            //Надо будет сделать поиск автоматом или просить пользователя ввести:
            string path = "D:/Code/C#/BankTask2/BankTask2/Список_имен.csv";

            IReaderData reader = new FileReader();

            IParser parser = new ParserEmployee();

            List<Employee> listdata = parser.ParseString(reader.ReadText(path));

            foreach(Employee emp in listdata)
            {
                emp.SetYearsUntilPension(managerPension.MaleYear, managerPension.FemaleYear);
            }
            
            DataContent datacontainer = new DataContent(listdata);

            double mean = datacontainer.meanYearsEmployee();
            
        }
    }
}

           
         


         



            


