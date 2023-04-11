using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Job
    {
        [Key]
        [MaxLength(100)]
        public string JobName { get; set; }
        [Required]
        public int Salary { get; set; }

        public List<Person>? People { get; set; }
    }
}
