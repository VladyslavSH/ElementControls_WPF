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

namespace PasswordBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string mask;
        string buf = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buf = textBox.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = buf;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            passwordBox.Clear();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(masking.SelectedIndex == 0)
            {
                passwordBox.PasswordChar = (mask = "?")[0];
            }
            if (masking.SelectedIndex == 1)
            {
                passwordBox.PasswordChar = (mask = "$")[0];
            }
            if (masking.SelectedIndex == 2)
            {
                passwordBox.PasswordChar = (mask = "*")[0];
            }
        }
    }
}
