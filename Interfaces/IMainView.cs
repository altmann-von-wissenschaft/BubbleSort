using System;
using System.Collections.Generic;

namespace BubbleSort
{
    interface IMainView : IView
    {
        event EventHandler OnGenerate;
        event EventHandler OnSave;
        event EventHandler OnLoad;
        event EventHandler OnSortByLogin;
        event EventHandler OnSortByNickname;
        event EventHandler OnSortByAge;
        int AmountToGenerate { get; }
        string GetLoadFileName();
        string GetSaveFileName();
        void UpdateData(IReadOnlyCollection<User> users);
        void Awaiting();
        void Ready();
    }
}
