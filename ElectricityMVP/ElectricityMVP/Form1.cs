using ElectricityMVP.Models;
using ElectricityMVP.Presenters;
using ElectricityMVP.Views;

namespace ElectricityMVP
{
    public partial class Form1 : Form, IElectricityView
    {
        private readonly ElectricityPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new ElectricityPresenter(this, new ElectricityBill());
        }

        public void ShowCost(double cost)
        {
            lblResult.Text = $"Вартість: {cost:F2} грн";
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Помилка");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _presenter.Calculate(txtPower.Text, txtHours.Text, txtTariff.Text);
        }
    }
}
