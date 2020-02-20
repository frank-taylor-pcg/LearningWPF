using LearningWPF.Data;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LearningWPF.Converters
{
	public class ClassroomRatioToStringConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string strResult = string.Empty;

			if (value is Classroom classroom)
			{
				strResult = $"{classroom.NumberOfKidsPerTeacher}:1";
			}
			return strResult;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
