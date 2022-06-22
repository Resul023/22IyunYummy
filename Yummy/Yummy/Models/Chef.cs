using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yummy.Models
{
    public class Chef
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Position { get; set; }
        public string Desc { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Image { get; set; }
        [Required]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
