using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Com.Co.D3.AccesoDatos.AccesoDatosFormasIntimas;
using Com.Co.D3.Modelo;
using Newtonsoft.Json;

namespace Com.Co.D3.Negocio.FormasIntimas
{
    public class NegocioFormasIntimas
    {

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataSet db = DatosFormasIntimas.GetClientes();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach(DataRow row in data.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.idCliente = row["idCliente"] == null ? string.Empty : row["idCliente"].ToString();
                    cliente.NIT = row["NIT"] == null ? string.Empty : row["NIT"].ToString();
                    cliente.RazonSocial = row["RazonSocial"] == null ? string.Empty : row["RazonSocial"].ToString();
                    cliente.Sucursal = row["Sucursal"] == null ? string.Empty : row["Sucursal"].ToString();
                    cliente.NombreAlmacen = row["NombreAlmacen"] == null ? string.Empty : row["NombreAlmacen"].ToString();
                    cliente.Direccion1 = row["Direccion1"] == null ? string.Empty : row["Direccion1"].ToString();
                    cliente.Direccion2 = row["Direccion2"] == null ? string.Empty : row["Direccion2"].ToString();
                    cliente.Direccion3 = row["Direccion3"] == null ? string.Empty : row["Direccion3"].ToString();
                    cliente.Telefono = row["Telefono"] == null ? string.Empty : row["Telefono"].ToString();
                    cliente.Email = row["Email"] == null ? string.Empty : row["Email"].ToString();
                    cliente.ContactoUNOEE = row["ContactoUNOEE"] == null ? string.Empty : row["ContactoUNOEE"].ToString();
                    cliente.ID_Ciudad = row["ID_Ciudad"] == null ? string.Empty : row["ID_Ciudad"].ToString();
                    cliente.ID_Depto = row["ID_Depto"] == null ? string.Empty : row["ID_Depto"].ToString();
                    cliente.ID_Pais = row["ID_Pais"] == null ? string.Empty : row["ID_Pais"].ToString();
                    cliente.cupo = row["f201_cupo_credito"] == null ? string.Empty : row["f201_cupo_credito"].ToString();
                    //cliente.f201_ind_bloqueo_cupo = row["f201_ind_bloqueo_cupo"] == null ? string.Empty : row["f201_ind_bloqueo_cupo"].ToString();
                    cliente.ID_Vendedor = row["f201_id_vendedor"] == null ? string.Empty : row["f201_id_vendedor"].ToString();
                    cliente.ID_Zona = "1";
                    cliente.ID_ListaPrecios = "01";
                    clientes.Add(cliente);
                }
                data.Dispose();
                db.Dispose();
            }

            return clientes;
        }

        public List<ClienteCriterio> GetClientesCriterio()
        {
            List<ClienteCriterio> clientesCriterio = new List<ClienteCriterio>();
            DataSet db = DatosFormasIntimas.GetClientesCriterio();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    ClienteCriterio clienteCriterio = new ClienteCriterio();
                    clienteCriterio.ID_Cliente = row["idCliente"] == null ? string.Empty : row["idCliente"].ToString();
                    clienteCriterio.NIT = row["NIT"] == null ? string.Empty : row["NIT"].ToString();
                    clienteCriterio.Sucursal = row["Sucursal"] == null ? string.Empty : row["Sucursal"].ToString();
                    clienteCriterio.ID_Lista_Precios = row["ID_Lista_Precios"] == null ? string.Empty : row["ID_Lista_Precios"].ToString();

                    clientesCriterio.Add(clienteCriterio);
                }
                data.Dispose();
                db.Dispose();
            }

            return clientesCriterio;
        }

        public List<Cartera> GetCartera()
        {
            List<Cartera> carteras = new List<Cartera>();
            DataSet db = DatosFormasIntimas.GetCartera();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    Cartera cartera = new Cartera();
                    cartera.f200_nit = row["f200_nit"] == null ? string.Empty : row["f200_nit"].ToString();
                    cartera.f200_razon_social = row["f200_razon_social"] == null ? string.Empty : row["f200_razon_social"].ToString();
                    cartera.f20f201_id_sucursal = row["f201_id_sucursal"] == null ? string.Empty : row["f201_id_sucursal"].ToString();
                    cartera.tipoDocumentoCruce = row["TipoDocumentoCruce"] == null ? string.Empty : row["TipoDocumentoCruce"].ToString();
                    cartera.documentoCruce = row["DocumentoCruce"] == null ? string.Empty : row["DocumentoCruce"].ToString();
                    cartera.fechaMovimiento = row["FechaMovimiento"] == null ? string.Empty : row["FechaMovimiento"].ToString();
                    cartera.fechaVencimiento = row["FechaVencimiento"] == null ? string.Empty : row["FechaVencimiento"].ToString();
                    cartera.strValor = row["strValor"] == null ? string.Empty : row["strValor"].ToString();
                    cartera.strSaldo = row["strSaldo"] == null ? string.Empty : row["strSaldo"].ToString();
                    cartera.strDebCre = row["strDebCre"] == null ? string.Empty : row["strDebCre"].ToString();
                    cartera.strRecProv = row["strRecProv"] == null ? string.Empty : row["strRecProv"].ToString();
                    carteras.Add(cartera);
                }
                data.Dispose();
                db.Dispose();
            }

            return carteras;
        }
        
        public List<Color> GetColores()
        {
            List<Color> colores = new List<Color>();
            DataSet db = DatosFormasIntimas.GetColores();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    Color color = new Color();
                    color.ID_Color = row["ID_Color"] == null ? string.Empty : row["ID_Color"].ToString();
                    color.color = row["Color"] == null ? string.Empty : row["Color"].ToString();
                    color.f117_descripcion_corta = row["f117_descripcion_corta"] == null ? string.Empty : row["f117_descripcion_corta"].ToString();
                    colores.Add(color);
                }
                data.Dispose();
                db.Dispose();
            }

            return colores;
        }


        public List<EstadosPedidos> GetEstadosPedidos()
        {
            List<EstadosPedidos> estadosPedidos = new List<EstadosPedidos>();
            DataSet db = DatosFormasIntimas.GetEstadoPedidos();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    EstadosPedidos estadoPedido = new EstadosPedidos();
                    estadoPedido.numID = row["numID"] == null ? string.Empty : row["numID"].ToString();
                    estadoPedido.strDescripcion = row["strDescripcion"] == null ? string.Empty : row["strDescripcion"].ToString();
                    estadosPedidos.Add(estadoPedido);
                }
                data.Dispose();
                db.Dispose();
            }

            return estadosPedidos;
        }


        public List<ListaPrecios> GetListaPrecios()
        {
            List<ListaPrecios> listaPrecios = new List<ListaPrecios>();
            DataSet db = DatosFormasIntimas.GetListaPrecios();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    ListaPrecios listaPrecio = new ListaPrecios();
                    listaPrecio.ID_Lista = row["ID_Lista"] == null ? string.Empty : row["ID_Lista"].ToString();
                    listaPrecio.DESC_Lista = row["DESC_Lista"] == null ? string.Empty : row["DESC_Lista"].ToString();
                    listaPrecios.Add(listaPrecio);
                }
                data.Dispose();
                db.Dispose();
            }

            return listaPrecios;
        }

        public List<ListaPreciosReferencia> GetListaPreciosReferencia()
        {
            List<ListaPreciosReferencia> listaPreciosReferencias = new List<ListaPreciosReferencia>();
            DataSet db = DatosFormasIntimas.GetListaPreciosReferencias();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    ListaPreciosReferencia listaPrecioReferencia = new ListaPreciosReferencia();
                    listaPrecioReferencia.f120_referencia = row["f120_referencia"] == null ? string.Empty : row["f120_referencia"].ToString();
                    listaPrecioReferencia.f126_id_lista_precio = row["f126_id_lista_precio"] == null ? string.Empty : row["f126_id_lista_precio"].ToString();
                    listaPrecioReferencia.f126_precio = row["f126_precio"] == null ? string.Empty : row["f126_precio"].ToString();
                    listaPreciosReferencias.Add(listaPrecioReferencia);
                }
                data.Dispose();
                db.Dispose();
            }

            return listaPreciosReferencias;
        }

        public List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();

            DataSet db = DatosFormasIntimas.GetProductos();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    Producto producto = new Producto();
                    producto.Referencia = row["Referencia"] == null ? string.Empty : row["Referencia"].ToString();
                    producto.f120_descripcion = row["f120_descripcion"] == null ? string.Empty : row["f120_descripcion"].ToString();
                    producto.f120_descripcion_corta = row["f120_descripcion_corta"] == null ? string.Empty : row["f120_descripcion_corta"].ToString();
                    productos.Add(producto);
                }
                data.Dispose();
                db.Dispose();
            }

            return productos;
        }

        public List<ProductoTalla> GetProductosTalla()
        {
            List<ProductoTalla> productosTallas = new List<ProductoTalla>();

            DataSet db = DatosFormasIntimas.GetProductosTalla();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    ProductoTalla productoTalla = new ProductoTalla();
                    productoTalla.Referencia = row["Referencia"] == null ? string.Empty : row["Referencia"].ToString();
                    productoTalla.ID_Talla = row["Talla"] == null ? string.Empty : row["Talla"].ToString();
                    productosTallas.Add(productoTalla);
                }
                data.Dispose();
                db.Dispose();
            }

            return productosTallas;
        }

        public List<ProductoColor> GetProductosColor()
        {
            List<ProductoColor> productosColor = new List<ProductoColor>();

            DataSet db = DatosFormasIntimas.GetProductosColor();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    ProductoColor productoColor = new ProductoColor();
                    productoColor.Referencia = row["Referencia"] == null ? string.Empty : row["Referencia"].ToString();
                    productoColor.ID_Color = row["Color"] == null ? string.Empty : row["Color"].ToString();
                    productosColor.Add(productoColor);
                }
                data.Dispose();
                db.Dispose();
            }

            return productosColor;
        }

        public List<Vendedor> GetVendedores()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            DataSet db = DatosFormasIntimas.GetVendedores();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    Vendedor vendedor = new Vendedor();
                    vendedor.idVendedor = row["idVendedor"] == null ? string.Empty : row["idVendedor"].ToString();
                    vendedor.Codigo = row["Codigo"] == null ? string.Empty : row["Codigo"].ToString();
                    vendedor.Documento = row["Documento"] == null ? string.Empty : row["Documento"].ToString();
                    vendedor.Nombre = row["Nombre"] == null ? string.Empty : row["Nombre"].ToString();
                    vendedor.Telefono = row["Telefono"] == null ? string.Empty : row["Telefono"].ToString();
                    vendedor.strEmail = row["strEmail"] == null ? string.Empty : row["strEmail"].ToString();
                    vendedores.Add(vendedor);
                }
                data.Dispose();
                db.Dispose();
            }

            return vendedores;
        }

        public List<TipoPrenda> GetTiposPrendas()
        {
            List<TipoPrenda> tipoPrendas = new List<TipoPrenda>();
            DataSet db = DatosFormasIntimas.GetTiposPrendas();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    TipoPrenda tipoPrenda = new TipoPrenda();
                    tipoPrenda.f106_id = row["f106_id"] == null ? string.Empty : row["f106_id"].ToString();
                    tipoPrenda.f106_descripcion = row["f106_descripcion"] == null ? string.Empty : row["f106_descripcion"].ToString();
                    tipoPrendas.Add(tipoPrenda);
                }
                data.Dispose();
                db.Dispose();
            }

            return tipoPrendas;
        }

        public List<TipoPrendaReferencia> GetTiposPrendasReferencias()
        {
            List<TipoPrendaReferencia> tiposPrendasReferencias = new List<TipoPrendaReferencia>();
            DataSet db = DatosFormasIntimas.GetTiposPrendasReferencia();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    TipoPrendaReferencia tipoPrenda = new TipoPrendaReferencia();
                    tipoPrenda.f106_id = row["f106_id"] == null ? string.Empty : row["f106_id"].ToString();
                    tipoPrenda.f120_referencia = row["f120_referencia"] == null ? string.Empty : row["f120_referencia"].ToString();
                    tiposPrendasReferencias.Add(tipoPrenda);
                }
                data.Dispose();
                db.Dispose();
            }

            return tiposPrendasReferencias;
        }

        public List<Talla> GetTallas()
        {
            List<Talla> tallas = new List<Talla>();
            DataSet db = DatosFormasIntimas.GetTallas();

            if (db.Tables.Count > 0)
            {
                DataTable data = db.Tables[0];

                foreach (DataRow row in data.Rows)
                {
                    Talla talla = new Talla();
                    talla.ID_Talla = row["ID_Talla"] == null ? string.Empty : row["ID_Talla"].ToString();
                    talla.talla = row["Talla"] == null ? string.Empty : row["Talla"].ToString();
                    talla.f119_descripcion_corta = row["f119_descripcion_corta"] == null ? string.Empty : row["f119_descripcion_corta"].ToString();
                    tallas.Add(talla);
                }
                data.Dispose();
                db.Dispose();
            }

            return tallas;
        }

        public List<EncabezadoPedido> GetPedidos(List<string> codigosCrm)
        {
            return DatosFormasIntimas.GetPedidos(codigosCrm);
        }

        public void SetPedidos(List<EncabezadoPedido> pedidos)
        {
            DatosFormasIntimas.SetPedidos(pedidos);
        }
    }
}
