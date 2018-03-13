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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutThisToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveSequenceDialog = new SaveFileDialog();
            SaveSequenceDialog.AddExtension = true;
            SaveSequenceDialog.DefaultExt = "sequence_manager";
            SaveSequenceDialog.Title = "Save the sequence file";
            SaveSequenceDialog.Filter = "Diesel Sequence Manager file|*.sequence_manager";
            SaveSequenceDialog.ShowDialog();

            if (SaveSequenceDialog.FileName == "")
            {
                SaveSequenceDialog.FileName = "untitled_sequence";
            }

            System.IO.FileStream fs = (System.IO.FileStream)SaveSequenceDialog.OpenFile();

            fs.Close();
        }

        private void quitTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.steamcommunity.com/profiles/76561198045788203");
        }
    }
}
