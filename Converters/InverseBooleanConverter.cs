using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadsMauiBase.Converters
{
    public class InverseBooleanConverter : IValueConverter
    {
        public object? Convert(object? oValueZ, Type oTargetTypeZ, object? oParameterZ, CultureInfo oCultureZ)
        {
            if (oValueZ is bool bValue)
            {
                return !bValue;
            }
            return oValueZ;
        }

        public object? ConvertBack(object? oValueZ, Type oTargetTypeZ, object? oParameterZ, CultureInfo oCultureZ)
        {
            if (oValueZ is bool bValue)
            {
                return !bValue;
            }
            return oValueZ;
        }
    }
}
