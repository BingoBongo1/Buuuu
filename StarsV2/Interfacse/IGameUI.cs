using System;
using System.Windows.Input;

namespace StarsV2
{
    internal interface IGameUI
    {

        event EventHandler<KeyEventArgs> OnKeyDownPressed;
        event EventHandler<KeyEventArgs> OnKeyUpPressed;

        
         


        void Init();
    }
}
