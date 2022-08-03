using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models
{
    public class ObjectGenre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
