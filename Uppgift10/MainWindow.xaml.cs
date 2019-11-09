﻿using System;
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

namespace Uppgift10
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

        Random slump = new Random();
        int slumptal = slump.Next(1001);

        private void slumpBtn_Click(object sender, RoutedEventArgs e)
        {
            int slumptal = slump.Next(1001);
            //slumpatTal.Content = slumptal.ToString();
        }

        private void gissaBtn_Click(object sender, RoutedEventArgs e)
        {
            int gissning = int.Parse(gissningTextbox.Text);
            
            
            if (gissning < slumptal)
            {
                label.Content = "Oh, du är inte ens nära. Du gissade alldeles för lågt";
            }
            else if (gissning == slumptal)
            {
                label.Content = "Grattis!!! Du gissade rätt";
            }
            else
            {
                label.Content = "Oh, du är inte ens nära. Du gissade alldeles för högt";
            }
        }
    }
}
