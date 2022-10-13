using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace StarsV2
{
    internal class GameUI : IGameUI
    {
        Skins skin;
        public void Init()
        {         
            skin = new Skins();
            skin.Show();
        }


        private void AddRectangle(object sender, MouseButtonEventArgs e)
        {
            Rectangle newBullet = new Rectangle
            {

                Tag = "bullet",
                Height = 20,
                Width = 5,
                Fill = Brushes.White,
                Stroke = Brushes.Red

            };
            Canvas.SetLeft(newBullet, Canvas.GetLeft(player) + player.Width / 2);
            Canvas.SetTop(newBullet, Canvas.GetTop(player) - newBullet.Height);
            Canva.Children.Add(newBullet);
        }
    }
}
