using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCT_1.Models
{
    public class People
    {
        // The index
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Address { get; set; }

        public int Age {get; set;}

        [StringLength(64)]
        public string Interests { get; set; }

        [StringLength(32)]
        public String Photo { get; set; }
    }
}
