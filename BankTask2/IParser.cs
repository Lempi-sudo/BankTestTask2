using System.Collections.Generic;


namespace BankTask2
{
    interface IParser
    {
        List<Employee> ParseString(string str);
    }
}

