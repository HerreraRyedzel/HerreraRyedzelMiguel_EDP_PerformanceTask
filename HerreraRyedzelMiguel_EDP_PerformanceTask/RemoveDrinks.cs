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
    public partial class RemoveDrinks : Form
    {
        Products products;
        public string removeDrinkName;
        public RemoveDrinks(Products product)
        {
            InitializeComponent();
            this.products = product;
        }

        private void RemoveDrinksBtn_Click(object sender, EventArgs e)
        {
            removeDrinkName = RemoveDrink.Text;
            if (string.IsNullOrWhiteSpace(RemoveDrink.Text))
            {
                RemoveResultDrinks.Text = "Please enter a drink name to remove.";
                return;
            }
            if (products.DrinkTable.ContainsKey(removeDrinkName))
            {
                removeDrinkName = RemoveDrink.Text;
                products.DrinkTable.Remove(removeDrinkName);
                products.DrinkList();
                RemoveResultDrinks.Text = $"{removeDrinkName} has been removed from the list.";
            }
            else
            {
                RemoveResultDrinks.Text = $"{removeDrinkName} does not exist in the list.";
            }
        }
    }
}
