using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using HtmlAgilityPack;
namespace k173652_Q2
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //var script = ConfigurationManager.AppSettings["directorypath"];
           
            ParseData obj = new ParseData();
           // obj.FileParseAndRead();
            obj.StartParsing();
            
            
        }
    }
}

    





