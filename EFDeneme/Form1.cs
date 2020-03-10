using EFDeneme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDeneme
{
    public partial class Form1 : Form
    {
        PazarContext db = new PazarContext();
        public Form1()
        {
            InitializeComponent();
            lstProducts.DataSource = db.Products.ToList();
            lstCategories.DataSource = db.Categories.Include("Products").ToList();
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex != -1)
            {
                Category cat = (Category)lstCategories.SelectedItem;
                lstCategoriedProd.DataSource = cat.Products;
                lstCategoriedProd.DisplayMember = "ProductNameWithUnitPrice";
            }
        }
    }
}
