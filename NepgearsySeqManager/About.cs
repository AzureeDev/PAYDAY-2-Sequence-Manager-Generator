using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NepgearsySeqManager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void aboutWindowClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.steamcommunity.com/profiles/76561198045788203");
        }
    }
}
