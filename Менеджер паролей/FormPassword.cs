using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Менеджер_паролей
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void llSite1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((string)((LinkLabel)sender).Tag);
        }

        private void tbLogin1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((TextBox)sender).Text);
            ((TextBox)sender).SelectAll();
        }

        private void btPassword1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText((string)((Button)sender).Tag);
            Close();
        }
    }
}
