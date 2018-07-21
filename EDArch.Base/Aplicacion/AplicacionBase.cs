using AutoMapper;
using AutoMapper.Configuration;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EDArch.Base.Aplicacion
{
    /// <summary>
    /// Inicializa la aplicación. Registra todas las dependencias de inyección, y los mapeos
    /// </summary>
    public abstract class AplicacionBase
    {
        static Container contenedor;
        static List<Assembly> ensamblados = new List<Assembly>();
        static List<Assembly> ensambladosPrincipales = new List<Assembly>();

        public static void Inicializa()
        {
            contenedor = new Container();
            EjecutaRegistradores();
            EjecutaMapeadores();
        }

        protected static void RegistraEnsamblados(params Assembly[] registros) => ensamblados.AddRange(registros);
        protected static void RegistraEnsambladosPrincipales(params Assembly[] registros) => ensambladosPrincipales.AddRange(registros);

        static void EjecutaRegistradores()
        {
            foreach (var tipo in ensambladosPrincipales.QueImplementen<IRegistrador>())
            {
                var registrador = (IRegistrador)Activator.CreateInstance(tipo);
                registrador.Ejecuta(contenedor);
            }
            foreach (var tipo in ensamblados.QueImplementen<IRegistrador>())
            {
                var registrador = (IRegistrador)Activator.CreateInstance(tipo);
                registrador.Ejecuta(contenedor);
            }
        }

        static void EjecutaMapeadores()
        {
            var configuration = new MapperConfigurationExpression();
            foreach (var tipo in ensambladosPrincipales.QueImplementen<IMapeador>())
            {
                var registrador = (IMapeador)Activator.CreateInstance(tipo);
                registrador.Ejecuta(configuration);
            }
            foreach (var tipo in ensamblados.QueImplementen<IMapeador>())
            {
                var registrador = (IMapeador)Activator.CreateInstance(tipo);
                registrador.Ejecuta(configuration);
            }
            Mapper.Initialize(configuration);
            Mapper.AssertConfigurationIsValid();
        }

        static void InicilizaBD()
        {

        }
    }

    static class AssembliesExtensiones
    {
        public static IEnumerable<Type> QueImplementen<I>(this ICollection<Assembly> ensamblados) where I : class
        {
            if (!typeof(I).IsInterface)
                throw new InvalidOperationException("El tipo requerido no es un interface");

            foreach (var refType in ensamblados.SelectMany(x=>x.GetTypes()))
            {
                if (typeof(I).IsAssignableFrom(refType))
                    yield return refType;
            }
        }
    }
}
