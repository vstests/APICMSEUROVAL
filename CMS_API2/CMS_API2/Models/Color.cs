using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS_API2.Models
{
    public partial class Color
    {
        public Color()
        {
            ProductoColor = new HashSet<ProductoColor>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdColor { get; set; }
        [Key]
        public string NombreColor { get; set; }

        public ICollection<ProductoColor> ProductoColor { get; set; }
    }
}
