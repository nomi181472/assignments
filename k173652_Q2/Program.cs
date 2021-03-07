using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using HtmlAgilityPack;
namespace k173652_Q2
{
    class Program
    {
        static List<string> GenerateCategories(HtmlNodeCollection cat)
        {
            List<string> name = new List<string>();
          
            
                foreach (var i in cat.Nodes())
                {
                    name.Add( i.InnerText);
               
                }
           
            return name;
        }

        static List<string> GenerateColumns(string col)
        {

            var columns = new List<string>();
            string str = "";

            for (int i = 0; i < col.Length; i++)
            {
                if (Char.IsWhiteSpace(col[i]))
                {
                    if (str != "")
                    {
                        columns.Add(str);

                        str = "";
                    }

                }
                else
                {
                    str += col[i];
                }

            }
            return columns;
        }
        static void Func(string filePath)
        {

            var document = new HtmlDocument();
            document.Load(filePath);

            var node = document.DocumentNode.SelectSingleNode("//div[@class='table-responsive']/table/tr");
            var cat = document.DocumentNode.SelectNodes("//div[@class='table-responsive']/table/thead/tr/th/h4");
            var columns = GenerateColumns(node.InnerText.ToString().ToLower());
            var categories = GenerateCategories(cat);
            Console.WriteLine(categories);
            foreach(var aa in categories)
            {
                Console.WriteLine(aa);
            }
            List<string> name = new List<string>();
            List<string> temp = new List<string>();
            Dictionary <string,List<double>> nameAndValues = new Dictionary<string, List<double>>();
            var ForFOlder = document.DocumentNode.SelectNodes("//div[@class='table-responsive']/table/tr/td");
            List<double> values = new List<double>();
            List<List<double>> listofValues = new List<List<double>>();
            if (ForFOlder != null)
            {
                int j = 0;
               
                foreach (var i in ForFOlder.Nodes())
                {
                    double dou=0;
                    j++;
                    if ((Double.TryParse(i.InnerHtml, out dou)))
                    {
                        values.Add(dou);
                    }
                    else
                    {

                        if (columns.Contains(i.InnerText.ToLower())==false && (i.InnerText.All(c=>Char.IsWhiteSpace(c))==false))
                        {
                            //name.Add(i.InnerText);
                            nameAndValues.Add(i.InnerText.ToLower(), values);
                            //listofValues.Add(values);
                            values.Clear();
                            //Console.WriteLine("\n" + (j - columns.Count - 1) % 10 + " value: " + i.InnerHtml);
                        }
                      
                    }
                  
                      

                }
            }

           
          
            /*
          //Console.WriteLine(node.Nodes().);
          var ForFOlder = document.ocumentNode.SelectNodes("//div[@class='table-responsive']/table/thead/tr/th/h4");
           if (ForFOlder != null)
           {
               foreach (var i in ForFOlder.Nodes())
               {
                   Console.WriteLine("\nName: "+ i.InnerText);
               }
           }

          /* foreach (var n in node)
           {
               var sibling = n.NextSibling;

               while (sibling != null)
               {
                   if (sibling.NodeType == HtmlNodeType.Element)
                       if (sibling.Name == "div")
                       {
                           foreach (var i in sibling.GetClasses())
                           {
                               Console.WriteLine(i+"Name:"+ sibling.InnerText);
                           }
                       }

                   sibling = sibling.NextSibling;
               }
           }*/

        }

        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                Func(args[0]);
            }
            else
            {
                Console.WriteLine("please provide directory where the file was stored by Q1");
            }
        }
    }
}

    





