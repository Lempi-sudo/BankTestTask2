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

            //Надо будет сделать поиск автоматом или просить пользователя ввести:
            //string path = "D:/Code/C#/BankTask2/BankTask2/Список_имен.csv";
            Console.WriteLine("Укажите путь к файлу :");
            string path = Console.ReadLine();


            IReaderData reader = new FileReader();

            IParser parser = new ParserEmployee();

            List<Employee> listdata = parser.ParseString(reader.ReadText(path));

            DataContent datacontainer = new DataContent(listdata);

            //Назначаем Пенсионный возраст а затем высчитываем 
            ManagerPension managerPension = new ManagerPension(65, 60);
            datacontainer.SetYearsUntilPensionForAllEmployes(managerPension.MaleYear, managerPension.FemaleYear);

            //Вывод данных в Консоль
            IPrinter consoleprinter = new ConsolePrinter();
            consoleprinter.PrintData(datacontainer.GetDataToPrint());


            //Сохранить результат в директории Документы для текущего пользователя в файл с "Результирующий Документ.csv" 
            string pathcvs = @"C:\Users\" + Environment.UserName + @"\Documents\Результирующий Документ.csv";
            IPrinter csvPrinter = new CsvPrinter(pathcvs);
            csvPrinter.PrintData(datacontainer.GetDataToPrint());

            Console.WriteLine();
            Console.WriteLine("=======================================================================================");
            Console.WriteLine();
            Console.WriteLine($"минимальный возраст:{datacontainer.MinAgeEmployee}");
            Console.WriteLine($"максимальный возраст:{datacontainer.MaxAgeEmployee}");
            double mean = datacontainer.meanYearsEmployee();
            Console.WriteLine($"Cредний возраст:{mean}");
            Console.WriteLine($"Данные сохранены в CSV файле. Путь к нему {pathcvs}");

            Console.ReadKey();
        }
    }
}
            




            







           
         


         



            


