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
        public TemplateMetadata metadata { get; set; }
        public TemplateSpec spec { get; set; }
    }

    public class TemplateMetadata
    {
        public TemplateLabels labels { get; set; }
    }

    public class TemplateLabels
    {
        public string app { get; set; }
        public string name { get; set; }
    }

    public class TemplateSpec
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

