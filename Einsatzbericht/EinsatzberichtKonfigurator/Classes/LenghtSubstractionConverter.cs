using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Data;

namespace EinsatzberichtKonfigurator.Classes
{
    [ValueConversion(typeof(double), typeof(double), ParameterType = typeof(double))]
    internal class LenghtSubstractionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (double.TryParse(value.ToString(), out double length)
                && double.TryParse(parameter.ToString(), out double margin))
                return length - margin;
            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
