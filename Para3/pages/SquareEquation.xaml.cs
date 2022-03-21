using Service;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для SquareEquation.xaml
    /// </summary>
    public partial class SquareEquation : Page
    {
        public SquareEquation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// При нажатии на кнопку вычисляется корень квадратного уравнения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean a_text = double.TryParse(TextBoxA.Text.Trim(), out var a);
            Boolean b_text = double.TryParse(TextBoxB.Text.Trim(), out var b);
            Boolean c_text = double.TryParse(TextBoxC.Text.Trim(), out var c);
            if (a_text && b_text && c_text)
            {
                LabelResult.Content = Square.SquareMethod(a, b, c);
            }
            else
            {
                MessageBox.Show("Не валидные значения");
            }
        }
    }
}
