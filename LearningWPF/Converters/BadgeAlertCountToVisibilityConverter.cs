using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LearningWPF.Converters
{
	public class BadgeAlertCountToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Visibility visibility = Visibility.Visible;
			if (value is int alertCount)
			{
				if (alertCount == 0)
				{
					visibility = Visibility.Collapsed;
				}
			}
			return visibility;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
