using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(15)]
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public double Price { get; set; }

        [ForeignKey("BookDetail")]
        public int BookDetail_Id { get; set; }

        public BookDetail BookDetail { get; set; }

        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }

        public Publisher Publisher { get; set; }

        public List<Author> Authors { get; set; }

    }
}
