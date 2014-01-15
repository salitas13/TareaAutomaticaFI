using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Co.D3.Modelo;
using RestSharp;
using Newtonsoft.Json;

namespace Com.Co.D3.Servicios
{
    public class ServicioCRM
    {
        public void SetClientes(List<Cliente> clientes)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (clientes != null && clientes.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < clientes.Count - 1 ? delta : clientes.Count - inicio;

                while (inicio < clientes.Count - 1)
                {
                    List<Cliente> clientesAux = clientes.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(clientesAux);

                    var request = new RestRequest("Cliente", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < clientes.Count - 1 ? delta : clientes.Count - inicio;
                }
            }
        }

        public void SetListaPrecios(List<ListaPrecios> listaPrecios)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (listaPrecios != null && listaPrecios.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < listaPrecios.Count - 1 ? delta : listaPrecios.Count  - inicio;
                while (inicio < listaPrecios.Count - 1)
                {
                    List<ListaPrecios> listaPreciosAux = listaPrecios.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(listaPreciosAux);

                    var request = new RestRequest("ListaPrecios", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < listaPrecios.Count - 1 ? delta : listaPrecios.Count  - inicio;
                }
            }
        }

        public void SetListaPreciosReferencia(List<ListaPreciosReferencia> listaPreciosReferencia)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (listaPreciosReferencia != null && listaPreciosReferencia.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < listaPreciosReferencia.Count - 1 ? delta : listaPreciosReferencia.Count - inicio;
                while (inicio < listaPreciosReferencia.Count - 1)
                {
                    List<ListaPreciosReferencia> listaPreciosReferenciaAux = listaPreciosReferencia.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(listaPreciosReferenciaAux);

                    var request = new RestRequest("ListaPreciosReferencia", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < listaPreciosReferencia.Count - 1 ? delta : listaPreciosReferencia.Count - inicio;
                }
            }
        }

        public void SetColores(List<Color> colores)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (colores != null && colores.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < colores.Count - 1 ? delta : colores.Count - inicio;
                while (inicio < colores.Count - 1)
                {
                    List<Color> coloresAux = colores.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(coloresAux);

                    var request = new RestRequest("Color", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < colores.Count - 1 ? delta : colores.Count - inicio;
                }
            }
        }
        public void SetTallas(List<Talla> tallas)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (tallas != null && tallas.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < tallas.Count - 1 ? delta : tallas.Count- inicio;
                while (inicio < tallas.Count - 1)
                {
                    List<Talla> tallasAux = tallas.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(tallasAux);

                    var request = new RestRequest("Talla", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < tallas.Count - 1 ? delta : tallas.Count - inicio;
                }
            }
        }

        public void SetProductos(List<Producto> productos)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (productos != null && productos.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < productos.Count - 1 ? delta : productos.Count - inicio;
                while (inicio < productos.Count - 1)
                {
                    List<Producto> productosAux = productos.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(productosAux);

                    var request = new RestRequest("Producto", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < productos.Count - 1 ? delta : productos.Count - inicio;
                }
            }
        }

        public void SetProductosTalla(List<ProductoTalla> productosTalla)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (productosTalla != null && productosTalla.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < productosTalla.Count - 1 ? delta : productosTalla.Count - inicio;
                while (inicio < productosTalla.Count - 1)
                {
                    List<ProductoTalla> productosAux = productosTalla.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(productosAux);

                    var request = new RestRequest("ProductoTalla", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < productosTalla.Count - 1 ? delta : productosTalla.Count - inicio;
                }
            }
        }

        public void SetProductosColor(List<ProductoColor> productosColor)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (productosColor != null && productosColor.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < productosColor.Count - 1 ? delta : productosColor.Count - inicio;
                while (inicio < productosColor.Count - 1)
                {
                    List<ProductoColor> productosAux = productosColor.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(productosAux);

                    var request = new RestRequest("ProductoColor", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < productosColor.Count - 1 ? delta : productosColor.Count - inicio;
                }
            }
        }

        public void SetTipoPrendas(List<TipoPrenda> tipoPrendas)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (tipoPrendas != null && tipoPrendas.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < tipoPrendas.Count - 1 ? delta : tipoPrendas.Count - inicio;
                while (inicio < tipoPrendas.Count - 1)
                {
                    List<TipoPrenda> tipoPrendasAux = tipoPrendas.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(tipoPrendasAux);

                    var request = new RestRequest("TiposPrenda", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < tipoPrendas.Count - 1 ? delta : tipoPrendas.Count - inicio;
                }
            }
        }

        public void SetVendedores(List<Vendedor> vendedores)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (vendedores != null && vendedores.Count > 0)
            {
                int delta = 50;
                int inicio = 0;
                delta = inicio + delta < vendedores.Count - 1 ? delta : vendedores.Count- inicio;
                while (inicio < vendedores.Count - 1)
                {
                    List<Vendedor> vendedoresAux = vendedores.GetRange(inicio, delta);
                    //Json to post 
                    string jsonToSend = JsonConvert.SerializeObject(vendedoresAux);

                    var request = new RestRequest("Vendedor", Method.POST);

                    request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    // execute the request
                    RestResponse response3 = (RestResponse)client.Execute(request);
                    var content = response3.Content; // raw content as string

                    if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                    {

                    }

                    inicio += delta;
                    delta = inicio + delta < vendedores.Count - 1 ? delta : vendedores.Count - inicio;
                }
            }
        }

        public void SetPedidos(List<EncabezadoPedido> pedidos)
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            if (pedidos != null && pedidos.Count > 0)
            {
                string jsonToSend = JsonConvert.SerializeObject(pedidos);

                var request = new RestRequest("EncabezadoPedido", Method.POST);

                request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                request.RequestFormat = DataFormat.Json;

                // execute the request
                RestResponse response3 = (RestResponse)client.Execute(request);
                var content = response3.Content; // raw content as string

                if (content.Trim().Equals("{\"valido\":true,\"errores\":[]}"))
                {

                }
            }
        }

        public List<EncabezadoPedido> GetPedidos()
        {
            var client = new RestClient("http://apps.quabox.com/formas/api");

            List<EncabezadoPedido> pedidos = new List<EncabezadoPedido>();

            var request = new RestRequest("EncabezadoPedido", Method.GET);

            // or automatically deserialize results
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            IRestResponse<List<EncabezadoPedido>> response = client.Execute<List<EncabezadoPedido>>(request);

            if (﻿response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                pedidos = JsonConvert.DeserializeObject<List<EncabezadoPedido>>(response.Content);
            }

            return pedidos;
        }
    }
}