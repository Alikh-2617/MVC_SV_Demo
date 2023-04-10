using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain
{
    public class Continent
    {
        [Key]
        [MaxLength(100)]
        [Display(Name = "Continent Name")]
        public string ContinentName { get; set; }

        public List<Country>? Countries { get; set; }
    }
}
