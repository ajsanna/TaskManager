using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class DatePickerStringConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // Set a default date of today
            DateTime date = DateTime.Today;
            // Attempt to parse the date given
            _ = DateTime.TryParse((string)value!, out date);
            return date;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value!;
            return date.ToString("MM/dd/yyyy");
        }
    }
}
