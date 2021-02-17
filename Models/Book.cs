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
        public int BookId { get; set; }
        [RegularExpression(@"^\([\d]{3}\)-[\d]{9}$", ErrorMessage = "ISBN must be in ###-######### format")]
        public string ISBN { get; set; }
        public string title { get; set; }
        public string authorFirstName { get; set; }
        public string? authorMiddleName { get; set; }
        public string authorLastName { get; set; }
        public string publisher { get; set; }
        public string classification { get; set; }
        public string category { get; set; }
        public double price { get; set; }

        public Book()
        {
            this.authorMiddleName = "";
        }
    }
}
