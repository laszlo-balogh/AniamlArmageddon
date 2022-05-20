using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Animal_Armageddon.Helpers
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string color = value.ToString().ToLower();
            switch (color)
            {
                case "orange":
                    return Brushes.OrangeRed;
                case "deeppink":
                    return Brushes.DeepPink;
                case "blue":
                    return Brushes.Blue;
                case "green":
                    return Brushes.OrangeRed;
                case "grey":
                    return Brushes.Gray;
                default:
                    return Brushes.OrangeRed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
