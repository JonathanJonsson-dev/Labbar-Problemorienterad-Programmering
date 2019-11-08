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

namespace Uppgift3
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

        private void leftBtn_Click(object sender, RoutedEventArgs e)
        {
            leftBtn.Content = "Klickad";
            rightBtn.Content = "Oklickad";
        }

        private void rightBtn_Click(object sender, RoutedEventArgs e)
        {
            rightBtn.Content = "Klickad";
            leftBtn.Content = "Oklickad";
        }
    }
}

