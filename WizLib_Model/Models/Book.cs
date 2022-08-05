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
        public string ISBN { get; set; }
    }
}
