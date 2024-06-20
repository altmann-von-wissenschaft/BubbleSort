using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            view.OnGenerate += new EventHandler(OnGenerate);
            view.OnSortByLogin += new EventHandler(OnSortByLogin);
            view.OnSortByNickname += new EventHandler(OnSortByNickname);
            view.OnSortByAge += new EventHandler(OnSortByAge);
            view.OnLoad += new EventHandler(OnLoad);
            view.OnSave += new EventHandler(OnSave);
        }

        public void Run() => view.Show();

        async void OnGenerate(object s, EventArgs e)
        {
            view.Awaiting();
            await model.Generate(view.Amount);
            view.Ready();
        }

        async void OnSortByLogin(object s, EventArgs e)
        {
            view.Awaiting();
            await model.SortByLogin();
            view.Ready();
        }

        async void OnSortByNickname(object s, EventArgs e)
        {
            view.Awaiting();
            await model.SortByNickname();
            view.Ready();
        }

        async void OnSortByAge(object s, EventArgs e)
        {
            view.Awaiting();
            await model.SortByAge();
            view.Ready();
        }

        void OnLoad(object s, EventArgs e)
        {
            string path = view.GetLoadFileName();
            if (path is not null)
                model.LoadAsFile(path);
        }

        void OnSave(object s, EventArgs e)
        {
            string path = view.GetSaveFileName();
            if (path is not null)
                model.SaveAsFile(path);
        }

        
    }
}
