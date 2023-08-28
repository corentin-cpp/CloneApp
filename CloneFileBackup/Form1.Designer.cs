namespace CloneFileBackup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox_pathOrig = new TextBox();
            textBox_pathDest = new TextBox();
            button_selectOrig = new Button();
            button_selectDest = new Button();
            dataGridView1 = new DataGridView();
            NameBackup = new DataGridViewTextBoxColumn();
            PathOrigin = new DataGridViewTextBoxColumn();
            PathDestination = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button_confirm = new Button();
            button_execute = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_pathOrig
            // 
            textBox_pathOrig.Location = new Point(12, 60);
            textBox_pathOrig.Name = "textBox_pathOrig";
            textBox_pathOrig.Size = new Size(290, 23);
            textBox_pathOrig.TabIndex = 0;
            textBox_pathOrig.Text = "Select Path Origin";
            // 
            // textBox_pathDest
            // 
            textBox_pathDest.Location = new Point(12, 99);
            textBox_pathDest.Name = "textBox_pathDest";
            textBox_pathDest.Size = new Size(290, 23);
            textBox_pathDest.TabIndex = 1;
            textBox_pathDest.Text = "Select Path Destination";
            // 
            // button_selectOrig
            // 
            button_selectOrig.Location = new Point(308, 60);
            button_selectOrig.Name = "button_selectOrig";
            button_selectOrig.Size = new Size(35, 23);
            button_selectOrig.TabIndex = 2;
            button_selectOrig.Text = "...";
            button_selectOrig.UseVisualStyleBackColor = true;
            button_selectOrig.Click += button_selectOrig_Click;
            // 
            // button_selectDest
            // 
            button_selectDest.Location = new Point(308, 99);
            button_selectDest.Name = "button_selectDest";
            button_selectDest.Size = new Size(35, 23);
            button_selectDest.TabIndex = 3;
            button_selectDest.Text = "...";
            button_selectDest.UseVisualStyleBackColor = true;
            button_selectDest.Click += button_selectDest_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameBackup, PathOrigin, PathDestination });
            dataGridView1.Location = new Point(389, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(790, 330);
            dataGridView1.TabIndex = 4;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // NameBackup
            // 
            NameBackup.DataPropertyName = "NameBackup";
            NameBackup.HeaderText = "Backup Name";
            NameBackup.Name = "NameBackup";
            NameBackup.ReadOnly = true;
            NameBackup.Width = 150;
            // 
            // PathOrigin
            // 
            PathOrigin.DataPropertyName = "PathOrigin";
            PathOrigin.HeaderText = "Path Origin";
            PathOrigin.Name = "PathOrigin";
            PathOrigin.ReadOnly = true;
            PathOrigin.Width = 300;
            // 
            // PathDestination
            // 
            PathDestination.DataPropertyName = "PathDestination";
            PathDestination.HeaderText = "Path Destination";
            PathDestination.Name = "PathDestination";
            PathDestination.ReadOnly = true;
            PathDestination.Width = 300;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Backup Name";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button_confirm
            // 
            button_confirm.Location = new Point(73, 128);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(79, 23);
            button_confirm.TabIndex = 6;
            button_confirm.Text = "Confirm";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // button_execute
            // 
            button_execute.Location = new Point(158, 128);
            button_execute.Name = "button_execute";
            button_execute.Size = new Size(79, 23);
            button_execute.TabIndex = 7;
            button_execute.Text = "Execute";
            button_execute.UseVisualStyleBackColor = true;
            button_execute.Click += button_execute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 354);
            Controls.Add(button_execute);
            Controls.Add(button_confirm);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button_selectDest);
            Controls.Add(button_selectOrig);
            Controls.Add(textBox_pathDest);
            Controls.Add(textBox_pathOrig);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1216, 393);
            MinimumSize = new Size(1216, 393);
            Name = "Form1";
            Text = "Clone FIle Backup";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox_pathOrig;
        private TextBox textBox_pathDest;
        private Button button_selectOrig;
        private Button button_selectDest;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button_confirm;
        private DataGridViewTextBoxColumn NameBackup;
        private DataGridViewTextBoxColumn PathOrigin;
        private DataGridViewTextBoxColumn PathDestination;
        private Button button_execute;
    }
}