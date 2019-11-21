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

namespace Uppgift15
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //char[] characters = userInputTextBox.Text.ToCharArray();
            string sträng = userInputTextBox.Text; //Matar in input till en variabel
            Rotvälska Rotvälska = new Rotvälska(); // Initierar metod
            int antalVokaler = Rotvälska.NumberOfVowels(sträng); //Skickar sträng till metoden NumberOfVowels
            antalVokalerLabel.Content = $"Antal vokaler: {antalVokaler}"; // Skickar antal vokaler till label
            sträng = Rotvälska.JibberishSmåVokaler(sträng); // gör om små vokaler till jibberish
            sträng = Rotvälska.JibberishStoraVokaler(sträng); // gör om stora vokaler till jibberish
            rotvälskaLabel.Content = sträng; // skickar sträng till rotvälskaLabel

        }
    }
}
