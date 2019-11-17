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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float försök;
            int fel;
            int rätt;
            försök = float.Parse(försökTextBox.Text);
            fel = 0;
            rätt = 0;

            for (int i = 0; i < försök; i++)
            {
                int slump = new Random().Next(0, 2);

                if (slump == 0)
                {
                    fel++;
                    progressBar1.Value = progressBar1.Value - Convert.ToDouble(100 / försök);
                }
                else
                {
                    rätt++;
                    progressBar1.Value = progressBar1.Value + Convert.ToDouble(100 / försök);
                }

                progressLabel.Content = $"{progressBar1.Value}%";
            }
            rättLabel.Content = rätt.ToString();
            felLabel.Content = fel.ToString();
        }

        private void merOturBtn_Click(object sender, RoutedEventArgs e)
        {
            progressBar1.Value -= 5;
            progressLabel.Content = $"{progressBar1.Value}%";
        }

        private void mindreOturBtn_Click(object sender, RoutedEventArgs e)
        {
            progressBar1.Value += 5;
            progressLabel.Content = $"{progressBar1.Value}%";
        }
        
    }
}
