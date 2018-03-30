using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using BidirectionalBinding;

namespace BidirectionalBindingDemo
{

    class IntToStringClrConverter : IClrValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, out bool success)
        {
            if (value == null)
            {
                success = false;
                return string.Empty;
            }

            success = false;
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, out bool success)
        {
            if (string.IsNullOrWhiteSpace(value?.ToString()))
            {
                success = false;
                return int.MinValue;
            }

            if (int.TryParse(value.ToString(), out int result))
            {
                success = true;
                return result;
            }
            else
            {
                success = false;
                return int.MinValue;
            }

        }
    }

    class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(value?.ToString()))
            {
                return 0;
            }

            if (int.TryParse(value.ToString(), out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }


}
