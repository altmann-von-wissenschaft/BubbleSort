using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class MainPresenter : IPresenter
    {
        readonly IMainView view;
        readonly IMainModel model;

        public MainPresenter(IMainView view, IMainModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Run() => view.Show();
    }
}
