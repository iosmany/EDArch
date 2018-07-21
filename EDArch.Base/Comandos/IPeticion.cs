using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Base.Comandos
{
    public interface IPeticion
    {
    }

    public interface IPeticion<P, out R> where P : class where R : class
    {
    }
}
