using System;
namespace BubbleSort
{
    interface IView
    {
        void Show();
        void Close();
        event EventHandler Exit;
    }
}
