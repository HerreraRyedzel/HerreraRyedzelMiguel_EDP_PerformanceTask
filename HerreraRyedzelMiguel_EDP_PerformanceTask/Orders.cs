using System;
using System.Collections;
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
    public partial class Orders : Form
    {
        Products products;
        ProcessOrder processOrder;

        string drink;
        string foodPrice;

        string food;
        string drinkPrice;
        public Orders(Products product, ProcessOrder process = null)
        {
            InitializeComponent();
            products = product;
            processOrder = process;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            DisplayFoodOrder();
            DisplayDrinkOrder();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if(processOrder == null)
            {
                processOrder = new ProcessOrder(products ,this);
            }
            processOrder.ShowDialog();
        }

        private void DisplayFoodOrder()
        {
            FoodList.Items.Clear();
            foreach (DictionaryEntry foodData in products.FoodTable)
            {
                food = foodData.Key.ToString();
                foodPrice = foodData.Value.ToString();
                FoodList.Items.Add($"{food}: P{foodPrice}");
            }
        }
        private void DisplayDrinkOrder()
        {
            FoodList.Items.Clear();
            foreach (DictionaryEntry drinkData in products.DrinkTable)
            {
                drink = drinkData.Key.ToString();
                drinkPrice = drinkData.Value.ToString();
                DrinkList.Items.Add($"{drink}: P{drinkPrice}");
            }
        }
    }
}
