using ElectricityMVC.Controllers;
using ElectricityMVC.Models;

namespace ElectricityMVC
{
    public partial class Form1 : Form
    {
        private readonly ElectricityController _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = new ElectricityController(new ElectricityBill());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_controller.TryCalculate(txtPower.Text, txtHours.Text, txtTariff.Text, out double cost))
            {
                lblResult.Text = $"Вартість: {cost:F2} грн";
            }
            else
            {
                MessageBox.Show("Введіть коректні невід'ємні числа.", "Помилка");
            }
        }
    }
}
