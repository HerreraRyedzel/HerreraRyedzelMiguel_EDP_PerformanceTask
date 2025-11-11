using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    public partial class RemoveFoods : Form
    {
        Products products;

        public string removeFoodName;
        public RemoveFoods(Products product)
        {
            InitializeComponent();
            this.products = product;
        }

        private void RemoveFoodsBtn_Click(object sender, EventArgs e)
        {
            removeFoodName = RemoveFood.Text;

            if(string.IsNullOrWhiteSpace(removeFoodName))
            {
                RemoveResultFood.Text = "Please enter a food name to remove.";
                return;
            }
            if (products.FoodTable.ContainsKey(removeFoodName))
            {
                products.FoodTable.Remove(removeFoodName);
                products.FoodsList();
                RemoveResultFood.Text = $"{removeFoodName} has been removed from the list.";
            }
            else
            {
                RemoveResultFood.Text = $"{removeFoodName} does not exist in the list.";
            }
        }
    }
}
