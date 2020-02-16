using System;
using System.Globalization;
using System.Windows.Data;

namespace NetworkLocationEditor.Util
{
    class NetworkCategoryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((int)value)
            {
                case 0:
                    return "公用网络";
                case 1:
                    return "专用网络";
                default:
                    return "未知";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == "专用网络" ? 1 : 0;
        }

    }
}
