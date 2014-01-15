using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Com.Co.D3.Modelo;
using MySql.Data.MySqlClient;

namespace Com.Co.D3.AccesoDatos.AccesoDatosFormasIntimas
{
    public static class DatosFormasIntimas
    {
        static string connectionString = "Data Source=QBXLEA\\SQLD3;Integrated Security=True;database=dbFI;User ID=sa;Password=123;";
        static SqlConnection con = null;

        public static bool AbrirConexion()
        {
            try
            {
                if (con == null)
                {
                    con = new SqlConnection(connectionString);
                    con.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public static void CerrarConexion()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }

        public static DataSet GetClientes()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getClientes", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetClientesCriterio()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getClientesCriterios", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetProductos()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getProductos", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetProductosTalla()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getProductosTalla", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetProductosColor()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getProductosColor", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetCartera()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getCartera", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetColores()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getColores", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetEstadoPedidos()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getEstadoPedidos", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetListaPrecios()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getListaPrecios", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetListaPreciosReferencias()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getListaPreciosReferencias", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetVendedores()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getVendedores", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetVendedoresSucursal()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getVendedoresSucursal", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetTiposPrendas()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getTiposPrendas", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetTiposPrendasReferencia()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getTiposPrendasReferencias", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static DataSet GetTallas()
        {
            DataSet db = new DataSet();

            try
            {
                using (SqlCommand Query = new SqlCommand("SP_getTallas", con))
                {
                    Query.CommandType = CommandType.StoredProcedure;
                    Query.CommandTimeout = 500000;
                    SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                    SqlDa.Fill(db);
                    SqlDa.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return db;
        }

        public static List<EncabezadoPedido> GetPedidos(List<string> codigosCrm)
        {
            List<EncabezadoPedido> pedidos = new List<EncabezadoPedido>();

            try
            {
                foreach (string codigoCrm in codigosCrm)
                {
                    DataSet db = new DataSet();
                    using (SqlCommand Query = new SqlCommand("SP_getPedidos", con))
                    {
                        
                        Query.Parameters.AddWithValue("@codigoCrm", codigoCrm);
                        Query.CommandType = CommandType.StoredProcedure;
                        Query.CommandTimeout = 500000;
                        SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                        SqlDa.Fill(db);

                        if (db.Tables.Count > 0)
                        {
                            DataTable data = db.Tables[0];

                            foreach (DataRow row in data.Rows)
                            {
                                EncabezadoPedido pedido = new EncabezadoPedido();
                                pedido.idEstadoPedido = row["idEstadoPedido"] == null ? string.Empty : row["idEstadoPedido"].ToString();
                                pedido.codigoCrm = row["codigoCrm"] == null ? string.Empty : row["codigoCrm"].ToString();
                                //pedido.numPedido = row["numPedido"] == null ? string.Empty : row["numPedido"].ToString();
                                pedidos.Add(pedido);
                            }
                            data.Dispose();
                        }
                        SqlDa.Dispose();
                    }
                    db.Dispose();
                }
            }
            catch (SqlException ex)
            {
            }

            return pedidos;
        }

        public static void SetPedidos(List<EncabezadoPedido> pedidos)
        {
            try
            {
                foreach (EncabezadoPedido pedido in pedidos)
                {
                    using (SqlCommand Query = new SqlCommand("SP_setEncabezadosPedidos", con))
                    {
                        Query.Parameters.AddWithValue("@idSucursal", pedido.idSucursal);
                        Query.Parameters.AddWithValue("@idCliente", pedido.idCliente);
                        string idListaPrecios = string.IsNullOrEmpty(pedido.idListadePrecios) ? "01" : pedido.idListadePrecios;
                        Query.Parameters.AddWithValue("@idListadePrecios", idListaPrecios);
                        string idMoneda = string.IsNullOrEmpty(pedido.idMoneda) ? "1" : pedido.idMoneda;
                        Query.Parameters.AddWithValue("@idMoneda", idMoneda);
                        Query.Parameters.AddWithValue("@idVendedor", pedido.idVendedor);
                        Query.Parameters.AddWithValue("@strOrdendeCompra", pedido.strOrdendeCompra);
                        Query.Parameters.AddWithValue("@strTipoOrdendeCompra", pedido.strTipoOrdendeCompra);
                        Query.Parameters.AddWithValue("@memObservaciones", pedido.memObservaciones);
                        Query.Parameters.Add("@dtmFecPedido", SqlDbType.DateTime).Value = DateTime.Parse(pedido.dtmFecPedido);
                        Query.Parameters.Add("@dtmFecEntregaInicial", SqlDbType.DateTime).Value = DateTime.Parse(pedido.dtmFecEntregaInicial);
                        Query.Parameters.Add("@dtmFecEntregaFinal", SqlDbType.DateTime).Value = DateTime.Parse(pedido.dtmFecEntregaFinal);
                        Query.Parameters.AddWithValue("@codigoCrm", pedido.codigoCrm);

                        int intCantidadPedida = 0;
                        double curValorPedido = 0;

                        foreach (DetallePedido detallePedido in pedido.detallesPedido)
                        {
                            intCantidadPedida += int.Parse(detallePedido.intCantidadPedida);
                            curValorPedido = intCantidadPedida * double.Parse(detallePedido.curPrecio);
                        }

                        Query.Parameters.AddWithValue("@intCantidadPedida", intCantidadPedida);
                        Query.Parameters.AddWithValue("@curValorPedido", curValorPedido);
                        Query.CommandType = CommandType.StoredProcedure;
                        Query.CommandTimeout = 500000;

                        int numPedido = (int)Query.ExecuteScalar();

                        foreach (DetallePedido detallePedido in pedido.detallesPedido)
                        {
                            using (SqlCommand queryDetallePedido = new SqlCommand("SP_setPedidoDetalles", con))
                            {
                                queryDetallePedido.Parameters.AddWithValue("@numPedido", numPedido);
                                queryDetallePedido.Parameters.AddWithValue("@idSucursal", detallePedido.idSucursal);
                                queryDetallePedido.Parameters.AddWithValue("@idVendedor", detallePedido.idVendedor);
                                queryDetallePedido.Parameters.AddWithValue("@strReferencia", detallePedido.strReferencia);
                                queryDetallePedido.Parameters.AddWithValue("@curPrecio", detallePedido.curPrecio);
                                queryDetallePedido.Parameters.AddWithValue("@intCantidadPedida", detallePedido.intCantidadPedida);
                                string intConujunto = string.IsNullOrEmpty(detallePedido.intConjunto) ? "0" : detallePedido.intConjunto;
                                queryDetallePedido.Parameters.AddWithValue("@intConjunto", intConujunto);
                                queryDetallePedido.Parameters.AddWithValue("@strColor", detallePedido.strColor);
                                queryDetallePedido.Parameters.AddWithValue("@strTalla", detallePedido.strTalla);
                                queryDetallePedido.Parameters.Add("@dtmFecCreacion", SqlDbType.DateTime).Value = DateTime.Parse(detallePedido.dtmFecCreacion);

                                queryDetallePedido.CommandType = CommandType.StoredProcedure;

                                queryDetallePedido.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
            }
        }
    }
}
