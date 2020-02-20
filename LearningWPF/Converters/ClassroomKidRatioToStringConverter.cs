using LearningWPF.Data;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LearningWPF.Converters
{
	public class ClassroomKidRatioToStringConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string strResult = string.Empty;

			if (value is Classroom classroom)
			{
				strResult = $"{classroom.NumberOfKids} / {classroom.NumberOfKidsExpected}";
			}
			return strResult;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
