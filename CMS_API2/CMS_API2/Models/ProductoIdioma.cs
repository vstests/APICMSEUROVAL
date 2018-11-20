using System;
using System.Collections.Generic;

namespace CMS_API2.Models
{
    public partial class ProductoIdioma
    {
        public int IdProducto { get; set; }
        public int IdIdioma { get; set; }

        public Idioma IdIdiomaNavigation { get; set; }
        public Producto IdProductoNavigation { get; set; }
    }
}
