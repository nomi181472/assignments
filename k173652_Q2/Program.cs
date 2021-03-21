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

             
            string path = @"d:\Assignment1\Summary08Mar21.html";
            ParseData obj = new ParseData();
            obj.FileParseAndRead(path);
            obj.StartParsing();
            
            
        }
    }
}

    





