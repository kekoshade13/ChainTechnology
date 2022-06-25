using Presentacion.Controllers;
using Presentacion.Controllers.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.APIs
{
    public class APIPublicidad
    {
            public void guardarPublicidad(object banners)
            {
            createJson jsonCreate = new createJson();
            jsonCreate.serializarBanners(banners);
        }
    }
}
