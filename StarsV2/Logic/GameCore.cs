using System;
using System.Windows.Input;

namespace StarsV2
{
    internal class GameCore : IGameCore
    {
        private IGameControl gameControl;
        private IGameUI gameUI;
        private IGameTimer gameTimer;
        public GameCore(IGameControl gameControl, IGameUI gameUI, IGameTimer gameTimer)
        {
            this.gameControl = gameControl;
            this.gameUI = gameUI;   
            this.gameTimer = gameTimer;
                

        }


        public void Start()
        {
            gameUI.Init();
        }
    }
}
