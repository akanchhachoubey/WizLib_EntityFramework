using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetailId { get; set; }

        [Required]
        public string NumberofChapters { get; set; }
        public string NumberofPages { get; set; }

        public double Weight { get; set; }

        public Book Book { get; set; }
    }
}
