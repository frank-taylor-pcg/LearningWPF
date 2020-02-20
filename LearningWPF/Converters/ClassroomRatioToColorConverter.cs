using LearningWPF.Data;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace LearningWPF.Converters
{
	public class ClassroomRatioToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			SolidColorBrush result = new SolidColorBrush(Colors.Green);

			if (value is Classroom classroom)
			{
				if (classroom.Name.Equals("Total"))
				{
					result.Color = Colors.Black;
				}
				else
				{
					if (classroom.NumberOfKidsPerTeacher < classroom.NumberOfKidsPerTeacherLegallyAllowed)
					{
						result.Color = Colors.Orange;
					}

					if (classroom.NumberOfKidsPerTeacher > classroom.NumberOfKidsPerTeacherLegallyAllowed)
					{
						result.Color = Colors.Red;
					}
				}
			}

			return result;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
