using k173652_Q4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace k173652_Q4
{
    public class CommonService
    {
        static Dictionary<string, List<Scripts>> AllData = new Dictionary<string, List<Scripts>>();
        public string[] GetPaths(string script)
        {
            return Directory.GetDirectories(script);
        }
        public List<SelectListItem> GetDropDownDay(string script,string cat="")
        {
            string[] subdirs = GetPaths(script);
            List<SelectListItem> day = new List<SelectListItem>();
            foreach (var sub in subdirs)
            {
                string Val = sub;
                if (cat!="")
                {
                    Val = sub.Replace(script + @"\", " ");
                }

                day.Add(new SelectListItem { Text = sub.Replace(script + @"\", " "), Value = Val });

            }
            return day;

        }
        public List<Scripts>  Deserialize( string path)
        {
            List<Scripts> list = new List<Scripts>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Scripts>));
            StreamReader reader = new StreamReader(path);
            list= (List<Scripts>)serializer.Deserialize(reader);
            reader.Close();
            return list;
        }
            public void getAllXmlFilePath(string path)
        {
            string[] subdirs = GetPaths(path);
            List<string> AllPath = new List<string>();
            foreach (var i in subdirs)
            {
                string xmlFile = i.Replace(path + @"\", "");
                xmlFile = i + @"\" + xmlFile+".xml";
                AllPath.Add(xmlFile);   
            }
            
            for(int i=0;i<AllPath.Count();i++) {
                string xmlFile = subdirs[i].Replace(path + @"\", "");
                AllData.Add(xmlFile, Deserialize(AllPath[i]));
            }
            

        }
        public List<Scripts> getparseData(string category)
        {
            
            return AllData[category.Replace(" ","")];
        }


    }
}