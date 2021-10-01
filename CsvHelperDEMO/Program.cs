using System;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;

namespace CsvHelperDEMO
{
    public class Program
    {
        public static void Main()
        {
            List<Person> records = new List<Person>();
            using (var streamReader = new StreamReader(@"C:\Users\Phili\source\repos\CsvHelperDEMO\CsvHelperDEMO\bin\Debug\net5.0\klasslista-21.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };

                using (var csvReader = new CsvReader(streamReader, config))
                {
                    records = csvReader.GetRecords<Person>().ToList();
                }
                foreach (var record in records)
                {
                    Console.WriteLine($"{record.Username} | {record.FirstName} {record.LastName} | Mail: {record.Email}");
                }
            }
        }
    }
}
