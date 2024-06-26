﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace BubbleSort
{
    interface IMainModel
    {
        IReadOnlyCollection<User> Users { get; }
        Task GenerateRecords(int amount);
        Task SortByLogin();
        Task SortByNickname();
        Task SortByAge();
        void SaveAsFile(string fileName);
        void LoadAsFile(string fileName);
    }
}
