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
    public partial class AddFood : Form
    {
        Products products;
        public string foodName;
        public string foodPrice;
        public AddFood(Products food)
        {
            InitializeComponent();
            products = food;
        }

        private void AddFoodsBtn_Click(object sender, EventArgs e)
        {
            foodName = AddFoodName.Text;
            foodPrice = FoodPrice.Text;

            if(string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(foodPrice))
            {
                AddResultFood.Text = "Please enter a food name/price.";
                return;
            }
            if (products.FoodTable.ContainsKey(foodName))
            {
                AddResultFood.Text = $"{foodName} already exists in the list.";
                return;
            }
            else
            {
                products.FoodTable.Add(foodName, foodPrice);
                products.FoodsList();
                AddResultFood.Text = $"{foodName} has been added with a price of {foodPrice}.";
            }
        }
    }
}
