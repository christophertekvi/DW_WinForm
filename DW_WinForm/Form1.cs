using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_WinForm
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee fe = new FormEmployee();
            fe.ShowDialog();
        }
    }
}
