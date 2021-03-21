using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace k173652_Q4.Models
{
    
        [XmlRoot("Root")]
        public class Scripts
        {
            [XmlElement("script")]
            public string script { get; set; }
        [XmlElement("price")]
            public double price { get; set; }

    }
    
}