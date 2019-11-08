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

namespace Uppgift4
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

        private void mondayBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Du klickade på knappen Måndag";
        }

        private void tuesdayBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Du klickade på knappen Tisdag";
        }

        private void wednesdayBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Du klickade på knappen Onsdag";
        }

        private void thursdayBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Du klickade på knappen Torsdag";
        }

        private void fridayBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Du klickade på knappen Fredag";
        }

        private void saturdayBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Du klickade på knappen Lördag";
        }

        private void sundayBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Du klickade på knappen Söndag";
        }
    }
}

