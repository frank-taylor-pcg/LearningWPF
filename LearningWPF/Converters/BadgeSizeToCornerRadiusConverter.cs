using System;
using System.Globalization;
using System.Windows.Data;

namespace LearningWPF.Converters
{
	class BadgeSizeToCornerRadiusConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int iResult = 0;
			if (value is int iValue)
			{
				iResult = iValue / 2;
			}
			return iResult;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
