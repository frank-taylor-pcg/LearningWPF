using System.Windows;
using System.Windows.Controls;

namespace LearningWPF.UserControls
{
	/// <summary>
	/// Interaction logic for UCBadge.xaml
	/// </summary>
	public partial class UCBadge : UserControl
	{
		public int AlertCount
		{
			get { return (int)GetValue(AlertCountProperty); }
			set { SetValue(AlertCountProperty, value); }
		}
		public static readonly DependencyProperty AlertCountProperty =
				DependencyProperty.Register("AlertCount", typeof(int), typeof(UCBadge), new PropertyMetadata(0));

		public int Size
		{
			get { return (int)GetValue(SizeProperty); }
			set { SetValue(SizeProperty, value); }
		}
		public static readonly DependencyProperty SizeProperty =
				DependencyProperty.Register("Size", typeof(int), typeof(UCBadge), new PropertyMetadata(30));

		public UCBadge()
		{
			InitializeComponent();
		}
	}
}
