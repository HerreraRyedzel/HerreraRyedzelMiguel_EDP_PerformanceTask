namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    public partial class Form1 : Form
    {
        Products products; 
        public Form1()
        {
            InitializeComponent();
            products = new Products();
        }

        private void VIewProductBtn_Click(object sender, EventArgs e)
        {
            products.ShowDialog();
        }

        private void ViewOrderBtn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders(products);
            orders.ShowDialog();
        }
    }
}
