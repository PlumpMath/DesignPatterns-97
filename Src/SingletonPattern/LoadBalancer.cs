using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    public class LoadBalancer
    {
        private static volatile LoadBalancer _instance;
        private List<string> Servers { get; set; }
        protected LoadBalancer()
        {
            Servers = new List<string> { "Serve 1", "Serve 2", "Serve 3", "Serve 4" };
        }

        public static LoadBalancer GetInstance()
        {
            return _instance ?? (_instance = new LoadBalancer());
        }

        public string Server()
        {
            Random r = new Random();
            int random = r.Next(Servers.Count);
            return Servers[random];

        }
    }
}