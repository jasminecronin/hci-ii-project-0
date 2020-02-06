using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard kingOfTheNorthAnimation; // satelites revolve around jon
        Storyboard lyannaSpeechAnimation;  // pulsating Lynanna? an indication that shes talking
        Storyboard jonAsksDaenerysAnimation;  //maybe just a john thing
        Storyboard jonAsksWildlingsAnimation;
        Storyboard tormund;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
