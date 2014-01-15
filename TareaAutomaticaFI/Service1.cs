using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using Com.Co.D3.AccesoDatos.AccesoDatosFormasIntimas;
using Com.Co.D3.Modelo;
using Com.Co.D3.Negocio.FormasIntimas;
using Com.Co.D3.Servicios;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace TareaAutomaticaFI
{
    public partial class TareaAutomaticaFI : ServiceBase
    {
        private Timer timerSincronizacionHora;
        private Timer timerSincronizacion24Horas;
        private System.Threading.Timer TimerItem;

        List<Cliente> clientes;
        List<ClienteCriterio> clientesCriterio;
        List<Producto> productos;
        List<ProductoTalla> productosTalla;
        List<ProductoColor> productosColor;
        List<ListaPreciosReferencia> listaPreciosReferencias;
        List<ListaPrecios> listaPrecios;
        List<Vendedor> vendedores;
        List<Color> colores;
        List<Cartera> cartera;
        List<EstadosPedidos> estadosPedidos;
        List<TipoPrenda> tiposPrendas;
        List<TipoPrendaReferencia> tiposPrendasReferencias;
        List<Talla> tallas;

        List<string> codigosCrm;
        List<EncabezadoPedido> encabezadosPedidos;

        public TareaAutomaticaFI()
        {
        }

        private void InitializeComponent()
        {
        }

        protected override void OnStart(string[] args)
        {
            

            System.Threading.Thread.Sleep(20000);
            long tiempoSincronizacionPedidos = long.Parse(ConfigurationManager.AppSettings["TiempoSincronizacionPedidos"]);
            long tiempoSincronizacionMaestros = long.Parse(ConfigurationManager.AppSettings["TiempoSincronizacionMaestros"]);

            // Inicio temporizador cada hora
            timerSincronizacionHora = new Timer(tiempoSincronizacionPedidos); // cada Hora
            timerSincronizacionHora.Elapsed += new System.Timers.ElapsedEventHandler(timer_ElapsedHora);
            timerSincronizacionHora.Start();

            // Inicio temporizador cada 24 horas

            //timerSincronizacion24Horas = new Timer(tiempoSincronizacionMaestros); // cada 24 horas
            //timerSincronizacion24Horas.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed24Horas);
            //timerSincronizacion24Horas.Start();
        }

        protected override void OnStop()
        {
            if (timerSincronizacionHora != null)
            {
                timerSincronizacionHora.Dispose();
            }
            if (timerSincronizacion24Horas != null)
            {
                timerSincronizacion24Horas.Dispose();
            }
        }

        private void timer_ElapsedHora(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                NegocioFormasIntimas negocioFormasIntimas = new NegocioFormasIntimas();
                //NegocioCRM negocioCRM = new NegocioCRM();
                ServicioCRM serviciosCRM = new ServicioCRM();

                bool estadoConexionFI = DatosFormasIntimas.AbrirConexion();
                //bool estadoConexionCrm = DatosCMR.AbrirConexion();

                if (estadoConexionFI)
                {
                    // Obtengo los pedidos del Crm (codigoCrm) para validar el estado en FI
                    List<EncabezadoPedido> pedidos = serviciosCRM.GetPedidos();
                    codigosCrm = pedidos.Select(t => t.codigoCrm).ToList();

                    // Obtengo el estado de los pedidos desde la BD de FI
                    encabezadosPedidos = negocioFormasIntimas.GetPedidos(codigosCrm);

                    /* Establezco los nuevos estados de los pedidos del CRM */
                    serviciosCRM.SetPedidos(encabezadosPedidos);

                    // Obtengo los nuevos pedidos del Crm
                    pedidos = serviciosCRM.GetPedidos();

                    // Subo los pedidos a la BD de FI
                    negocioFormasIntimas.SetPedidos(pedidos);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void timer_Elapsed24Horas(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                NegocioFormasIntimas negocioFormasIntimas = new NegocioFormasIntimas();
                // NegocioCRM negocioCRM = new NegocioCRM();
                ServicioCRM serviciosCRM = new ServicioCRM();

                bool estadoConexionFI = DatosFormasIntimas.AbrirConexion();
                //bool estadoConexionCrm = DatosCMR.AbrirConexion();

                if (estadoConexionFI)
                {
                    /* Descargamos los datos desde la BD de FI */

                    // Obtengo los Maestros
                    this.ObtenerMaestrosFI(negocioFormasIntimas);

                    /* Subimos los datos a la BD  */
                    // Actualizo la información de los maestros en la BD del CRM

                    //serviciosCRM.SetColores(colores);
                    //serviciosCRM.SetTallas(tallas);
                    //serviciosCRM.SetTipoPrendas(tiposPrendas);
                    //serviciosCRM.SetListaPrecios(listaPrecios);
                    //serviciosCRM.SetVendedores(vendedores);
                    serviciosCRM.SetClientes(clientes);
                    //serviciosCRM.SetProductos(productos);
                    //serviciosCRM.SetProductosTalla(productosTalla);
                    //serviciosCRM.SetProductosColor(productosColor);
                    //serviciosCRM.SetListaPreciosReferencia(listaPreciosReferencias);                   
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ObtenerMaestrosFI(NegocioFormasIntimas negocioFormasIntimas)
        {
            // Obtengo los Maestros
            clientes = negocioFormasIntimas.GetClientes();
            clientesCriterio = negocioFormasIntimas.GetClientesCriterio();
            //productos = negocioFormasIntimas.GetProductos();
            //productosTalla = negocioFormasIntimas.GetProductosTalla();
            //productosColor = negocioFormasIntimas.GetProductosColor(); ;
            //listaPreciosReferencias = negocioFormasIntimas.GetListaPreciosReferencia();
            //listaPrecios = negocioFormasIntimas.GetListaPrecios();
            //vendedores = negocioFormasIntimas.GetVendedores();
            //colores = negocioFormasIntimas.GetColores();
            //cartera = negocioFormasIntimas.GetCartera();
            //estadosPedidos = negocioFormasIntimas.GetEstadosPedidos();
            //tallas = negocioFormasIntimas.GetTallas();
            //tiposPrendas = negocioFormasIntimas.GetTiposPrendas();
            //tiposPrendasReferencias = negocioFormasIntimas.GetTiposPrendasReferencias();

            if (clientes != null && clientesCriterio != null)
            {
                foreach (Cliente cliente in clientes)
                {
                    ClienteCriterio clienteCriterio = clientesCriterio.First(t => t.NIT == cliente.NIT && t.Sucursal.Trim() == cliente.Sucursal.Trim());

                    if (clienteCriterio != null)
                    {
                        cliente.ID_ListaPrecios = clienteCriterio.ID_Lista_Precios;
                    }
                }
            }

            //if (tiposPrendasReferencias != null && productos != null)
            //{
            //    productos = (from pro in productos
            //                 join tiposPR in tiposPrendasReferencias on pro.Referencia equals tiposPR.f120_referencia
            //                 select new Producto
            //                 {
            //                     Referencia = pro.Referencia,
            //                     f120_descripcion = pro.f120_descripcion,
            //                     f120_descripcion_corta = pro.f120_descripcion_corta,
            //                     TiposPrenda_f106_id = tiposPR.f106_id
            //                 }).ToList();
            //}
        }
    }
}
