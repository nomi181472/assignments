using k173652_Q4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace k173652_Q4.Controllers
{
    public class CategoryController : Controller
    {

        static string lastCat="";
        static int Counter = 10;
       
        // GET: test
        public ActionResult Index(string Day)
        {
            if (Day != null)
            {
                CommonService cs = new CommonService();
                ViewBag.Category = cs.GetDropDownDay(Day,"cat");
               cs.getAllXmlFilePath(Day);

            }

            return View();
        }
        [HttpPost]
        public string ShowData(string Category)
        {
            if (Category != "")
            {
                if (lastCat == "")
                {

                    lastCat = Category;

                }
                else if (Category != lastCat)
                {
                    Counter = 10;
                    lastCat = Category;
                }
                else
                {
                    Counter += 10;
                }
                string table = "<table> <tr><th>No. </th><th> script </th><th> price </th> </tr>";

                CommonService cs = new CommonService();
                int j = 0;
                var obj = cs.getparseData(Category);
                ViewBag.count = obj.Count - Counter;
                foreach (var i in obj)
                {
                    j++;
                    table = table + " <tr><td> " + j + " </td><td> " + i.script + " </td><td> " + i.price + " </td></tr>";
                    if (Counter == j)
                        break;
                }
                table = table + "</table>";

                return table;
            }
            else
            {
                return "Category is not selected";
            }
            


            



        }
    }
}