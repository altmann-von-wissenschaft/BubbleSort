using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler Exit
        {
            add => this.FormClosed += new FormClosedEventHandler(value);
            remove => this.FormClosed += new FormClosedEventHandler(value);
        }
    }
}
