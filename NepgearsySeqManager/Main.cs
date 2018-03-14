using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace NepgearsySeqManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Sequence InitSequence = new Sequence();
            InitSequence.Init();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutThisToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GridSequences.RowCount == 1) // One because one row is blank.
            {
                DialogResult AskContinueNoSequence = MessageBox.Show("You don't have any sequence. Are you sure you want to save anyways?", "No Sequence Added", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (AskContinueNoSequence == DialogResult.No)
                {
                    return;
                }
            }

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

            string opt_xml = File.ReadAllText(Sequence.combined_path);

            switch (outputCollection.Text)
            {
                case "Binary":
                    /*
                     *  If anyone can figure this out, feel free to post a pull request. My head hurts so hard after spending 3 hours trying to get
                     *  a working binary file, and in the end I could'nt find out.
                    */
                    break;

                case "XML":
                    StreamWriter writer = new StreamWriter(SaveSequenceDialog.OpenFile());
                    writer.Write(opt_xml);
                    writer.Dispose();
                    writer.Close();
                    break;
            }
        }

        private void quitTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sequence.DeleteTempFile();
            Application.Exit();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.steamcommunity.com/profiles/76561198045788203");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sequenceNameTextBox.Text == "")
            {
                MessageBox.Show("The sequence must have a name.", "Sequence name is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GridSequences.Rows.Add(sequenceNameTextBox.Text);
            Sequence Seq = new Sequence();

            Seq.AddMainSequenceInfos(sequenceNameTextBox.Text, editableStateCheckBox.Checked, triggableStateCheckBox.Checked);

            if (enableMaterialConfig.Checked) { Seq.AddMaterialConfigSequence(materialConfigTextBox.Text); }
            if (enableSound.Checked) { Seq.AddSoundSequence(soundAction.Text, soundEvent.Text, soundObject.Text); }
            if (enableObject.Checked) { Seq.AddObjectSequence(objectSeqEnabled.Checked, objectSeqName.Text); }

            Sequence.Save();
            ResetForm();
        }

        private void ResetForm()
        {
            sequenceNameTextBox.Text = "";
            editableStateCheckBox.Checked = false;
            triggableStateCheckBox.Checked = false;

            enableMaterialConfig.Checked = false;
            materialConfigTextBox.Text = "";

            enableSound.Checked = false;
            soundAction.Text = "play";
            soundEvent.Text = "";
            soundObject.Text = "";

            enableObject.Checked = false;
            objectSeqEnabled.Checked = false;
            objectSeqName.Text = "";

            outputCollection.Text = "XML";
        }

        private void TotalResetForm()
        {
            ResetForm();
            Sequence.CreateTempFile();

            GridSequences.Rows.Clear();
            GridSequences.Refresh();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            TotalResetForm();
        }

        private string GetSequenceName()
        {
            return sequenceNameTextBox.Text;
        }

        private bool GetEditableState()
        {
            return editableStateCheckBox.Checked;
        }

        private bool GetTriggableState()
        {
            return editableStateCheckBox.Checked;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalResetForm();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialConfigTextBox_TextChanged(object sender, EventArgs e)
        {
            if (materialConfigTextBox.Text == "")
            {
                enableMaterialConfig.Checked = false;
                return;
            }

            enableMaterialConfig.Checked = true;
        }

        private void soundEvent_TextChanged(object sender, EventArgs e)
        {
            if (soundEvent.Text == "")
            {
                enableSound.Checked = false;
                return;
            }

            enableSound.Checked = true;
        }

        private void soundObject_TextChanged(object sender, EventArgs e)
        {
            if (soundObject.Text == "")
            {
                enableSound.Checked = false;
                return;
            }

            enableSound.Checked = true;
        }

        private void objectSeqEnabled_CheckedChanged(object sender, EventArgs e)
        {
            enableObject.Checked = true;
        }

        private void objectSeqName_TextChanged(object sender, EventArgs e)
        {
            if (objectSeqName.Text == "")
            {
                enableObject.Checked = false;
                return;
            }

            enableObject.Checked = true;
        }
    }
}