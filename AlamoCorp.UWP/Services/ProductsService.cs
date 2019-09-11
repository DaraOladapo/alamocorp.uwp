using AlamoCorp.UWP.Core.Models.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlamoCorp.UWP.Services
{
    internal class ProductsService
    {
        public static async Task<List<Product>> GetProductsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetStringAsync(new Uri($"{ServiceConstants.ProductsURL}/getproducts"));
                var Products = JsonConvert.DeserializeObject<List<Product>>(httpResponse);
                return Products;
            }
        }
        public static async Task<IEnumerable<Product>> AddProduct(Product product)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var uri = new Uri($"{ServiceConstants.OrdersURL}/addproduct");
                string jsonTransport = JsonConvert.SerializeObject(product);
                var jsonPayload = new StringContent(jsonTransport, Encoding.UTF8, "application/json");
                var httpResponse = await httpClient.PostAsync(uri, jsonPayload);
                var Products = JsonConvert.DeserializeObject<IEnumerable<Product>>(await httpResponse.Content.ReadAsStringAsync());
                return Products;
            }
        }
    }
}
