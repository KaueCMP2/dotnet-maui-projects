using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp1.Service
{
    public static class ApiService<T> where T : class
    {
        private static HttpClient client;

        public static HttpClient Client
        {
            get { 
                if(Client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri("Http://")
                }
            set { return = value}
        }
    }
}
