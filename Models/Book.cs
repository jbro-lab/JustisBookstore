using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JustisBookstore.Models
{
    public class Book
    {
        [Key]//makes BookId the Key
        public int BookId { get; set; }
        [RegularExpression(@"^\([\d]{3}\)-[\d]{9}$", ErrorMessage = "ISBN must be in ###-######### format")]
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string authorFirstName { get; set; }//name is split into three portions so that it's normalized
        [Required]
        public string authorMiddleName { get; set; }
        [Required]
        public string authorLastName { get; set; }
        [Required]
        public string publisher { get; set; }
        [Required]
        public string classification { get; set; }//classification and category were split up
        [Required]
        public string category { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public int numPages { get; set; }

        public Book()
        {
            this.authorMiddleName = "";//sets middlename to a defualt of ""
        }
    }
}
