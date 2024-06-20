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

        public void Run() 
        { 
            Application.Run((Form)view);
        } 

        async void OnGenerate(object s, EventArgs e)
        {
            view.Awaiting();
            await model.GenerateRecords(view.Amount);
            view.UpdateData(model.Users);
            view.Ready();
        }

        async void OnSortByLogin(object s, EventArgs e)
        {
            view.Awaiting();
            await model.SortByLogin();
            view.UpdateData(model.Users);
            view.Ready();
        }

        async void OnSortByNickname(object s, EventArgs e)
        {
            view.Awaiting();
            await model.SortByNickname();
            view.UpdateData(model.Users);
            view.Ready();
        }

        async void OnSortByAge(object s, EventArgs e)
        {
            view.Awaiting();
            await model.SortByAge();
            view.UpdateData(model.Users);
            view.Ready();
        }

        void OnLoad(object s, EventArgs e)
        {
            string path = view.GetLoadFileName();
            if (path is not null)
                model.LoadAsFile(path);
            view.UpdateData(model.Users);
        }

        void OnSave(object s, EventArgs e)
        {
            string path = view.GetSaveFileName();
            if (path is not null)
                model.SaveAsFile(path);
            view.UpdateData(model.Users);
        }
    }
}
