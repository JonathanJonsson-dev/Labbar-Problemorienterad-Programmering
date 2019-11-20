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

namespace Uppgift14
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
            
            char[] characters = userInputTextBox.Text.ToCharArray();
            int antalBokstäver = 0;
            int antalSiffror = 0;

            foreach (char bokstav in characters)
            {
                //result = Char.IsLetter(bokstav);
                Undersök Undersök = new Undersök();
                bool result;
                result = Undersök.Tecken(bokstav);
                
                if (result == true)
                {
                    //MessageBox.Show(result.ToString());
                    antalBokstäver++;
                }
                else
                {
                    //MessageBox.Show(result.ToString());
                    antalSiffror++;
                }
            }

            if (antalBokstäver > 0)
            {
                MessageBox.Show("Du måste enbart mata in siffror");
            }
            else
            {
                int årtal = DateTime.Now.Year;
                int ålder = årtal - int.Parse(userInputTextBox.Text);
                MessageBox.Show($"Du är {ålder} år gammal");
            }

            
        }
    }
}
