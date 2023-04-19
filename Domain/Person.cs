using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string EfterName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }   // tar bort  

        [Required]
        public DateTime Register { get; set; }

        public DateTime? Modify { get; set; }

        public City? City { get; set; }
        public House? House { get; set; }
        public List<Job>? Jobs { get; set; }
        public List<Car>? Cars { get; set; }
    }
}
