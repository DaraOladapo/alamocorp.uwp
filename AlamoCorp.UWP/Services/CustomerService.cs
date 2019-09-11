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
    public class CustomerService
    {
        public static async Task<Customer> CreateCustomer(Customer customer)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var uri = new Uri($"{ServiceConstants.CustomersURL}/createCustomer");
                string jsonTransport = JsonConvert.SerializeObject(customer);
                var jsonPayload = new StringContent(jsonTransport, Encoding.UTF8, "application/json");
                var httpResponse = await httpClient.PostAsync(uri, jsonPayload);
                var Customer = JsonConvert.DeserializeObject<Customer>(await httpResponse.Content.ReadAsStringAsync());
                return Customer;
            }
        }
        public static async Task<List<Customer>> GetCustomersAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetStringAsync(new Uri($"{ServiceConstants.CustomersURL}/getCustomers"));
                var Customers = JsonConvert.DeserializeObject<List<Customer>>(httpResponse);
                return Customers;
            }
        }
        public static async Task<Customer> GetCustomer(long CustomerID)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetStringAsync(new Uri($"{ServiceConstants.CustomersURL}/getCustomer/{CustomerID}"));
                var Customer = JsonConvert.DeserializeObject<Customer>(httpResponse);
                return Customer;
            }
        }
    }
}
