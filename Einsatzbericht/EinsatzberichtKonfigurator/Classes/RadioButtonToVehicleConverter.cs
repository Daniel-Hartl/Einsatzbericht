namespace EinsatzberichtKonfigurator.Classes;

using Model;
using Model.enums;
using System;
using System.Globalization;
using System.Windows.Data;

[ValueConversion(typeof(bool), typeof(Vehicle), ParameterType = typeof(Vehicle))]
internal class RadioButtonToVehicleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Firefighter firefighter && parameter is Vehicle vehicle)
            return vehicle == firefighter.Vehicle;

        throw new NotSupportedException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
