using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    interface IMainModel
    {
        IReadOnlyCollection<User> Users { get; }
        void SortByLogin();
        void SortByNickname();
        void SortByAge();
        void SaveAsFile(string fileName);
        void LoadAsFile(string fileName);
    }
}
