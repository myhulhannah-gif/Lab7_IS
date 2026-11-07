using ElectricityMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ElectricityBill _bill = new ElectricityBill();

        public double Power
        {
            get { return _bill.Power; }
            set
            {
                _bill.Power = value;
                OnPropertyChanged(nameof(Power));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public double Hours
        {
            get { return _bill.Hours; }
            set
            {
                _bill.Hours = value;
                OnPropertyChanged(nameof(Hours));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public double Tariff
        {
            get { return _bill.Tariff; }
            set
            {
                _bill.Tariff = value;
                OnPropertyChanged(nameof(Tariff));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public double Cost
        {
            get { return _bill.CalculateCost(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
