using System.Windows;

namespace StarsV2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

          
            IGameControl gameControl = new GameControl();
            IGameUI gameUI = new GameUI();
          
            IGameTimer gameTimer = new GameTimer();

            IGameCore gameCore = new GameCore(gameControl,
               
                gameUI,
                gameTimer
                
               );
            gameCore.Start();

        }
    }
}
