using LearningWPF.Data;
using System.Windows;
using System.Windows.Controls;

namespace LearningWPF.UserControls
{
	/// <summary>
	/// Interaction logic for UCClassroomStatusTracker.xaml
	/// </summary>
	public partial class UCClassroomStatusTracker : UserControl
	{
		#region DEPENDENCY PROPERTIES

		public ClassroomCollection Classrooms
		{
			get { return (ClassroomCollection)GetValue(ClassroomsProperty); }
			set { SetValue(ClassroomsProperty, value); }
		}
		public static readonly DependencyProperty ClassroomsProperty =
				DependencyProperty.Register("Classrooms", typeof(ClassroomCollection), typeof(UCClassroomStatusTracker), new PropertyMetadata(new ClassroomCollection()));

		#endregion DEPENDENCY PROPERTIES

		public UCClassroomStatusTracker()
		{
			InitializeComponent();
		}
	}
}
