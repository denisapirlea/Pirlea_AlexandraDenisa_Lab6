using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Pirlea_AlexandraDenisa_Lab6.Models
{
    public class Book
    {
        public int ID { get; set; } 
        public string Title { get; set; }
        [Display(Name = "Book Title")]
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime PublishingDate { get; set; }
    }
}
