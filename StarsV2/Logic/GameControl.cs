
using System;
using System.Windows.Input;

namespace StarsV2
{
    internal class GameControl : IGameControl
    {
        private Direction currentDirection;

        public event EventHandler<Direction> OnDirectionChanged;

        Direction _currentDirection
        {
            get => currentDirection;
            set
            {
                currentDirection = value;
                OnDirectionChanged?.Invoke(this, currentDirection);
            }
        }

        bool moveLeft, moveRight;

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = true;
            }
            if (e.Key == Key.Right)
            {
                moveRight = true;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = false;
            }
            if (e.Key == Key.Right)
            {
                moveRight = false;
            }

            if (e.Key == Key.Space)
            {
                //Rectangle newBullet = new Rectangle
                //{

                //    Tag = "bullet",
                //    Height = 20,
                //    Width = 5,
                //    Fill = Brushes.White,
                //    Stroke = Brushes.Red

                //};

                //Canvas.SetLeft(newBullet, Canvas.GetLeft(player) + player.Width / 2);
                //Canvas.SetTop(newBullet, Canvas.GetTop(player) - newBullet.Height);

                //Canva.Children.Add(newBullet);

            }

            if (e.Key == Key.Escape)
            {
                GameMenu gameMenu = new GameMenu();
                gameMenu.Show();
                //gameTimer.Stop();
                //gimi.Stop();
                //Close();
            }
        }


    }
}
