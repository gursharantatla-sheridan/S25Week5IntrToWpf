﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S25Week5IntrToWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            var result = MessageBox.Show("Hello " + name, "Message", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
                MessageBox.Show("YES clicked");
            else
                MessageBox.Show("NO clicked");
        }

        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtName.Background = Brushes.LightBlue;
        }

        private void txtName_LostFocus(object sender, RoutedEventArgs e)
        {
            txtName.Background = Brushes.White;
        }
    }
}