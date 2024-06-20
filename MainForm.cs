using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    partial class MainForm : Form, IMainView
    {
        string path;
        OpenFileDialog openFileDialog;

        public MainForm()
        {
            InitializeComponent();
            table.Columns[0].Width = 200;
            table.Columns[1].Width = 200;
            table.Columns[2].Width = 72;
            foreach (DataGridViewColumn column in table.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void UpdateData(IReadOnlyCollection<User> users)
        {
            table.Rows.Clear();
            table.DataSource = users;
            //table.Refresh();
        }

        public string GetLoadFileName()
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "*.csv";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            return (openFileDialog.ShowDialog() == DialogResult.OK) ?
                openFileDialog.FileName : null;
        }

        public string GetSaveFileName()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
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

        public int Amount { get => (int)numeric.Value; }

        public void Awaiting()
        {
            foreach (Control control in Controls)
                control.Enabled = false;
            labelStatus.Text = "Выполняется...";
        }

        public void Ready()
        {
            foreach (Control control in Controls)
                control.Enabled = true;
            labelStatus.Text = "Завершено";
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
