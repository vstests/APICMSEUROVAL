using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS_API2.Models
{
    public partial class Producto
    {
        //public Producto()
        //{
        //    ProductoColor = new HashSet<ProductoColor>();
        //    ProductoIdioma = new HashSet<ProductoIdioma>();
        //}
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        [Key]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? Categoria { get; set; }

        public Categoria CategoriaNavigation { get; set; }
        public ICollection<ProductoColor> ProductoColor { get; set; }
        public ICollection<ProductoIdioma> ProductoIdioma { get; set; }
    }
}
