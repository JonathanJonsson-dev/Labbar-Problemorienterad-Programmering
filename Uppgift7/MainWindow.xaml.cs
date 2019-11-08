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

namespace Uppgift7
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
        private void summaBtn_Click(object sender, RoutedEventArgs e)
        {
            int tal1 = int.Parse(tal1TextBox.Text);
            int tal2 = int.Parse(tal2TextBox.Text);

            // dividerar tal och skickar dessa till summaTextBox
            int resultat;
            int rest;
            resultat = (tal1 / tal2);

            //resultatTextBox.Text = Math.Round(resultat, 2).ToString();
            heltalTextBox.Text = resultat.ToString();

            rest = (tal1 % tal2);
            restTextBox.Text = rest.ToString();

        }
    }
}
