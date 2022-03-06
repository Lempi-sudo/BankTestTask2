using System.Text;

namespace BankTask2
{
    class FileReader : IReaderData
    {
        public string ReadText(string path)
        {
            return System.IO.File.ReadAllText(path, Encoding.GetEncoding(1251));
        }
    }
}
