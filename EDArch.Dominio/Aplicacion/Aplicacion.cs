using EDArch.Base.Aplicacion;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EDArch.Dominio.Aplicacion
{
    public sealed class Aplicacion : AplicacionBase
    {
        public static new void RegistraEnsamblados(params Assembly[] registros) => AplicacionBase.RegistraEnsamblados(registros);
        public static new void Inicializa()
        {
            RegistraEnsambladosPrincipales(Assembly.GetExecutingAssembly());
            AplicacionBase.Inicializa();
        }
    }
}
