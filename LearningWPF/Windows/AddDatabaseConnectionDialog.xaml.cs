using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LearningWPF.Windows
{
	/// <summary>
	/// Interaction logic for AddDatabaseConnectionDialog.xaml
	/// </summary>
	public partial class AddDatabaseConnectionDialog : Window
	{
		//public AddDatabaseConnectionDialog()
		//{
		//	InitializeComponent();
		//	DataContext = this;
		//}

		public AddDatabaseConnectionDialog(bool bTouchScreenEnabled)
		{
			InitializeComponent();
			DataContext = this;
			if (bTouchScreenEnabled)
			{
				Height = 2 * Height;
				Width = 2 * Width;
			}
		}
	}
}
