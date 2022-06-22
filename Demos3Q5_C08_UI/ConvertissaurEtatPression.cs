using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Demos3Q5_C08_UI
{
    public class ConvertissaurEtatPression : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int noteSurCent = (int)value;
            int etatPression;
            if (noteSurCent >= 90)
                etatPression = 2;
            else if (noteSurCent >= 75)
                etatPression = 1;
            else
                etatPression = 0;
            return etatPression;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
