using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyResume_Asp.Models
{
    public class MyInformation
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Degree { get; set; }
        public string Email { get; set; }
        public string Freelance { get; set; }
        public string Birthday { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }
}
