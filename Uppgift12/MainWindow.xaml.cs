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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double[] values = new double[5];
            
            listBoxValues.ItemsSource = null;
            listBoxValues.ItemsSource = values;

        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(inmatningTextbox.Text);

            for (int i = 0; i < length; i++)
            {
                if (values[i] == 0)
                {
                    values[i] = num;
                }
            }
            
        }
    }
}
