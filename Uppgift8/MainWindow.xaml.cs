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

namespace Uppgift8
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

        private void beräknaBtn_Click(object sender, RoutedEventArgs e)

        {
            if (summaRadioBtn.IsChecked == true)
            {
                int tal1 = int.Parse(tal1TextBox.Text);
                int tal2 = int.Parse(tal2TextBox.Text);

                // summaerar tal och skickar dessa till resultatTextBox
                int resultat;
                resultat = tal1 + tal2;

                //resultatTextBox.Text = Math.Round(resultat, 2).ToString();
                resultatTextBox.Text = resultat.ToString();
            }

            else if (subtraheraRadioBtn.IsChecked == true)
            {
                int tal1 = int.Parse(tal1TextBox.Text);
                int tal2 = int.Parse(tal2TextBox.Text);

                // summaerar tal och skickar dessa till resultatTextBox
                int resultat;
                resultat = tal1 - tal2;

                //resultatTextBox.Text = Math.Round(resultat, 2).ToString();
                resultatTextBox.Text = resultat.ToString();
            }

            else if (multiplikationRadioBtn.IsChecked == true)
            {
                int tal1 = int.Parse(tal1TextBox.Text);
                int tal2 = int.Parse(tal2TextBox.Text);

                // summaerar tal och skickar dessa till resultatTextBox
                int resultat;
                resultat = tal1 * tal2;

                //resultatTextBox.Text = Math.Round(resultat, 2).ToString();
                resultatTextBox.Text = resultat.ToString();
            }

            else if (divisionRadioBtn.IsChecked == true)
            {
                double tal1 = double.Parse(tal1TextBox.Text);
                double tal2 = double.Parse(tal2TextBox.Text);

                // summaerar tal och skickar dessa till resultatTextBox
                double resultat;
                resultat = tal1 / tal2;

                //resultatTextBox.Text = Math.Round(resultat, 2).ToString();
                resultatTextBox.Text = resultat.ToString();
            }
        }
    }
}
