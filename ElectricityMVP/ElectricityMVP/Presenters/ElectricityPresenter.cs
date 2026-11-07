using ElectricityMVP.Models;
using ElectricityMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMVP.Presenters
{
    public class ElectricityPresenter
    {
        private readonly IElectricityView _view;
        private readonly IElectricityModel _model;

        public ElectricityPresenter(IElectricityView view, IElectricityModel model)
        {
            _view = view;
            _model = model;
        }

        public void Calculate(string power, string hours, string tariff)
        {
            if (!double.TryParse(power, out double p) ||
                !double.TryParse(hours, out double h) ||
                !double.TryParse(tariff, out double t) ||
                p < 0 || h < 0 || t < 0)
            {
                _view.ShowError("Введіть коректні невід'ємні числа.");
                return;
            }

            _model.Power = p;
            _model.Hours = h;
            _model.Tariff = t;

            _view.ShowCost(_model.CalculateCost());
        }
    }
}
