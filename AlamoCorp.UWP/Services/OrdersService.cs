using AlamoCorp.UWP.Core.Models.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlamoCorp.UWP.Services
{
    public class OrdersService
    {
        public static async Task<Order> CreateOrder(Order order)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var uri = new Uri($"{ServiceConstants.OrdersURL}/createorder");
                string jsonTransport = JsonConvert.SerializeObject(order);
                var jsonPayload = new StringContent(jsonTransport, Encoding.UTF8, "application/json");
                var httpResponse = await httpClient.PostAsync(uri, jsonPayload);
                var Order = JsonConvert.DeserializeObject<Order>(await httpResponse.Content.ReadAsStringAsync());
                return Order;
            }
        }
        public static async Task<List<Order>> GetOrdersAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetStringAsync(new Uri($"{ServiceConstants.OrdersURL}/getOrders"));
                var Orders = JsonConvert.DeserializeObject<List<Order>>(httpResponse);
                return Orders;
            }
        }
        public static async Task<Order> GetOrder(long orderID)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetStringAsync(new Uri($"{ServiceConstants.OrdersURL}/getorder/{orderID}"));
                var Order = JsonConvert.DeserializeObject<Order>(httpResponse);
                return Order;
            }
        }
    }
}