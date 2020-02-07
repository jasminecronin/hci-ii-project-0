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
        // Animation declarations
        Storyboard lordManderlyCircle;
        Storyboard lordGloverCircle;
        Storyboard wildlingCircle;
        Storyboard wunWunCircle;
        Storyboard daenerysCircle;
        Storyboard tyrionCircle;
        Storyboard northernersMove;
        Storyboard wildlingsMove;
        Storyboard teamDavosMove;
        Storyboard lyannaGroupCircle;
        Storyboard tormundGroupCircle;
        Storyboard davosGroupCircle;

        // mediaplayer for sound
        private MediaPlayer sound = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();

            // counter for click animations
            int clicks = 0;

            // Initialize animations
            lordManderlyCircle = (Storyboard)Resources["LordManAnimation"];
            lordGloverCircle = (Storyboard)Resources["LordGlovAnimation"];
            wildlingCircle = (Storyboard)Resources["WildAnimation"];
            wunWunCircle = (Storyboard)Resources["WunAnimation"];
            daenerysCircle = (Storyboard)Resources["DaenerysAnimation"];
            tyrionCircle = (Storyboard)Resources["TyrionAnimation"];
            northernersMove = (Storyboard)Resources["LyannaGroupAnimation"];
            wildlingsMove = (Storyboard)Resources["TormundGroupAnimation"];
            teamDavosMove = (Storyboard)Resources["DavosAnimation"];
            lyannaGroupCircle = (Storyboard)Resources["LyannaGroupFinalAnimation"];
            tormundGroupCircle = (Storyboard)Resources["TormundGroupFinalAnimation"];
            davosGroupCircle = (Storyboard)Resources["DavosGroupFinalAnimation"];

            this.KeyUp += MainWindow_KeyUp;

            // Closures (anonymous methods) for controlling the animations and audio playback
            JonSnow1.MouseLeftButtonUp += (s, e) =>
            {
                if (clicks == 0)
                {
                    clicks++;
                    sound.Open(new Uri("..\\..\\Assets\\Sound\\jon-snow-asks-northmen.mp3", UriKind.Relative));
                    sound.Play();
                    lordManderlyCircle.Begin();
                    lordGloverCircle.Begin();
                }
                else if (clicks == 1)
                {
                    clicks++;
                    sound.Open(new Uri("..\\..\\Assets\\Sound\\jon-snow-asks-wildlings.mp3", UriKind.Relative));
                    sound.Play();
                    wunWunCircle.Begin();
                    wildlingCircle.Begin();
                }
                else if (clicks == 2)
                {
                    clicks++;
                    sound.Open(new Uri("..\\..\\Assets\\Sound\\jon-snow-asks-daenerys.mp3", UriKind.Relative));
                    sound.Play();
                    daenerysCircle.Begin();
                    tyrionCircle.Begin();
                }
            };

            lordGloverCircle.Completed += (s, e) =>
            {
                sound.Open(new Uri("..\\..\\Assets\\Sound\\lyanna-praises-jon.mp3", UriKind.Relative));
                sound.Play();
                northernersMove.Begin();
            };

            wildlingCircle.Completed += (s, e) =>
            {
                sound.Open(new Uri("..\\..\\Assets\\Sound\\tormund-praises-jon.mp3", UriKind.Relative));
                sound.Play();
                wildlingsMove.Begin();
            };

            tyrionCircle.Completed += (s, e) =>
            {
                sound.Open(new Uri("..\\..\\Assets\\Sound\\davos-praises-jon.mp3", UriKind.Relative));
                sound.Play();
                teamDavosMove.Begin();
            };

            teamDavosMove.Completed += (s, e) =>
            {
                sound.Open(new Uri("..\\..\\Assets\\Sound\\king-in-the-north-long.mp3", UriKind.Relative));
                sound.Play();
                lyannaGroupCircle.Begin();
                tormundGroupCircle.Begin();
                davosGroupCircle.Begin();
            };

            lyannaGroupCircle.Completed += (s, e) =>
            {
                lyannaGroupCircle.Begin();
            };

            tormundGroupCircle.Completed += (s, e) =>
            {
                tormundGroupCircle.Begin();
            };

            davosGroupCircle.Completed += (s, e) =>
            {
                davosGroupCircle.Begin();
            };
        }

        // Method for exiting the program with the escape key
        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
