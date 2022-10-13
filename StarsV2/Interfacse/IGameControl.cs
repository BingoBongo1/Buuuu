using System;
using System.Windows.Input;

namespace StarsV2
{
    internal interface IGameControl
    {

        //void KeyUp(object sender, KeyEventArgs e);
        //void KeyDown(object sender, KeyEventArgs e);
        void KeyUp( KeyEventArgs e);
        void KeyDown(KeyEventArgs e);

        event EventHandler<Direction> OnDirectionChanged;

        
    }
}

