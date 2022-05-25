using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes_GUI.Models
{
    public class Deplayment
    {
        public string apiVersion { get; set; }
        public string kind { get; set; }
        public Metadata metadata { get; set; }
        public Spec spec { get; set; }
    }

    public class Metadata
    {
        public string name { get; set; }
        public Labels labels { get; set; }
    }

    public class Labels
    {
        public string app { get; set; }
        public string name { get; set; }
    }

    public class Spec
    {
        public int replicas { get; set; }
        public Selector selector { get; set; }
        public Template template { get; set; }
    }

    public class Selector
    {
        public Matchlabels matchLabels { get; set; }
    }

    public class Matchlabels
    {
        public string app { get; set; }
    }

    public class Template
    {
        public Metadata1 metadata { get; set; }
        public Spec1 spec { get; set; }
    }

    public class Metadata1
    {
        public Labels1 labels { get; set; }
    }

    public class Labels1
    {
        public string app { get; set; }
        public string name { get; set; }
    }

    public class Spec1
    {
        public Container[] containers { get; set; }
    }

    public class Container
    {
        public string name { get; set; }
        public string image { get; set; }
        public Port[] ports { get; set; }
    }

    public class Port
    {
        public int containerPort { get; set; }
    }

}

