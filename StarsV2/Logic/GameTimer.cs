using System;
using System.Windows.Threading;

namespace StarsV2
{
    internal class GameTimer : IGameTimer
    {
        DispatcherTimer _gameTimer;




        public void Stop()
        {
            _gameTimer.Stop();
           
        }
    }
}
