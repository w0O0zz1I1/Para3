using Para3;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.MainFrame.Navigate(new Pages.SquareEquation());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.MainFrame.Navigate(new Pages.LineEquation());
        }
    }
}
