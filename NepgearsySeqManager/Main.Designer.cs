namespace NepgearsySeqManager
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitTheApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.version100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.sequenceNameTextBox = new System.Windows.Forms.TextBox();
            this.editableStateCheckBox = new System.Windows.Forms.CheckBox();
            this.triggableStateCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialConfigTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GridSequences = new System.Windows.Forms.DataGridView();
            this.sequence_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EditorTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSequences)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridSequences);
            this.groupBox1.Controls.Add(this.EditorTabs);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sequence Editor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitTheApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem,
            this.aboutThisToolToolStripMenuItem,
            this.toolStripSeparator2,
            this.version100ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // aboutThisToolToolStripMenuItem
            // 
            this.aboutThisToolToolStripMenuItem.Name = "aboutThisToolToolStripMenuItem";
            this.aboutThisToolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutThisToolToolStripMenuItem.Text = "About PD2 : SMG";
            this.aboutThisToolToolStripMenuItem.Click += new System.EventHandler(this.aboutThisToolToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 463);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save the binary file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New Sequence";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitTheApplicationToolStripMenuItem
            // 
            this.quitTheApplicationToolStripMenuItem.Name = "quitTheApplicationToolStripMenuItem";
            this.quitTheApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitTheApplicationToolStripMenuItem.Text = "Quit the application";
            this.quitTheApplicationToolStripMenuItem.Click += new System.EventHandler(this.quitTheApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // version100ToolStripMenuItem
            // 
            this.version100ToolStripMenuItem.Enabled = false;
            this.version100ToolStripMenuItem.Name = "version100ToolStripMenuItem";
            this.version100ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.version100ToolStripMenuItem.Text = "Version 1.0.0";
            // 
            // EditorTabs
            // 
            this.EditorTabs.Controls.Add(this.tabPage1);
            this.EditorTabs.Controls.Add(this.tabPage2);
            this.EditorTabs.Location = new System.Drawing.Point(6, 20);
            this.EditorTabs.Name = "EditorTabs";
            this.EditorTabs.SelectedIndex = 0;
            this.EditorTabs.Size = new System.Drawing.Size(326, 421);
            this.EditorTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.materialConfigTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.triggableStateCheckBox);
            this.tabPage1.Controls.Add(this.editableStateCheckBox);
            this.tabPage1.Controls.Add(this.sequenceNameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Material Config Sequence";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Object Visibility Sequence";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequence Name";
            // 
            // sequenceNameTextBox
            // 
            this.sequenceNameTextBox.Location = new System.Drawing.Point(126, 7);
            this.sequenceNameTextBox.Name = "sequenceNameTextBox";
            this.sequenceNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.sequenceNameTextBox.TabIndex = 1;
            this.sequenceNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // editableStateCheckBox
            // 
            this.editableStateCheckBox.AutoSize = true;
            this.editableStateCheckBox.Location = new System.Drawing.Point(9, 36);
            this.editableStateCheckBox.Name = "editableStateCheckBox";
            this.editableStateCheckBox.Size = new System.Drawing.Size(92, 17);
            this.editableStateCheckBox.TabIndex = 2;
            this.editableStateCheckBox.Text = "Editable State";
            this.editableStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // triggableStateCheckBox
            // 
            this.triggableStateCheckBox.AutoSize = true;
            this.triggableStateCheckBox.Location = new System.Drawing.Point(9, 59);
            this.triggableStateCheckBox.Name = "triggableStateCheckBox";
            this.triggableStateCheckBox.Size = new System.Drawing.Size(70, 17);
            this.triggableStateCheckBox.TabIndex = 3;
            this.triggableStateCheckBox.Text = "Triggable";
            this.triggableStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Material Config Path";
            // 
            // materialConfigTextBox
            // 
            this.materialConfigTextBox.Location = new System.Drawing.Point(126, 91);
            this.materialConfigTextBox.Name = "materialConfigTextBox";
            this.materialConfigTextBox.Size = new System.Drawing.Size(186, 20);
            this.materialConfigTextBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Sequence";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GridSequences
            // 
            this.GridSequences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSequences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequence_name});
            this.GridSequences.Location = new System.Drawing.Point(338, 42);
            this.GridSequences.Name = "GridSequences";
            this.GridSequences.Size = new System.Drawing.Size(347, 395);
            this.GridSequences.TabIndex = 7;
            // 
            // sequence_name
            // 
            this.sequence_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sequence_name.HeaderText = "Sequence";
            this.sequence_name.Name = "sequence_name";
            this.sequence_name.ReadOnly = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(491, 500);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 535);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "PAYDAY 2: Sequence Manager Generator";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.EditorTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSequences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisToolToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl EditorTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox materialConfigTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox triggableStateCheckBox;
        private System.Windows.Forms.CheckBox editableStateCheckBox;
        private System.Windows.Forms.TextBox sequenceNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitTheApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem version100ToolStripMenuItem;
        private System.Windows.Forms.DataGridView GridSequences;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequence_name;
        private System.Windows.Forms.Button resetButton;
    }
}

