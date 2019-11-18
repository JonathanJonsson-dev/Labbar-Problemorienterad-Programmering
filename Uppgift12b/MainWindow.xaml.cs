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

namespace Uppgift12b
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
        double[] values = new double[5];
        int counter = 0;

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            if (counter < 5)
            {
                values[counter] = double.Parse(inmatningTextbox.Text);
                counter++;
            }
            
            else
            {
                okBtn.IsEnabled = false;
            }

            listBoxValues.ItemsSource = null;
            listBoxValues.ItemsSource = values;
            medelvärdeTextbox.Text = values.Average().ToString();

        }

        private void nollställBtn_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(values, 0, values.Length);
            listBoxValues.ItemsSource = null;
            listBoxValues.ItemsSource = values;
            okBtn.IsEnabled = true;
            counter = 0;
            medelvärdeTextbox.Text = String.Empty;
            inmatningTextbox.Focus();
        }
    }
}
