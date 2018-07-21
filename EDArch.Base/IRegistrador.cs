using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Base
{
    public interface IRegistrador
    {
        void Ejecuta(Container contenedor);
    }
}
