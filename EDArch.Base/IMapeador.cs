using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.Base
{
    public interface IMapeador
    {
        void Ejecuta(IMapperConfigurationExpression mapper);
    }
}
