using System;
using System.Globalization;
using System.Windows.Data;

namespace DarkSoulsIIISaveConverter
{
	public class PlaytimeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo language)
		{
			int num = (int)value;
			return $"{num / 60 / 60}:{num / 60 % 60:D2}:{num % 60:D2}";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
		{
			throw new NotImplementedException();
		}
	}
}
