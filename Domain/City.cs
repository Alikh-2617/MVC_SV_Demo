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
        public int PostNumber { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "City Name")]
        public string CityName { get; set; }

        public Country? Country { get; set; }
        public List<House>? Houses { get; set; }
    }
}
