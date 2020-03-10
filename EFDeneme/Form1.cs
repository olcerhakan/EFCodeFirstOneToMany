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
            ListProducts();
            ListCategories();

        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex != -1)
            {
                Category cat = (Category)lstCategories.SelectedItem;
                lstCategoryProducts.DataSource = cat.Products;
                lstCategoryProducts.DisplayMember = "ProductNameWithPrice";
                lblProductsIn.Text = "Products in " + cat.CategoryName;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            if (categoryName == "")
            {
                MessageBox.Show("Please enter a category name !");
                return;
            }

            if (categoryEdited ==null)
            {

                db.Categories.Add(new Category { CategoryName = categoryName });
                db.SaveChanges();
                txtCategoryName.Clear();
                ListCategories();

            }
            else
            {
                categoryEdited.CategoryName = categoryName;
                db.SaveChanges();
                ListCategories();
                ResetCategoryForm();
            }


        }

        private void ListProducts()
        {
            lstProducts.DataSource = db.Products.ToList();
        }

        private void ListCategories()
        {
            lstCategories.DataSource = db.Categories.Include("Products").ToList();
        }

        private void lstCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstCategories.SelectedIndex > -1)
            {
                Category cat = (Category)lstCategories.SelectedItem;
                db.Categories.Remove(cat);
                db.SaveChanges();
                ListCategories();
                ListProducts();
            }
        }

        Category categoryEdited = null;
        private void lstCategories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstCategories.IndexFromPoint(e.Location);
            MessageBox.Show(index.ToString());

            if (index > -1)
            {
                categoryEdited = (Category)lstCategories.SelectedItem;
                txtCategoryName.Text = categoryEdited.CategoryName;
                btnCancelCategory.Show();
                btnAddCategory.Text = "Save";
                txtCategoryName.Focus();
            }

        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            ResetCategoryForm();
        }

        private void ResetCategoryForm()
        {
            txtCategoryName.Clear();
            btnAddCategory.Text = "Add";
            categoryEdited = null;
            btnCancelCategory.Hide();
            txtCategoryName.Focus();
        }
    }
}
