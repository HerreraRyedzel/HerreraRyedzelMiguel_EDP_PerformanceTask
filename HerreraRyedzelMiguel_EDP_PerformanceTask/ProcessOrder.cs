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
    public partial class ProcessOrder : Form
    {
        private readonly Products products;
        private readonly Orders orders;

        private decimal totalAmount;
        private static int orderCounter = 1000;
        public ProcessOrder(Products product, Orders order)
        {
            InitializeComponent();
            products = product;
            orders = order;
        }

        private void ProcessOrder_Load(object sender, EventArgs e)
        {
            TotalUpdate();
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            string item = SearchOrder.Text.Trim();
            if (string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show("Please enter an item to add.");
                return;
            }
            if (TryAddOrderItem(item))
            {
                SearchOrder.Clear();
                TryCalculateTotal();
            }
            else
            {
                MessageBox.Show("Item not found in products list.");
            }
        }

        private void RemoveOrderBtn_Click(object sender, EventArgs e)
        {
            string item = SearchOrder.Text.Trim();
            if (string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show("Please enter an item to remove.");
                return;
            }
            if (TryRemoveOrderItem(item))
            {
                MessageBox.Show($"{item} has been removed from the order list.");
            }
            else
            {
                MessageBox.Show("Item not found in order list.");
            }

            SearchOrder.Clear();
            TryCalculateTotal();

        }
        private decimal TryCalculateTotal()
        {
            totalAmount = 0;
            foreach (ListViewItem listViewItem in ProcessOrderList.Items)
            {
                string[] parts = listViewItem.Text.Split(':');

                if (parts.Length == 2 && decimal.TryParse(parts[1].Trim().TrimStart('P'), out decimal itemPrice))
                {
                    totalAmount += itemPrice;
                }
            }

            TotalOrderAmount.Text = $"P{totalAmount}";
            return totalAmount;
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (!ValidatePaymentInput(out decimal payment))
                return;

            decimal total = CalculateTotal();

            if (payment < total)
            {
                MessageBox.Show("Insufficient payment.");
                return;
            }

            decimal change = payment - total;
            ChangeAmount.Text = $"Change: P{change}";

            string orderId = GenerateOrderID();
            GenerateReceipt(payment, total, change, orderId);

            MessageBox.Show($"Payment successful!\nOrder ID: {orderId}\nReceipt has been saved.");
        }
        private bool TryAddOrderItem(string item)
        {
            if (products.FoodTable.ContainsKey(item))
            {
                string price = products.FoodTable[item].ToString();
                ProcessOrderList.Items.Add($"{item}: P{price}");
                return true;
            }

            if (products.DrinkTable.ContainsKey(item))
            {
                string price = products.DrinkTable[item].ToString();
                ProcessOrderList.Items.Add($"{item}: P{price}");
                return true;
            }

            return false;
        }
        private bool TryRemoveOrderItem(string item)
        {
            foreach (ListViewItem listViewItem in ProcessOrderList.Items)
            {
                string listItem = listViewItem.Text.Split(':')[0].Trim();

                if (string.Equals(listItem, item, StringComparison.OrdinalIgnoreCase))
                {
                    ProcessOrderList.Items.Remove(listViewItem);
                    return true;
                }
            }
            return false;
        }
        private decimal CalculateTotal()
        {
            totalAmount = 0;

            foreach (ListViewItem listViewItem in ProcessOrderList.Items)
            {
                string[] parts = listViewItem.Text.Split(':');
                if (parts.Length == 2 && decimal.TryParse(parts[1].Trim().TrimStart('P'), out decimal price))
                    totalAmount += price;
            }

            TotalOrderAmount.Text = $"P{totalAmount}";
            return totalAmount;
        }
        private void TotalUpdate()
        {
            TotalOrderAmount.Text = $"P{CalculateTotal()}";
        }
        private bool ValidatePaymentInput(out decimal payment)
        {
            payment = 0;

            if (string.IsNullOrWhiteSpace(PaymentAmount.Text))
            {
                MessageBox.Show("Please enter a payment amount.");
                return false;
            }

            if (!decimal.TryParse(PaymentAmount.Text, out payment))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
                return false;
            }

            return true;
        }
        private string GenerateOrderID()
        {
            orderCounter++;
            return $"ORD-{orderCounter}-{DateTime.Now:MMddHHmmss}";
        }
        private void GenerateReceipt(decimal payment, decimal total, decimal change, string orderId)
        {

            string receiptsDir = @"D:\Project\Text Files";


            if (!Directory.Exists(receiptsDir))
            {
                Directory.CreateDirectory(receiptsDir);
            }


            string fileName = $"Receipt_{orderId}.txt";
            string filePath = Path.Combine(receiptsDir, fileName);


            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("========== RECEIPT ==========");
                writer.WriteLine($"Order ID: {orderId}");
                writer.WriteLine($"Date: {DateTime.Now}");
                writer.WriteLine();
                writer.WriteLine("Items Ordered:");

                foreach (ListViewItem listViewItem in ProcessOrderList.Items)
                    writer.WriteLine($"- {listViewItem.Text}");

                writer.WriteLine();
                writer.WriteLine($"Total: P{total}");
                writer.WriteLine($"Payment: P{payment}");
                writer.WriteLine($"Change: P{change}");
                writer.WriteLine("=============================");
                writer.WriteLine("Thank you for your purchase!");
            }

            MessageBox.Show($"Receipt saved at:\n{filePath}", "Receipt Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void payment_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
                e.Handled = true;
        }
    }
}
