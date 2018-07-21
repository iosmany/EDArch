using EDArch.API.Comandos;
using EDArch.API.Entidades;
using EDArch.Base.Comandos;
using EDArch.Base.Consumidores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDArch.Dominio.Logica
{
    class GrabaProducto : IEjecutorOrden<IGrabaProducto>
    {
        public Task EjecutarAsync(IGrabaProducto orden)
        {
            
            return Task.CompletedTask;
        }
    }
}
