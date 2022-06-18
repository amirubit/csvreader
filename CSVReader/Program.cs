using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = args[0];
            string ind = args[1];
            string key = args[2];
            using (var reader = new StreamReader(path)) //@"C:\test.csv"
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);

                }

                string responseRes = "";
                string stringToCheck = key;// "INDIA";
                //string[] stringArray = { "text1", "testtest", "test1test2", "test2text1" };
                foreach (string x in listA)
                {
                    if (x.Contains(stringToCheck))
                    {
                        responseRes = x;
                        Console.WriteLine( responseRes);
                        // Response.Write(responseRes);
                    }

                }
                 
            }
        }

         
    }
}
