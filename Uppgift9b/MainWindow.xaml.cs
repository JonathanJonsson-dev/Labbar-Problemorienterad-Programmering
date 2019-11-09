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

namespace Uppgift9b
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

        private void kontrolleraBtn_Click(object sender, RoutedEventArgs e)
        {

            if (medVuxenRadioBtn.IsChecked == true)
            {

                string namn;
                int ålder;

                namn = namnTextBox.Text;
                ålder = int.Parse(ålderTextBox.Text);

                if (ålder >= 15)
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och får se alla filmer.";
                }

                else if (ålder < 15 && ålder >= 11)
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och då får du se filmer med åldersgräns upp till 11 år.";
                }

                else if (ålder < 11 && ålder >= 7)
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och får se filmer med åldersgräns upp till 7 år”.";
                }

                else
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och får se filmer med sällskap av vuxen";
                }
            }

            if (utanVuxenRadioBtn.IsChecked == true)
            {

                string namn;
                int ålder;

                namn = namnTextBox.Text;
                ålder = int.Parse(ålderTextBox.Text);

                if (ålder >= 15)
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och får se alla filmer.";
                }

                else if (ålder < 15 && ålder >= 11)
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och då får du se filmer med åldersgräns upp till 11 år.";
                }

                else if (ålder < 11 && ålder >= 7)
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och får se filmer med åldersgräns upp till 7 år”.";
                }

                else
                {
                    resultatLabel.Content = $"Hej {namn}. Du är {ålder} gammal och får se filmer med sällskap av vuxen";
                }
            }
        }
    }
}
