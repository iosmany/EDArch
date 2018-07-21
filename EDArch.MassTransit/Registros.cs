using EDArch.Base;
using MassTransit;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDArch.MassTransit
{
    class Registros : IRegistrador
    {
        public void Ejecuta(Container contenedor)
        {
            contenedor.RegisterSingleton<IBusControl>(() =>
            {
                return Bus.Factory.CreateUsingRabbitMq(sbc =>
                {
                    var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });
                });
            }); 
        }
    }
}
