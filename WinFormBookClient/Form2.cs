using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBookClient
{
    public partial class Form2 : Form
    {
        public event EventHandler<string>? BookCreated = null;
        public Form2()
        {
            InitializeComponent();

            btnClear.Click += DoClickClear;
            btnSubmit.Click += DoClickSubmit;
        }

        private void DoClickSubmit(object? sender, EventArgs e)
        {
            BookCreated?.Invoke(this, "Created book's id");
        }

        private void DoClickClear(object? sender, EventArgs e)
        {
            txtId.Clear();
            txtTitle.Clear();
            txtPages.Clear();
            txtId.Focus();
        }
    }
}
