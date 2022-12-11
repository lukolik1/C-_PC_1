using System.Diagnostics;
using System.Windows;
using Персональный_компьютер;

using System;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PC pC = new PC();
            pC.Disck();
        }
    }
}
