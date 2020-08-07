using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        //Adding the unique key Id
        [Key]
        public int Id { get; set; }

        //Name of book
        [Required]
        public string Name { get; set; }

        //Author of book
        public string Author { get; set; }

        //ISBN of book
        public string ISBN { get; set; }
    }
}
