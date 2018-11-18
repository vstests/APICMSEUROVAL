using System;
using System.Collections.Generic;

namespace CMS_API.Models
{
    public partial class ProductoColor
    {
        public int IdProducto { get; set; }
        public int IdColor { get; set; }

        public Color IdColorNavigation { get; set; }
        public Producto IdProductoNavigation { get; set; }
    }
}
