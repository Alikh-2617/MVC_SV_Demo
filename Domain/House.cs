using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class House
    {
        [Key]
        public int HouseNumber { get; set; }
        [Required]
        public DateTime Create { get; set; }
        public DateTime? Modify { get; set; }
        public List<Person>? People { get; set; }
        public City? City { get; set; }
    }
}
