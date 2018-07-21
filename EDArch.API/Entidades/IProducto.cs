using System;
using System.Collections.Generic;
using System.Text;

namespace EDArch.API.Entidades
{
    public interface IProducto
    {
        long Id { get;  }
        string Nombre { get;  }
        decimal Precio { get;  }
        int Stock { get;  }
    }
}
