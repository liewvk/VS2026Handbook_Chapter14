namespace VS2026Handbook_Chapter14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                price < 0 || quantity < 0)
            {
                MessageBox.Show("Enter a valid price and quantity.");
                return;
            }

            lblTotal.Text = $"Total: ${price * quantity:F2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

