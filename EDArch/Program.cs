using EDArch.Dominio.Aplicacion;
using System;
using System.Reflection;

namespace EDArch
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicacion.RegistraEnsamblados(MassTransit.IdentificadorEnsamblado.Get());
            Aplicacion.Inicializa();
        }
    }
}
