using LearningWPF.Data;
using LearningWPF.Windows;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace LearningWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//public ObservableCollection<Classroom> Classrooms
		//{
		//	get { return (ObservableCollection<Classroom>)GetValue(ClassroomsProperty); }
		//	set { SetValue(ClassroomsProperty, value); }
		//}
		//public static readonly DependencyProperty ClassroomsProperty =
		//		DependencyProperty.Register("Classrooms", typeof(ObservableCollection<Classroom>), typeof(MainWindow), new PropertyMetadata(new ObservableCollection<Classroom>()));

		public ClassroomCollection Classrooms
		{
			get { return (ClassroomCollection)GetValue(ClassroomsProperty); }
			set { SetValue(ClassroomsProperty, value); }
		}
		public static readonly DependencyProperty ClassroomsProperty =
				DependencyProperty.Register("Classrooms", typeof(ClassroomCollection), typeof(MainWindow), new PropertyMetadata(new ClassroomCollection()));

		public MainWindow()
		{
			TestData();
			InitializeComponent();
		}

		private void TestData()
		{
			Classrooms.Add(new Classroom()
			{
				Name = "Caterpillar",
				NumberOfKids = 10,
				NumberOfKidsExpected = 12,
				NumberOfTeachers = 6,
				NumberOfTeachersExpected = 3,
				NumberOfKidsPerTeacherLegallyAllowed = 4
			});
			Classrooms.Add(new Classroom()
			{
				Name = "Butterfly",
				NumberOfKids = 4,
				NumberOfKidsExpected = 12,
				NumberOfTeachers = 1,
				NumberOfTeachersExpected = 3,
				NumberOfKidsPerTeacherLegallyAllowed = 4
			});
			Classrooms.Add(new Classroom()
			{
				Name = "Grasshopper",
				NumberOfKids = 11,
				NumberOfKidsExpected = 12,
				NumberOfTeachers = 2,
				NumberOfTeachersExpected = 3,
				NumberOfKidsPerTeacherLegallyAllowed = 4
			});
			Classrooms.Add(new Classroom()
			{
				Name = "Screamers",
				NumberOfKids = 27,
				NumberOfKidsExpected = 8,
				NumberOfTeachers = 1,
				NumberOfTeachersExpected = 2,
				NumberOfKidsPerTeacherLegallyAllowed = 4
			});
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			AddDatabaseConnectionDialog addDatabaseConnectionDialog = new AddDatabaseConnectionDialog((bool)cbTouchScreenEnabled.IsChecked);
			addDatabaseConnectionDialog.Show();
		}
	}
}
