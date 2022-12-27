using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
using System.Media;
using System.IO;
using MiNET;
using LibNoise.Model;
using MiNET.Net.RakNet;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;

namespace Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
        BlurEffect blurEffect = new BlurEffect();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void present_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 250;
            animation.Duration = new Duration(TimeSpan.FromSeconds(1));
            present.BeginAnimation(WidthProperty, animation);
            present.BeginAnimation(HeightProperty, animation);
            rabb.Visibility = Visibility.Collapsed;
            var player = new SoundPlayer("kevin-macleod-deck-the-halls-b.wav");
            player.Play();
        }
    }
   
}

