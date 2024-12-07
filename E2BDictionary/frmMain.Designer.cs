namespace E2BDictionary
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            findWordTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            wordGridView = new DataGridView();
            SL = new DataGridViewTextBoxColumn();
            English = new DataGridViewTextBoxColumn();
            Bangla = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wordGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, findToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(780, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(42, 20);
            findToolStripMenuItem.Text = "Find";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(findWordTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 44);
            panel1.TabIndex = 1;
            // 
            // findWordTextBox
            // 
            findWordTextBox.Location = new Point(107, 10);
            findWordTextBox.Name = "findWordTextBox";
            findWordTextBox.Size = new Size(237, 25);
            findWordTextBox.TabIndex = 1;
            findWordTextBox.TextChanged += findWordTextBox_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(468, 13);
            label2.Name = "label2";
            label2.Size = new Size(307, 17);
            label2.TabIndex = 0;
            label2.Text = "Bangla Dictionary With Bangla && English Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 0;
            label1.Text = "Find Word";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 37);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(560, 9);
            label4.Name = "label4";
            label4.Size = new Size(215, 17);
            label4.TabIndex = 0;
            label4.Text = "Mail To: salehabu244@gmail.com";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(156, 17);
            label3.TabIndex = 0;
            label3.Text = "Web Site: abusaleh.com";
            // 
            // wordGridView
            // 
            wordGridView.AllowUserToAddRows = false;
            wordGridView.AllowUserToDeleteRows = false;
            wordGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wordGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            wordGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wordGridView.Columns.AddRange(new DataGridViewColumn[] { SL, English, Bangla, Details });
            wordGridView.Location = new Point(0, 68);
            wordGridView.Name = "wordGridView";
            wordGridView.ReadOnly = true;
            wordGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wordGridView.Size = new Size(780, 353);
            wordGridView.TabIndex = 3;
            // 
            // SL
            // 
            SL.DataPropertyName = "SL";
            SL.FillWeight = 40.60914F;
            SL.HeaderText = "SL";
            SL.Name = "SL";
            SL.ReadOnly = true;
            // 
            // English
            // 
            English.DataPropertyName = "En";
            English.FillWeight = 119.796951F;
            English.HeaderText = "English";
            English.Name = "English";
            English.ReadOnly = true;
            // 
            // Bangla
            // 
            Bangla.DataPropertyName = "Bn";
            Bangla.FillWeight = 119.796951F;
            Bangla.HeaderText = "Bangla";
            Bangla.Name = "Bangla";
            Bangla.ReadOnly = true;
            // 
            // Details
            // 
            Details.DataPropertyName = "Details";
            Details.FillWeight = 119.796951F;
            Details.HeaderText = "Details";
            Details.Name = "Details";
            Details.ReadOnly = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(wordGridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E2B Dictionary";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wordGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private TextBox findWordTextBox;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private DataGridView wordGridView;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn English;
        private DataGridViewTextBoxColumn Bangla;
        private DataGridViewTextBoxColumn Details;
    }
}
