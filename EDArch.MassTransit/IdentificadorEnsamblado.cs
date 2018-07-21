using System;
using System.Reflection;

namespace EDArch.MassTransit
{
    public static class IdentificadorEnsamblado
    {
        public static Assembly Get() => Assembly.GetExecutingAssembly();
    }
}
