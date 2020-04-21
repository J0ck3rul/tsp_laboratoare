namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MediaName = new System.Windows.Forms.Label();
            this.MediaSaveButton = new System.Windows.Forms.Button();
            this.MediDescriptionLabel = new System.Windows.Forms.Label();
            this.MediaEventLabel = new System.Windows.Forms.Label();
            this.MediaNameInput = new System.Windows.Forms.TextBox();
            this.MediaDescriptionInput = new System.Windows.Forms.TextBox();
            this.MediaEventInput = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.MediaTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShouFileButton = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.PersonsUpdateButton = new System.Windows.Forms.Button();
            this.PersonCreateButton = new System.Windows.Forms.Button();
            this.PersonNameInput = new System.Windows.Forms.TextBox();
            this.PersonsGrid = new System.Windows.Forms.DataGridView();
            this.MediaDeleteButton = new System.Windows.Forms.Button();
            this.MediaUpdateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MediaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MediaLocationInput = new System.Windows.Forms.TextBox();
            this.MediaTypeSelect = new System.Windows.Forms.ComboBox();
            this.MediaDateLabel = new System.Windows.Forms.Label();
            this.MediaLocationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MediaResetButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SerachInput = new System.Windows.Forms.TextBox();
            this.SearchGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSPDataSet = new WindowsForms.TSPDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl2.SuspendLayout();
            this.MediaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MediaName
            // 
            this.MediaName.AutoSize = true;
            this.MediaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediaName.Location = new System.Drawing.Point(18, 18);
            this.MediaName.MinimumSize = new System.Drawing.Size(100, 2);
            this.MediaName.Name = "MediaName";
            this.MediaName.Size = new System.Drawing.Size(100, 15);
            this.MediaName.TabIndex = 1;
            this.MediaName.Text = "MediaName";
            this.MediaName.Click += new System.EventHandler(this.MediaName_Click);
            // 
            // MediaSaveButton
            // 
            this.MediaSaveButton.Location = new System.Drawing.Point(18, 225);
            this.MediaSaveButton.Name = "MediaSaveButton";
            this.MediaSaveButton.Size = new System.Drawing.Size(75, 23);
            this.MediaSaveButton.TabIndex = 2;
            this.MediaSaveButton.Text = "Create";
            this.MediaSaveButton.UseVisualStyleBackColor = true;
            this.MediaSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MediDescriptionLabel
            // 
            this.MediDescriptionLabel.AutoSize = true;
            this.MediDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediDescriptionLabel.Location = new System.Drawing.Point(17, 140);
            this.MediDescriptionLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.MediDescriptionLabel.Name = "MediDescriptionLabel";
            this.MediDescriptionLabel.Size = new System.Drawing.Size(100, 15);
            this.MediDescriptionLabel.TabIndex = 3;
            this.MediDescriptionLabel.Text = "Description";
            // 
            // MediaEventLabel
            // 
            this.MediaEventLabel.AutoSize = true;
            this.MediaEventLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediaEventLabel.Location = new System.Drawing.Point(18, 42);
            this.MediaEventLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.MediaEventLabel.Name = "MediaEventLabel";
            this.MediaEventLabel.Size = new System.Drawing.Size(100, 15);
            this.MediaEventLabel.TabIndex = 4;
            this.MediaEventLabel.Text = "Event";
            // 
            // MediaNameInput
            // 
            this.MediaNameInput.Location = new System.Drawing.Point(126, 15);
            this.MediaNameInput.Name = "MediaNameInput";
            this.MediaNameInput.Size = new System.Drawing.Size(100, 20);
            this.MediaNameInput.TabIndex = 5;
            // 
            // MediaDescriptionInput
            // 
            this.MediaDescriptionInput.Location = new System.Drawing.Point(126, 140);
            this.MediaDescriptionInput.Multiline = true;
            this.MediaDescriptionInput.Name = "MediaDescriptionInput";
            this.MediaDescriptionInput.Size = new System.Drawing.Size(210, 62);
            this.MediaDescriptionInput.TabIndex = 6;
            // 
            // MediaEventInput
            // 
            this.MediaEventInput.Location = new System.Drawing.Point(126, 39);
            this.MediaEventInput.Name = "MediaEventInput";
            this.MediaEventInput.Size = new System.Drawing.Size(100, 20);
            this.MediaEventInput.TabIndex = 7;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.MediaTab);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(12, 22);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1238, 640);
            this.tabControl2.TabIndex = 9;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // MediaTab
            // 
            this.MediaTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MediaTab.Controls.Add(this.pictureBox1);
            this.MediaTab.Controls.Add(this.ShouFileButton);
            this.MediaTab.Controls.Add(this.ChooseFile);
            this.MediaTab.Controls.Add(this.PersonsUpdateButton);
            this.MediaTab.Controls.Add(this.PersonCreateButton);
            this.MediaTab.Controls.Add(this.PersonNameInput);
            this.MediaTab.Controls.Add(this.PersonsGrid);
            this.MediaTab.Controls.Add(this.MediaDeleteButton);
            this.MediaTab.Controls.Add(this.MediaUpdateButton);
            this.MediaTab.Controls.Add(this.dataGridView1);
            this.MediaTab.Controls.Add(this.MediaDatePicker);
            this.MediaTab.Controls.Add(this.MediaLocationInput);
            this.MediaTab.Controls.Add(this.MediaTypeSelect);
            this.MediaTab.Controls.Add(this.MediaDateLabel);
            this.MediaTab.Controls.Add(this.MediaLocationLabel);
            this.MediaTab.Controls.Add(this.label1);
            this.MediaTab.Controls.Add(this.MediaResetButton);
            this.MediaTab.Controls.Add(this.MediaNameInput);
            this.MediaTab.Controls.Add(this.MediaSaveButton);
            this.MediaTab.Controls.Add(this.MediaEventInput);
            this.MediaTab.Controls.Add(this.MediaDescriptionInput);
            this.MediaTab.Controls.Add(this.MediaEventLabel);
            this.MediaTab.Controls.Add(this.MediaName);
            this.MediaTab.Controls.Add(this.MediDescriptionLabel);
            this.MediaTab.Location = new System.Drawing.Point(4, 22);
            this.MediaTab.Name = "MediaTab";
            this.MediaTab.Padding = new System.Windows.Forms.Padding(3);
            this.MediaTab.Size = new System.Drawing.Size(1230, 614);
            this.MediaTab.TabIndex = 0;
            this.MediaTab.Text = "Media";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(373, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // ShouFileButton
            // 
            this.ShouFileButton.Location = new System.Drawing.Point(18, 187);
            this.ShouFileButton.Name = "ShouFileButton";
            this.ShouFileButton.Size = new System.Drawing.Size(75, 23);
            this.ShouFileButton.TabIndex = 24;
            this.ShouFileButton.Text = "ShowFile";
            this.ShouFileButton.UseVisualStyleBackColor = true;
            this.ShouFileButton.Click += new System.EventHandler(this.ShouFileButton_Click);
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(17, 158);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(75, 23);
            this.ChooseFile.TabIndex = 23;
            this.ChooseFile.Text = "ChooseFile";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // PersonsUpdateButton
            // 
            this.PersonsUpdateButton.Location = new System.Drawing.Point(1121, 11);
            this.PersonsUpdateButton.Name = "PersonsUpdateButton";
            this.PersonsUpdateButton.Size = new System.Drawing.Size(51, 23);
            this.PersonsUpdateButton.TabIndex = 22;
            this.PersonsUpdateButton.Text = "Update";
            this.PersonsUpdateButton.UseVisualStyleBackColor = true;
            this.PersonsUpdateButton.Click += new System.EventHandler(this.PersonsUpdateButton_Click);
            // 
            // PersonCreateButton
            // 
            this.PersonCreateButton.Location = new System.Drawing.Point(1030, 13);
            this.PersonCreateButton.Name = "PersonCreateButton";
            this.PersonCreateButton.Size = new System.Drawing.Size(46, 23);
            this.PersonCreateButton.TabIndex = 21;
            this.PersonCreateButton.Text = "Create";
            this.PersonCreateButton.UseVisualStyleBackColor = true;
            this.PersonCreateButton.Click += new System.EventHandler(this.PersonCreateButton_Click);
            // 
            // PersonNameInput
            // 
            this.PersonNameInput.Location = new System.Drawing.Point(867, 13);
            this.PersonNameInput.Name = "PersonNameInput";
            this.PersonNameInput.Size = new System.Drawing.Size(123, 20);
            this.PersonNameInput.TabIndex = 20;
            this.PersonNameInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PersonNameInput_MouseDoubleClick);
            // 
            // PersonsGrid
            // 
            this.PersonsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsGrid.Location = new System.Drawing.Point(867, 49);
            this.PersonsGrid.Name = "PersonsGrid";
            this.PersonsGrid.Size = new System.Drawing.Size(328, 199);
            this.PersonsGrid.TabIndex = 19;
            this.PersonsGrid.DoubleClick += new System.EventHandler(this.PersonsGrid_DoubleClick);
            // 
            // MediaDeleteButton
            // 
            this.MediaDeleteButton.Location = new System.Drawing.Point(261, 225);
            this.MediaDeleteButton.Name = "MediaDeleteButton";
            this.MediaDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.MediaDeleteButton.TabIndex = 18;
            this.MediaDeleteButton.Text = "Delete";
            this.MediaDeleteButton.UseVisualStyleBackColor = true;
            this.MediaDeleteButton.Click += new System.EventHandler(this.MediaDeleteButton_Click);
            // 
            // MediaUpdateButton
            // 
            this.MediaUpdateButton.Location = new System.Drawing.Point(99, 225);
            this.MediaUpdateButton.Name = "MediaUpdateButton";
            this.MediaUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.MediaUpdateButton.TabIndex = 17;
            this.MediaUpdateButton.Text = "Update";
            this.MediaUpdateButton.UseVisualStyleBackColor = true;
            this.MediaUpdateButton.Click += new System.EventHandler(this.MediaUpdateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 304);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // MediaDatePicker
            // 
            this.MediaDatePicker.Location = new System.Drawing.Point(126, 87);
            this.MediaDatePicker.Name = "MediaDatePicker";
            this.MediaDatePicker.Size = new System.Drawing.Size(210, 20);
            this.MediaDatePicker.TabIndex = 15;
            // 
            // MediaLocationInput
            // 
            this.MediaLocationInput.Location = new System.Drawing.Point(126, 62);
            this.MediaLocationInput.Name = "MediaLocationInput";
            this.MediaLocationInput.Size = new System.Drawing.Size(100, 20);
            this.MediaLocationInput.TabIndex = 13;
            // 
            // MediaTypeSelect
            // 
            this.MediaTypeSelect.FormattingEnabled = true;
            this.MediaTypeSelect.Items.AddRange(new object[] {
            "photo",
            "video"});
            this.MediaTypeSelect.Location = new System.Drawing.Point(126, 111);
            this.MediaTypeSelect.Name = "MediaTypeSelect";
            this.MediaTypeSelect.Size = new System.Drawing.Size(121, 21);
            this.MediaTypeSelect.TabIndex = 12;
            this.MediaTypeSelect.Text = "Type";
            // 
            // MediaDateLabel
            // 
            this.MediaDateLabel.AutoSize = true;
            this.MediaDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediaDateLabel.Location = new System.Drawing.Point(17, 92);
            this.MediaDateLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.MediaDateLabel.Name = "MediaDateLabel";
            this.MediaDateLabel.Size = new System.Drawing.Size(100, 15);
            this.MediaDateLabel.TabIndex = 11;
            this.MediaDateLabel.Text = "Date";
            // 
            // MediaLocationLabel
            // 
            this.MediaLocationLabel.AutoSize = true;
            this.MediaLocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediaLocationLabel.Location = new System.Drawing.Point(18, 67);
            this.MediaLocationLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.MediaLocationLabel.Name = "MediaLocationLabel";
            this.MediaLocationLabel.Size = new System.Drawing.Size(100, 15);
            this.MediaLocationLabel.TabIndex = 10;
            this.MediaLocationLabel.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(17, 117);
            this.label1.MinimumSize = new System.Drawing.Size(100, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            // 
            // MediaResetButton
            // 
            this.MediaResetButton.Location = new System.Drawing.Point(180, 225);
            this.MediaResetButton.Name = "MediaResetButton";
            this.MediaResetButton.Size = new System.Drawing.Size(75, 23);
            this.MediaResetButton.TabIndex = 8;
            this.MediaResetButton.Text = "Reset";
            this.MediaResetButton.UseVisualStyleBackColor = true;
            this.MediaResetButton.Click += new System.EventHandler(this.MediaResetButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SearchLabel);
            this.tabPage3.Controls.Add(this.SerachInput);
            this.tabPage3.Controls.Add(this.SearchGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1230, 614);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Serach";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchLabel.Location = new System.Drawing.Point(19, 24);
            this.SearchLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(100, 15);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Serach Input";
            // 
            // SerachInput
            // 
            this.SerachInput.Location = new System.Drawing.Point(19, 54);
            this.SerachInput.Name = "SerachInput";
            this.SerachInput.Size = new System.Drawing.Size(351, 20);
            this.SerachInput.TabIndex = 1;
            this.SerachInput.TextChanged += new System.EventHandler(this.SerachInput_TextChanged);
            // 
            // SearchGrid
            // 
            this.SearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGrid.Location = new System.Drawing.Point(19, 99);
            this.SearchGrid.Name = "SearchGrid";
            this.SearchGrid.Size = new System.Drawing.Size(827, 256);
            this.SearchGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tSPDataSet
            // 
            this.tSPDataSet.DataSetName = "TSPDataSet";
            this.tSPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tsp Proj";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.MediaTab.ResumeLayout(false);
            this.MediaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label MediaName;
        private System.Windows.Forms.Button MediaSaveButton;
        private System.Windows.Forms.Label MediDescriptionLabel;
        private System.Windows.Forms.Label MediaEventLabel;
        private System.Windows.Forms.TextBox MediaNameInput;
        private System.Windows.Forms.TextBox MediaDescriptionInput;
        private System.Windows.Forms.TextBox MediaEventInput;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage MediaTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button MediaResetButton;
        private System.Windows.Forms.ComboBox MediaTypeSelect;
        private System.Windows.Forms.Label MediaDateLabel;
        private System.Windows.Forms.Label MediaLocationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker MediaDatePicker;
        private System.Windows.Forms.TextBox MediaLocationInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private TSPDataSet tSPDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MediaUpdateButton;
        private System.Windows.Forms.Button MediaDeleteButton;
        private System.Windows.Forms.DataGridView PersonsGrid;
        private System.Windows.Forms.TextBox PersonNameInput;
        private System.Windows.Forms.Button PersonCreateButton;
        private System.Windows.Forms.Button PersonsUpdateButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Button ShouFileButton;
        private System.Windows.Forms.DataGridView SearchGrid;
        private System.Windows.Forms.TextBox SerachInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

