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
            this.GridSequences = new System.Windows.Forms.DataGridView();
            this.EditorTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soundObject = new System.Windows.Forms.TextBox();
            this.soundEvent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sequenceNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialConfigTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.editableStateCheckBox = new System.Windows.Forms.CheckBox();
            this.triggableStateCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitTheApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.version100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.outputCollection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.soundAction = new System.Windows.Forms.ComboBox();
            this.enableSound = new System.Windows.Forms.CheckBox();
            this.enableMaterialConfig = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.objectSeqEnabled = new System.Windows.Forms.CheckBox();
            this.objectSeqName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.enableObject = new System.Windows.Forms.CheckBox();
            this.sequence_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSequences)).BeginInit();
            this.EditorTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // EditorTabs
            // 
            this.EditorTabs.Controls.Add(this.tabPage1);
            this.EditorTabs.Location = new System.Drawing.Point(6, 20);
            this.EditorTabs.Name = "EditorTabs";
            this.EditorTabs.SelectedIndex = 0;
            this.EditorTabs.Size = new System.Drawing.Size(326, 421);
            this.EditorTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.sequenceNameTextBox);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.editableStateCheckBox);
            this.tabPage1.Controls.Add(this.triggableStateCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Custom";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.enableSound);
            this.groupBox3.Controls.Add(this.soundAction);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.soundObject);
            this.groupBox3.Controls.Add(this.soundEvent);
            this.groupBox3.Location = new System.Drawing.Point(7, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 104);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sound";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Event";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Action";
            // 
            // soundObject
            // 
            this.soundObject.Location = new System.Drawing.Point(97, 74);
            this.soundObject.Name = "soundObject";
            this.soundObject.Size = new System.Drawing.Size(202, 20);
            this.soundObject.TabIndex = 2;
            this.soundObject.TextChanged += new System.EventHandler(this.soundObject_TextChanged);
            // 
            // soundEvent
            // 
            this.soundEvent.Location = new System.Drawing.Point(97, 47);
            this.soundEvent.Name = "soundEvent";
            this.soundEvent.Size = new System.Drawing.Size(202, 20);
            this.soundEvent.TabIndex = 1;
            this.soundEvent.TextChanged += new System.EventHandler(this.soundEvent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequence Name";
            // 
            // sequenceNameTextBox
            // 
            this.sequenceNameTextBox.Location = new System.Drawing.Point(104, 10);
            this.sequenceNameTextBox.Name = "sequenceNameTextBox";
            this.sequenceNameTextBox.Size = new System.Drawing.Size(202, 20);
            this.sequenceNameTextBox.TabIndex = 1;
            this.sequenceNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enableMaterialConfig);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.materialConfigTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 51);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path";
            // 
            // materialConfigTextBox
            // 
            this.materialConfigTextBox.Location = new System.Drawing.Point(98, 19);
            this.materialConfigTextBox.Name = "materialConfigTextBox";
            this.materialConfigTextBox.Size = new System.Drawing.Size(202, 20);
            this.materialConfigTextBox.TabIndex = 5;
            this.materialConfigTextBox.TextChanged += new System.EventHandler(this.materialConfigTextBox_TextChanged);
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
            // editableStateCheckBox
            // 
            this.editableStateCheckBox.AutoSize = true;
            this.editableStateCheckBox.Location = new System.Drawing.Point(15, 39);
            this.editableStateCheckBox.Name = "editableStateCheckBox";
            this.editableStateCheckBox.Size = new System.Drawing.Size(92, 17);
            this.editableStateCheckBox.TabIndex = 2;
            this.editableStateCheckBox.Text = "Editable State";
            this.editableStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // triggableStateCheckBox
            // 
            this.triggableStateCheckBox.AutoSize = true;
            this.triggableStateCheckBox.Location = new System.Drawing.Point(113, 39);
            this.triggableStateCheckBox.Name = "triggableStateCheckBox";
            this.triggableStateCheckBox.Size = new System.Drawing.Size(70, 17);
            this.triggableStateCheckBox.TabIndex = 3;
            this.triggableStateCheckBox.Text = "Triggable";
            this.triggableStateCheckBox.UseVisualStyleBackColor = true;
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New Sequence";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 463);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(572, 500);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
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
            // outputCollection
            // 
            this.outputCollection.FormattingEnabled = true;
            this.outputCollection.Items.AddRange(new object[] {
            "Binary",
            "XML"});
            this.outputCollection.Location = new System.Drawing.Point(364, 500);
            this.outputCollection.Name = "outputCollection";
            this.outputCollection.Size = new System.Drawing.Size(121, 21);
            this.outputCollection.TabIndex = 4;
            this.outputCollection.Text = "XML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Object";
            // 
            // soundAction
            // 
            this.soundAction.FormattingEnabled = true;
            this.soundAction.Items.AddRange(new object[] {
            "play"});
            this.soundAction.Location = new System.Drawing.Point(178, 20);
            this.soundAction.Name = "soundAction";
            this.soundAction.Size = new System.Drawing.Size(121, 21);
            this.soundAction.TabIndex = 6;
            this.soundAction.Text = "play";
            // 
            // enableSound
            // 
            this.enableSound.AutoSize = true;
            this.enableSound.Location = new System.Drawing.Point(290, 0);
            this.enableSound.Name = "enableSound";
            this.enableSound.Size = new System.Drawing.Size(15, 14);
            this.enableSound.TabIndex = 7;
            this.enableSound.UseVisualStyleBackColor = true;
            // 
            // enableMaterialConfig
            // 
            this.enableMaterialConfig.AutoSize = true;
            this.enableMaterialConfig.Location = new System.Drawing.Point(291, 0);
            this.enableMaterialConfig.Name = "enableMaterialConfig";
            this.enableMaterialConfig.Size = new System.Drawing.Size(15, 14);
            this.enableMaterialConfig.TabIndex = 7;
            this.enableMaterialConfig.UseVisualStyleBackColor = true;
            this.enableMaterialConfig.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.enableObject);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.objectSeqName);
            this.groupBox4.Controls.Add(this.objectSeqEnabled);
            this.groupBox4.Location = new System.Drawing.Point(7, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 44);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Object";
            // 
            // objectSeqEnabled
            // 
            this.objectSeqEnabled.AutoSize = true;
            this.objectSeqEnabled.Location = new System.Drawing.Point(6, 19);
            this.objectSeqEnabled.Name = "objectSeqEnabled";
            this.objectSeqEnabled.Size = new System.Drawing.Size(65, 17);
            this.objectSeqEnabled.TabIndex = 0;
            this.objectSeqEnabled.Text = "Enabled";
            this.objectSeqEnabled.UseVisualStyleBackColor = true;
            this.objectSeqEnabled.CheckedChanged += new System.EventHandler(this.objectSeqEnabled_CheckedChanged);
            // 
            // objectSeqName
            // 
            this.objectSeqName.Location = new System.Drawing.Point(155, 16);
            this.objectSeqName.Name = "objectSeqName";
            this.objectSeqName.Size = new System.Drawing.Size(144, 20);
            this.objectSeqName.TabIndex = 1;
            this.objectSeqName.TextChanged += new System.EventHandler(this.objectSeqName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // enableObject
            // 
            this.enableObject.AutoSize = true;
            this.enableObject.Location = new System.Drawing.Point(290, 0);
            this.enableObject.Name = "enableObject";
            this.enableObject.Size = new System.Drawing.Size(15, 14);
            this.enableObject.TabIndex = 3;
            this.enableObject.UseVisualStyleBackColor = true;
            // 
            // sequence_name
            // 
            this.sequence_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sequence_name.HeaderText = "Sequences List";
            this.sequence_name.Name = "sequence_name";
            this.sequence_name.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputCollection);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PAYDAY 2: Sequence Manager Generator";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSequences)).EndInit();
            this.EditorTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl EditorTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox materialConfigTextBox;
        private System.Windows.Forms.CheckBox triggableStateCheckBox;
        private System.Windows.Forms.CheckBox editableStateCheckBox;
        private System.Windows.Forms.TextBox sequenceNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitTheApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem version100ToolStripMenuItem;
        private System.Windows.Forms.DataGridView GridSequences;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox outputCollection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soundObject;
        private System.Windows.Forms.TextBox soundEvent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox enableSound;
        private System.Windows.Forms.ComboBox soundAction;
        private System.Windows.Forms.CheckBox enableMaterialConfig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox enableObject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox objectSeqName;
        private System.Windows.Forms.CheckBox objectSeqEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequence_name;
    }
}

