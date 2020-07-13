using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace HelloWorldCalc
{
    class converterme : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Visibility labelmeVisibility
        {
            get => _labelmeVisibility;
            set
            {
                _labelmeVisibility = value;
                OnPropertyChanged();

            }
        }
        private Visibility _labelmeVisibility;


        protected void OnPropertyChanged(string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0].ToString().Equals("True") || !values[1].ToString().Equals("0"))
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
