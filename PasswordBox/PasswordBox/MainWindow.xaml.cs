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
        int max = 0;
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

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            change_count.Content = passwordBox.Password.Length.ToString();
        }

        
        private void MaxLengt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MaxLengt.Text == String.Empty)
            {
                max = 0;
                CurrentMax.Content = "Enter Max";
            }
            else { CurrentMax.Content = MaxLengt.Text; max = Convert.ToInt32(MaxLengt.Text); }
            passwordBox.MaxLength = max;
        }

        private void MaxLengt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
