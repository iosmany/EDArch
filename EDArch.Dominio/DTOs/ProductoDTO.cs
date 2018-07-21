using EDArch.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Dominio.DTOs
{
    class ProductoDTO : IProducto
    {
        public long Id { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}
