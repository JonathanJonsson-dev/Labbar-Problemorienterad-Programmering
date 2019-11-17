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

namespace Uppgift11b
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
            labelSannolikhet.Content = "50";
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double försök;
            double fel;
            double rätt;
            
            int sannolikhet = (int)progressBar1.Value;
            försök = double.Parse(försökTextBox.Text);
            fel = 0;
            rätt = 0;

            for (int i = 0; i < försök; i++)
            {
                int slump = new Random().Next(0, 100);
                // konverterar ett objekt från labelSannolikhet.Content till en string och sedan en int. 
                if (slump <= int.Parse(labelSannolikhet.Content.ToString()))
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

        private void merOturBtn_Click(object sender, RoutedEventArgs e)
        {
            int sannolikhet = int.Parse(labelSannolikhet.Content.ToString());
            sannolikhet -= 5;
            //progressBar1.Value = sannolikhet;
            labelSannolikhet.Content = sannolikhet.ToString();

        }

        private void mindreOturBtn_Click_1(object sender, RoutedEventArgs e)
        {
            int sannolikhet = int.Parse(labelSannolikhet.Content.ToString());
            sannolikhet += 5;
            //progressBar1.Value = sannolikhet;
            labelSannolikhet.Content = sannolikhet.ToString();
        }
    }
}
