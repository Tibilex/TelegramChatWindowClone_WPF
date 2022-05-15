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

namespace TelegramChatWindowClone_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static MainWindow _window;

        public MainWindow()
        {
            InitializeComponent();
            _window = this;
            chanelButtonData();
        }

        private void minimiseBtn_Click(object sender, RoutedEventArgs e) { this.WindowState = WindowState.Minimized; }
        private void restoreBtn_Click(object sender, RoutedEventArgs e) { this.WindowState = WindowState.Normal; }
        private void closeBtn_Click(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }
        private void windowMove(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
               MainWindow._window.DragMove();
            }
        }

        private void chanelButtonData()
        {
            
        }
    }
}
