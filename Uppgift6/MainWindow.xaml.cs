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

namespace Uppgift6
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
            //Laddar in en string från tal1TextBox och konvertera string till int
            int tal1 = int.Parse(tal1TextBox.Text);
            int tal2 = int.Parse(tal2TextBox.Text);
            // summerar tal och skickar dessa till summaTextBox
            resultatTextBox.Text = (tal1 + tal2).ToString();
            räknesättLabel.Content = "Summering";
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            //Laddar in en string från tal1TextBox och konvertera string till int
            int tal1 = int.Parse(tal1TextBox.Text);
            int tal2 = int.Parse(tal2TextBox.Text);
            // subtraherar tal och skickar dessa till summaTextBox
            resultatTextBox.Text = (tal1 - tal2).ToString();
            räknesättLabel.Content = "Subtrahera";
        }

        private void multiplikationBtn_Click(object sender, RoutedEventArgs e)
        {
            //Laddar in en string från tal1TextBox och konvertera string till int
            int tal1 = int.Parse(tal1TextBox.Text);
            int tal2 = int.Parse(tal2TextBox.Text);
            // multiplicerar tal och skickar dessa till summaTextBox
            resultatTextBox.Text = (tal1 * tal2).ToString();
            räknesättLabel.Content = "Multiplikation";
        }

        private void divisionBtn_Click(object sender, RoutedEventArgs e)
        {
            //Laddar in en string från tal1TextBox och konvertera string till int
            double tal1 = double.Parse(tal1TextBox.Text);
            double tal2 = double.Parse(tal2TextBox.Text);

            // dividerar tal och skickar dessa till summaTextBox
            double resultat;
            resultat = (tal1 / tal2);
            
            resultatTextBox.Text = Math.Round(resultat, 2).ToString();
            räknesättLabel.Content = "Division";
        }

        private void rensaBtn_Click(object sender, RoutedEventArgs e)
        {
            resultatTextBox.Clear();
            tal1TextBox.Clear();
            tal2TextBox.Clear();
        }
    }
}
