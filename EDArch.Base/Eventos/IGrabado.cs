using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Base.Eventos
{
    public interface IGrabado<E> : IEvento where E : class
    {

    }

    public interface IGrabadoError<E> : IEvento
    {

    }
}
