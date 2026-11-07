using ElectricityMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMVC.Controllers
{
    public class ElectricityController
    {
        private readonly ElectricityBill _model;

        public ElectricityController(ElectricityBill model)
        {
            _model = model;
        }

        public bool TryCalculate(string power, string hours, string tariff, out double cost)
        {
            cost = 0;

            if (!double.TryParse(power, out double p) ||
                !double.TryParse(hours, out double h) ||
                !double.TryParse(tariff, out double t))
            {
                return false;
            }

            if (p < 0 || h < 0 || t < 0)
            {
                return false;
            }

            _model.Power = p;
            _model.Hours = h;
            _model.Tariff = t;

            cost = _model.CalculateCost();
            return true;
        }
    }
}
