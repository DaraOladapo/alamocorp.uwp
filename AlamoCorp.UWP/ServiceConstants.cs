using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlamoCorp.UWP
{
    public class ServiceConstants
    {
        public static string ApiBaseURL = "https://alamocorpapi.azurewebsites.net/api";
        public static string ProductsURL = $"{ApiBaseURL}/products";
        public static string CustomersURL = $"{ApiBaseURL}/customers";
        public static string OrdersURL = $"{ApiBaseURL}/orders";
    }
}
