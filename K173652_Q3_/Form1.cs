using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k173652_Q4;

namespace K173652_Q3_
{
    public partial class Form1 : Form
    {
        static string[] Days;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var script = ConfigurationManager.AppSettings["directorypath"];
            CommonService cs = new CommonService();
            Days = cs.GetPaths(script);
           foreach(var p in Days)
            {
                dropdownDay.Items.Add(p);
            }
        }

        private void dropdownDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            var index = dropdownDay.SelectedItem.ToString();
            CommonService cs = new CommonService();
            cs.Clear();
            CategoriesDropdown.Items.Clear();
            var categorys = cs.GetPaths(index);
            cs.getAllXmlFilePath(index);
            foreach (var p in categorys)
            {
                CategoriesDropdown.Items.Add(p.Replace(index + @"\", " "));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            CommonService cs = new CommonService();
            Table.Rows.Clear();
            int i = 0;
            foreach (var p in cs.getparseData(CategoriesDropdown.SelectedItem.ToString()))
            {
                i++;
                int index = Table.Rows.Add();
                Table.Rows[index].Cells[0].Value = i.ToString();
                Table.Rows[index].Cells[1].Value = p.script.ToString();
                Table.Rows[index].Cells[2].Value = p.price.ToString();
            }
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
