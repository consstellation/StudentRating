using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1.Classes
{
    class ConvertPoints : IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr, CultureInfo culture)
        {
            int isActive = int.Parse(value.ToString());
            string b = null;


         
            if (isActive < 20)
                 b = "2";

            if (isActive > 20 && isActive < 50)
                b = "3";

            if (isActive > 50 && isActive < 80)
                b = "4";

            if (isActive > 80)
                b = "5";

            return b;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
