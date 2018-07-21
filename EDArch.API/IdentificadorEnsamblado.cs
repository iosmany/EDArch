using System;
using System.Reflection;

namespace EDArch.API
{
    public static class IdentificadorEnsamblado
    {
        public static Assembly Get() => Assembly.GetExecutingAssembly();
    }
}
