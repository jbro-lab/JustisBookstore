using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JustisBookstore.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string classification { get; set; }
        public string category { get; set; }
        public float price { get; set; }
    }
}
