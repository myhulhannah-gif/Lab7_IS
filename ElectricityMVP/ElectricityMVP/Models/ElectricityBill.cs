using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMVP.Models
{
    public class ElectricityBill : IElectricityModel
    {
        public double Power { get; set; }
        public double Hours { get; set; }
        public double Tariff { get; set; }

        public double CalculateCost()
        {
            return Power * Hours * Tariff;
        }
    }
}
