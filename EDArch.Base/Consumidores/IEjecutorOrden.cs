using EDArch.Base.Comandos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDArch.Base.Consumidores
{
    public interface IEjecutorOrden<O> where O : IOrden
    {
        Task EjecutarAsync(O orden);
    }
}
