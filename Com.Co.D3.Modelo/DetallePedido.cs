using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Co.D3.Modelo
{
    public class DetallePedido
    {
        public String numID { get; set; }
        public String idSucursal { get; set; }
        public String idVendedor { get; set; }
        public String strReferencia { get; set; }
        public String strColor { get; set; }
        public String strTalla { get; set; }
        public String intConjunto { get; set; }
        public String intCantidadPedida { get; set; }
        public String curPrecio { get; set; }
        public String codigoCrm { get; set; }
        public String dtmFecCreacion { get; set; }
    }
}
