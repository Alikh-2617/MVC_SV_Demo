using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Country
    {
        [Key]
        [MaxLength(100)]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        public Continent? Continent { get; set; }
        public List<City>? Cities { get; set; }

    }
}
