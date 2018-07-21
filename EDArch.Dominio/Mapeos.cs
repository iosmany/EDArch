using AutoMapper;
using EDArch.API.Entidades;
using EDArch.Base;
using EDArch.Dominio.DTOs;
using EDArch.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Dominio
{
    class Mapeos : IMapeador
    {
        public void Ejecuta(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Producto, ProductoDTO>();
            mapper.CreateMap<IProducto, Producto>();
            mapper.CreateMap<Producto, IProducto>().As<ProductoDTO>();
        }
    }
}
