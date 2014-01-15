using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Co.D3.Modelo
{

    public class EncabezadoPedido
    {
        public String idSucursal { get; set; }
        public String idEstadoPedido { get; set; }
        public String idCliente { get; set; }
        public String idClienteDespacho { get; set; }
        public String idClienteFacturar { get; set; }
        public String idListadePrecios { get; set; }
        public String idMoneda { get; set; }
        public String idVendedor { get; set; }
        public String strOrdendeCompra { get; set; }
        public String strTipoOrdendeCompra { get; set; }
        public String memObservaciones { get; set; }
        public String dtmFecPedido { get; set; }
        public String dtmFecEntregaInicial { get; set; }
        public String dtmFecEntregaFinal { get; set; }
        public List<DetallePedido> detallesPedido { get; set; }
        public String codigoCrm { get; set; }

    }
}
