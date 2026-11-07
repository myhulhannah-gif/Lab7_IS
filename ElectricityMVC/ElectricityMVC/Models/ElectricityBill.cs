using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMVC.Models
{
    public class ElectricityBill
    {
        public double Power { get; set; }   // потужність, кВт
        public double Hours { get; set; }   // час використання, год
        public double Tariff { get; set; }  // тариф, грн за кВт·год

        public double CalculateCost()
        {
            return Power * Hours * Tariff;
        }
    }
}
