using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BubbleSort
{
    partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
            table.Columns[0].Width = 190;
            table.Columns[1].Width = 190;
            table.Columns[2].Width = 72;
            foreach (DataGridViewColumn column in table.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        ~MainForm() => Application.Exit();

        public new void Show() => Application.Run(this);

        public void UpdateData(IReadOnlyCollection<User> users)
        {
            table.Rows.Clear();
            foreach(var user in users)
            {
                table.Rows.Add(user.login, user.nickname, user.age);
            }
            table.Refresh();
        }

        public string GetLoadFileName()
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Файл данных|*.csv";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            return (openFileDialog.ShowDialog() == DialogResult.OK) ?
                openFileDialog.FileName : null;
        }

        public string GetSaveFileName()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Файл данных|*.csv";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    return saveFileDialog.FileName;
                }
            }

            return null;
        }

        public int AmountToGenerate { get => (int)numeric.Value; }

        public void Awaiting()
        {
            foreach (Control control in Controls)
                control.Enabled = false;
            labelStatus.Text = "Статус: выполняется...";
        }

        public void Ready()
        {
            foreach (Control control in Controls)
                control.Enabled = true;
            labelStatus.Text = "Статус: завершено";
        }

        public event EventHandler OnGenerate
        {
            add => this.buttonGenerate.Click += value;
            remove => this.buttonGenerate.Click += value;
        }

        public event EventHandler OnSave
        {
            add => this.buttonSave.Click += value;
            remove => this.buttonSave.Click += value;
        }

        public new event EventHandler OnLoad
        {
            add => this.buttonLoad.Click += value;
            remove => this.buttonLoad.Click += value;
        }

        public event EventHandler OnSortByLogin
        {
            add => this.buttonLogin.Click += value;
            remove => this.buttonLogin.Click += value;
        }

        public event EventHandler OnSortByNickname
        {
            add => this.buttonNick.Click += value;
            remove => this.buttonNick.Click += value;
        }

        public event EventHandler OnSortByAge
        {
            add => this.buttonAge.Click += value;
            remove => this.buttonAge.Click += value;
        }

        public event EventHandler Exit
        {
            add => this.FormClosed += new FormClosedEventHandler(value);
            remove => this.FormClosed += new FormClosedEventHandler(value);
        }

    }
}
