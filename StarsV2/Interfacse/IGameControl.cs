using System;
using System.Windows.Input;

namespace StarsV2
{
    internal interface IGameControl
    {

        void OnKeyUp(object sender, KeyEventArgs e);
        void OnKeyDown(object sender, KeyEventArgs e);
        event EventHandler<Direction> OnDirectionChanged;

        
    }
}

