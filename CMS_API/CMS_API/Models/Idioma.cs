using System;
using System.Collections.Generic;

namespace CMS_API.Models
{
    public partial class Idioma
    {
        public Idioma()
        {
            ProductoIdioma = new HashSet<ProductoIdioma>();
        }

        public int IdIdioma { get; set; }
        public string Nombre { get; set; }

        public ICollection<ProductoIdioma> ProductoIdioma { get; set; }
    }
}
