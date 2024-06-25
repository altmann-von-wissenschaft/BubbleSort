using System;
using System.Windows.Forms;

namespace BubbleSort
{
    static class Program
    {
        static MainPresenter presenter;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            presenter = new MainPresenter(new MainForm(), new MainModel());
            presenter.Run();
        }
    }
}
