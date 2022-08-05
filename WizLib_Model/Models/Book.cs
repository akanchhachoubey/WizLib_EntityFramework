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

        [ForeignKey("ObjectType")]
        public int ObjectType_Id { get; set; }

        public ObjectType ObjectType { get; set; }

    }
}
