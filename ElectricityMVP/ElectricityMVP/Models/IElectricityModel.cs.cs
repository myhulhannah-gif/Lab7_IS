using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMVP.Models
{
    public interface IElectricityModel
    {
        double Power { get; set; }
        double Hours { get; set; }
        double Tariff { get; set; }

        double CalculateCost();
    }
}
