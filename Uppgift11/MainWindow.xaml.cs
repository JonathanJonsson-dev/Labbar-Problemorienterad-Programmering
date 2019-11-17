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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ProgressBar pBar = new ProgressBar();
            progressBar1.Value = 50;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double försök;
            double fel;
            double rätt;
            försök = double.Parse(försökTextBox.Text);
            fel = 0;
            rätt = 0;
            
            for (int i = 0; i < försök; i++)
            {
                int slump = new Random().Next(0, 2);

                if (slump == 0)
                {
                    fel++;
                }
                else
                {
                    rätt++;
                }

                double resultat;
                resultat = (rätt / (rätt + fel)) * 100;
                progressBar1.Value = resultat;
                progressLabel.Content = $"{progressBar1.Value}%";
            }
            rättLabel.Content = rätt.ToString();
            felLabel.Content = fel.ToString();
        }
        /*
        int sannolikhet;
        sannolikhet = 50;
        
        private void merOturBtn_Click(object sender, RoutedEventArgs e)
        {
            sannolikhet += 5;
        }

        private void mindreOturBtn_Click(object sender, RoutedEventArgs e)
        {
            sannolikhet -= 5;
        }
        */
    }
}
