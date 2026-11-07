using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMVP.Views
{
    public interface IElectricityView
    {
        void ShowCost(double cost);
        void ShowError(string message);
    }
}
