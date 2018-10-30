using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CsvUploader.Models
{
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
}
