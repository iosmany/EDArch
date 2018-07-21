using EDArch.API.Entidades;
using EDArch.Base.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.API.Eventos
{
    public interface IProductoGrabado : IGrabado<IProducto>
    {
    }

    public interface IProductoGrabadoError : IGrabadoError<IProducto>
    {
    }
}
