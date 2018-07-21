using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Base.Eventos
{
    public interface IBorrado<E> : IEvento
    {
    }

    public interface IBorradoError<E> : IEvento
    {
    }
}
