using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class FlowerMainText
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
