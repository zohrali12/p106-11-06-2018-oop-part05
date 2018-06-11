using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop_part05_form.Model;

namespace oop_part05_form
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            foreach (var item in Entity.Categories)
            {
                categoryList.Items.Add(item.Name);
            }
        }
        
        

        private void addButton_Click(object sender, EventArgs e)
        {
            var name = productName.Text;
            var price = Convert.ToInt32(productPrice.Text);
            var category = categoryList.SelectedItem.ToString();
            var date = dateTimePicker1.Value;
            ProductController.Create(name, price, category,date);



        }

        private void showButton_Click(object sender, EventArgs e)
        {
            productListView.Text = string.Empty;
            foreach (var item in Entity.Products)
            {
                productListView.Text += item.Id + " . " + item.Name + " / "+ item.CategoryName + " / " +item.Price +" " + item.Date.ToString()+ "\r\n";
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            var name = categoryName.Text;
            var cat = new Category();
            cat.Name = name;
            Entity.Categories.Add(cat);
            categoryList.Items.Clear();
            foreach (var item in Entity.Categories)
            {
                categoryList.Items.Add(item.Name);
            }
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            productListView.Text = string.Empty;
            foreach (var Product in Entity.Products)
            {
                if (Product.CategoryName==categoryList.SelectedItem.ToString())
                {
                     productListView.Text += Product.Id + " . " + Product.Name + " / " + Product.CategoryName + " / " + Product.Price +" "+ Product.Date.ToString() + "\r\n";
                    
                }
            }
        }

        public  void Search(string name)
        {
            productListView.Text = string.Empty;
            foreach (var Product in Entity.Products)
            {
               
                if (Product.Name==tb_search.Text)
                {
                    productListView.Text += Product.Id + " . " + Product.Name + " / " + Product.CategoryName + " / " + Product.Price + " " + Product.Date.ToString() + "\r\n";
                }
            }
        }
        public void Search(int Id)
        {
            productListView.Text = string.Empty;
            foreach (var Product in Entity.Products)
            {

                if (Product.Id == Convert.ToInt32(tb_search.Text))
                {
                    productListView.Text += Product.Id + " . " + Product.Name + " / " + Product.CategoryName + " / " + Product.Price + " " + Product.Date.ToString() + "\r\n";
                }

            }
        }
        public void SortbyName()
        {

            for (int i = 0; i < Entity.Products.Count; i++)
            {
                for (int j = 0; j < Entity.Products.Count; j++)
                {
                    if (Entity.Products[i].Name.CompareTo(Entity.Products[j].Name) < 0)
                    {
                        Product oldProduct = Entity.Products[i];
                        Entity.Products[i] = Entity.Products[j];
                        Entity.Products[j] = oldProduct;
                    }
                }
            }

            productListView.Text = "";
            foreach (var item in Entity.Products)
            {
                productListView.Text += item.Id + " . " + item.Name + " / " + item.CategoryName + " / " + item.Price + " " + item.Date.ToString() + "\r\n";
            }

        }

        public void SortbyPrice( )
        {
            List<Product> Temp = new List<Product>();
            for (int i = 0; i < Entity.Products.Count; i++)
            {
                for (int j = 0; j < Entity.Products.Count; j++)
                {
                    if (Entity.Products[i].Price > Entity.Products[j].Price)
                    {

                        Product oldProduct = Entity.Products[i];
                        Entity.Products[i]= Entity.Products[j];
                        Entity.Products[j]= oldProduct;

                    }
                }
            }
            productListView.Text = "";
            foreach (var item in Entity.Products)
            {
                productListView.Text += item.Id + " . " + item.Name + " / " + item.CategoryName + " / " + item.Price + " " + item.Date.ToString() + "\r\n";
            }
        } 
   



        private void btn_nameSort_Click(object sender, EventArgs e)
        {
            SortbyName();
        }

        private void btn_sortId_Click(object sender, EventArgs e)
        {
            SortbyPrice();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool input= int.TryParse(tb_search.Text,out int result);
            
            if (input)
            {
                Search(Convert.ToInt32(tb_search.Text));
            }
            else
            {
                Search(tb_search.Text);
            }
        }

        private void Find_by_date_Click(object sender, EventArgs e)
        {
            productListView.Text = "";
            foreach (var Product in Entity.Products)
            {

                if (Product.Date >= StartDate.Value && Product.Date <=EndDate.Value )
                {
                    productListView.Text += Product.Id + " . " + Product.Name + " / " + Product.CategoryName + " / " + Product.Price + " " + Product.Date.ToString() + "\r\n";
                }
            }
        }
    }
}
