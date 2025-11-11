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
    public partial class AddDrink : Form
    {
        Products products;
        public string drinkName;
        public string drinkPrice;
        public AddDrink(Products drink)
        {
            InitializeComponent();

            products = drink;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddDrinksBtn_Click(object sender, EventArgs e)
        {
            drinkName = AddDrinkName.Text;
            drinkPrice = DrinkPrice.Text;

            if (string.IsNullOrEmpty(drinkName) || string.IsNullOrEmpty(drinkPrice))
            {
                AddResultDrinks.Text = "Please enter a drink name/price.";
                return;
            }
            if (products.DrinkTable.ContainsKey(drinkName))
            {
                AddResultDrinks.Text = $"{drinkName} already exists in the list.";
                return;
            }
            else
            {
                products.DrinkTable.Add(drinkName, drinkPrice);
                products.DrinkList();
                AddResultDrinks.Text = $"{drinkName} has been added with a price of {drinkPrice}.";
            }
        }
    }
}
