

using ClienteCafe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCafeteria.Droid.Services
{
    public class CafeteriasServices
    {
        HttpClient cliente = new HttpClient();
        public CafeteriasServices()
        {
            cliente.BaseAddress = new Uri("https://9f70-2806-108e-21-4f1f-b4e0-bb97-6034-f0ba.ngrok.io/pedidos/");
        }
        public async Task PedidoPOST(Platillo p)
        {
            var json = JsonConvert.SerializeObject(p);
            var response = await cliente.PostAsync("respuesta", new StringContent(json, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }
    }
}