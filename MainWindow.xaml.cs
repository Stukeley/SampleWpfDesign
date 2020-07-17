using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace SampleDesign
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ExitButton_MouseEnter(object sender, MouseEventArgs e)
		{
			ExitButton.Foreground = new SolidColorBrush(Colors.Black);
		}

		private void ExitButton_MouseLeave(object sender, MouseEventArgs e)
		{
			// #1B2845
			ExitButton.Foreground = new SolidColorBrush(Color.FromRgb(11, 16, 27));
		}

		private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonCloseMenu.Visibility = Visibility.Collapsed;
			ButtonOpenMenu.Visibility = Visibility.Visible;
		}

		private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonOpenMenu.Visibility = Visibility.Collapsed;
			ButtonCloseMenu.Visibility = Visibility.Visible;
		}

		// ! Events responsible for the menu items (changing content)

		private void Homepage_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

		}

		private void Books_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

		}

		private void Authors_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

		}

		private void Contact_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

		}

		private void Account_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

		}

		private void LogOut_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

		}

		// ! End menu events

		private void DragableTop_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
