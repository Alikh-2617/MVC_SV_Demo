using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class City
    {
        [Key]
        public string PostNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string CityName { get; set; }
        public DateTime? Create { get; set; }

        public Country? Country { get; set; }
        public List<House>? Houses { get; set; }
    }
}
