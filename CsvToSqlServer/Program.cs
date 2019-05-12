using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Welcome to Csv to Sql Server script converter ====");
            Console.WriteLine("==== Usage example: (<Mandatory argument>, [Optional argument]) ====");
            Console.WriteLine();
            Console.WriteLine("==== CsvToSqlServer <Csv file path (string)> <Table Name (string)> [Use First row as table headers (1/0) ");

            if (ValidateArgs(args) == false)
            {
                Console.ReadLine();
                return;
            }
                

            var csvFileLine = LoadCsvFile(args[0]);
        }

        private static bool ValidateArgs(string[] args)
        {
            throw new NotImplementedException();
        }

        private static object LoadCsvFile(string csvFilePath)
        {
            return null;
        }

        public static string ConvertCsvToSqlScript(List<string> csvFileLines, string tableName)
        {
            return null;
        }
    }
}
