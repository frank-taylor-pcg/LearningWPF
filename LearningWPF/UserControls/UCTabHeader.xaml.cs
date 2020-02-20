using System.Windows;
using System.Windows.Controls;

namespace LearningWPF.UserControls
{
	/// <summary>
	/// Interaction logic for UCTabHeader.xaml
	/// </summary>
	public partial class UCTabHeader : UserControl
	{
		public string Header
		{
			get { return (string)GetValue(HeaderProperty); }
			set { SetValue(HeaderProperty, value); }
		}
		public static readonly DependencyProperty HeaderProperty =
				DependencyProperty.Register("Header", typeof(string), typeof(UCTabHeader), new PropertyMetadata(string.Empty));

		public int AlertCount
		{
			get { return (int)GetValue(AlertCountProperty); }
			set { SetValue(AlertCountProperty, value); }
		}
		public static readonly DependencyProperty AlertCountProperty =
				DependencyProperty.Register("AlertCount", typeof(int), typeof(UCTabHeader), new PropertyMetadata(0));

		public UCTabHeader()
		{
			InitializeComponent();
		}
	}
}
