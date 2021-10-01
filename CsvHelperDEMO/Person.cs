using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace CsvHelperDEMO
{
    public class Person
    {
        //[Name("Username")]
        public string Username { get; set; }
        //[Name("FirstName")]
        public string FirstName { get; set; }
        //[Name("LastName")]
        public string LastName { get; set; }
        //[Name("Email")]
        public string Email { get; set; }
    }
}
