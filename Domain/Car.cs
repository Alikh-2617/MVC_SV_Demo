using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Car
    {
        [Key]
        public int RegisterNumber { get; set; }
        [Required]
        [MaxLength(100)]
        public string Color { get; set; }
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        [Required]
        public DateTime Create { get; set; }
        public DateTime? Modify { get; set; }

        public Person? Owner { get; set; }
    }
}
