using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Base.Comandos
{
    public interface IGraba<out E> : IOrden where E : class
    {
        E Entidad { get; }
    }
}
