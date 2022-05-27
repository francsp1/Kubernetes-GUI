using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes_GUI.Models
{

    public class Service
    {
        public string apiVersion { get; set; }
        public string kind { get; set; }
        public ServiceMetadata metadata { get; set; }
        public ServiceSpec spec { get; set; }
    }

    public class ServiceMetadata
    {
        public string name { get; set; }
    }

    public class ServiceSpec
    {
        public ServiceSpecSelector selector { get; set; }
        public ServiceSpecPort[] ports { get; set; }
    }

    public class ServiceSpecSelector
    {
        public string app { get; set; }
    }

    public class ServiceSpecPort
    {
        public string protocol { get; set; }
        public int port { get; set; }
        public int targetPort { get; set; }
    }

}
