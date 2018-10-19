using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CsvParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            var text = "ID, FirstName, LastName, PhoneNumber,BDay\r\n1, Mitch,Valenta,8675309, Jun 23 1992 4:00AM\r\n2,Milo,Valenta,5550123, Dec 13 2015 12:00AM";
            using (var stream = StreamHelper.GenerateStreamFromString(text))
            {
                var list = stream.CsvToList<User>();
                Console.WriteLine("Manual CSV Reader: " + JsonConvert.SerializeObject(list));
            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }


    }
    public class User
    {
        [Display(Name = "ID", Order = 1)]
        public string Id { get; set; }
        [Display(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }
        [Display(Name = "LastName", Order = 3)]
        public string LastName { get; set; }
        [Display(Name = "PhoneNumber", Order = 4)]
        public string PhoneNumber { get; set; }
        [Display(Name = "BDay", Order = 5)]
        public DateTime Birthday { get; set; }
    }
    public class CsvMap
    {
        public string Name { get; set; }
        public string MappedTo { get; set; }
        public int Index { get; set; }
    }
}