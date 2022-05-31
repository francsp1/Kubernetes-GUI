using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes_GUI.Models
{

    public static class GlobalSessionDetails
    {
        public static readonly IHttpClientFactory _clientFactory = (IHttpClientFactory)Program.ServiceProvider.GetService(typeof(IHttpClientFactory));
        public static string Protocol { get; set; } = null;
        public static string Domain { get; set; } = null;
        public static string Port { get; set; } = null;

    }


}
