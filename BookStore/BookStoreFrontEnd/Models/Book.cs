using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreFrontEnd.Models
{
    public class Book
    {
        [Key]
        [MaxLength(30)]
        public string Isbn { get; set; }
        [MaxLength(200)]
        public String Title { get; set; }
        [MaxLength(50)]
        public string Category { get; set; }
        [MaxLength(50)]
        public string Edition { get; set; }
        public int PublishYear { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
