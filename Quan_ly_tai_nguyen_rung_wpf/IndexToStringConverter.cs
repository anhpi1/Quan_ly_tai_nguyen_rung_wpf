using System;
using System.Globalization;
using System.Windows.Data;

public class IndexToStringConverter : IValueConverter
{
    // Hàm Convert để chuyển đổi index thành STT (bắt đầu từ 1)
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int index)
        {
            // Trả về số thứ tự bắt đầu từ 1
            return (index + 1).ToString();
        }
        return value;
    }

    // Hàm ConvertBack không cần thiết trong trường hợp này
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value; // Không sử dụng ConvertBack
    }
}
