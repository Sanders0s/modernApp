using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace modernApp.Core.Converters
{
    public class ValueToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double valueProjection = (double)value;
            if (valueProjection < 40)
            {
                return "White";
            }
            else if (valueProjection < 70)
            {
                return "LightGray";
            }
            else
            {
                return "DarkGray";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
