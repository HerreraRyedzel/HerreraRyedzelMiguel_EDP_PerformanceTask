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
    public partial class Products : Form
    {
        public Hashtable FoodTable;
        ICollection foodCollectionKeys;
        ICollection foodCollectionValue;

        public Hashtable DrinkTable;
        ICollection drinkCollectionKeys;
        ICollection drinkCollectionValue;

        
        public Products()
        {
            InitializeComponent();
            FoodTable = new Hashtable();
            DrinkTable = new Hashtable(); 
        }

        private void AddFoodBtn_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(this);
            addFood.ShowDialog();
        }

        private void RemoveFoodBtn_Click(object sender, EventArgs e)
        {
            RemoveFoods removeFoods = new RemoveFoods(this);
            removeFoods.ShowDialog();
        }

        private void AddDrinkBtn_Click(object sender, EventArgs e)
        {
           AddDrink addDrink = new AddDrink(this);
            addDrink.ShowDialog();
        }

        private void RemoveDrinkBtn_Click(object sender, EventArgs e)
        {
            RemoveDrinks removeDrinks = new RemoveDrinks(this);
            removeDrinks.ShowDialog();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            FoodsList();
            DrinkList();
        }

        public void FoodsList()
        {
           FoodListView.Items.Clear();

            foreach (DictionaryEntry foodData in FoodTable)
            {
                string food = foodData.Key.ToString();
                string price = foodData.Value.ToString();
            }

        }
        public void DrinkList()
        {
            DrinkListView.Items.Clear();
            foreach (DictionaryEntry drinkData in DrinkTable)
            {
                string drink = drinkData.Key.ToString();
                string price = drinkData.Value.ToString();
            }
        }
    }
}
