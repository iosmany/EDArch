using EDArch.API.Comandos;
using EDArch.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Dominio.Comandos
{
    class GrabaProducto : IGrabaProducto 
    {
        public IProducto Entidad { get; set; }
    }
}
