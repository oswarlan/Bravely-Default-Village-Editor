namespace Bravely_Default_Save_Editor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VillagerCountLabel = new System.Windows.Forms.Label();
            this.VillagerCountDisplay = new System.Windows.Forms.Label();
            this.NewVillagerCountInput = new System.Windows.Forms.TextBox();
            this.VillageBuildingNewLevel1 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel2 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel3 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel4 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel5 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel6 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel7 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel8 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel9 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel10 = new System.Windows.Forms.ComboBox();
            this.VillageBuildingNewLevel11 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // VillagerCountLabel
            // 
            this.VillagerCountLabel.AutoSize = true;
            this.VillagerCountLabel.Location = new System.Drawing.Point(276, 160);
            this.VillagerCountLabel.Name = "VillagerCountLabel";
            this.VillagerCountLabel.Size = new System.Drawing.Size(46, 13);
            this.VillagerCountLabel.TabIndex = 1;
            this.VillagerCountLabel.Text = "Villagers";
            // 
            // VillagerCountDisplay
            // 
            this.VillagerCountDisplay.AutoSize = true;
            this.VillagerCountDisplay.Location = new System.Drawing.Point(390, 160);
            this.VillagerCountDisplay.Name = "VillagerCountDisplay";
            this.VillagerCountDisplay.Size = new System.Drawing.Size(13, 13);
            this.VillagerCountDisplay.TabIndex = 2;
            this.VillagerCountDisplay.Text = "0";
            // 
            // NewVillagerCountInput
            // 
            this.NewVillagerCountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewVillagerCountInput.Location = new System.Drawing.Point(419, 163);
            this.NewVillagerCountInput.MaxLength = 3;
            this.NewVillagerCountInput.Name = "NewVillagerCountInput";
            this.NewVillagerCountInput.Size = new System.Drawing.Size(121, 20);
            this.NewVillagerCountInput.TabIndex = 3;
            this.NewVillagerCountInput.TextChanged += new System.EventHandler(this.NewVillagerCountInput_TextChanged);
            // 
            // VillageBuildingNewLevel1
            // 
            this.VillageBuildingNewLevel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel1.FormattingEnabled = true;
            this.VillageBuildingNewLevel1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel1.Location = new System.Drawing.Point(147, 21);
            this.VillageBuildingNewLevel1.Name = "VillageBuildingNewLevel1";
            this.VillageBuildingNewLevel1.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel1.TabIndex = 4;
            this.VillageBuildingNewLevel1.UseWaitCursor = true;
            this.VillageBuildingNewLevel1.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel1_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel2
            // 
            this.VillageBuildingNewLevel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel2.FormattingEnabled = true;
            this.VillageBuildingNewLevel2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel2.Location = new System.Drawing.Point(147, 48);
            this.VillageBuildingNewLevel2.Name = "VillageBuildingNewLevel2";
            this.VillageBuildingNewLevel2.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel2.TabIndex = 5;
            this.VillageBuildingNewLevel2.UseWaitCursor = true;
            this.VillageBuildingNewLevel2.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel2_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel3
            // 
            this.VillageBuildingNewLevel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel3.FormattingEnabled = true;
            this.VillageBuildingNewLevel3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel3.Location = new System.Drawing.Point(147, 75);
            this.VillageBuildingNewLevel3.Name = "VillageBuildingNewLevel3";
            this.VillageBuildingNewLevel3.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel3.TabIndex = 6;
            this.VillageBuildingNewLevel3.UseWaitCursor = true;
            this.VillageBuildingNewLevel3.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel3_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel4
            // 
            this.VillageBuildingNewLevel4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel4.FormattingEnabled = true;
            this.VillageBuildingNewLevel4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel4.Location = new System.Drawing.Point(147, 102);
            this.VillageBuildingNewLevel4.Name = "VillageBuildingNewLevel4";
            this.VillageBuildingNewLevel4.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel4.TabIndex = 7;
            this.VillageBuildingNewLevel4.UseWaitCursor = true;
            this.VillageBuildingNewLevel4.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel4_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel5
            // 
            this.VillageBuildingNewLevel5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel5.FormattingEnabled = true;
            this.VillageBuildingNewLevel5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel5.Location = new System.Drawing.Point(147, 129);
            this.VillageBuildingNewLevel5.Name = "VillageBuildingNewLevel5";
            this.VillageBuildingNewLevel5.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel5.TabIndex = 8;
            this.VillageBuildingNewLevel5.UseWaitCursor = true;
            this.VillageBuildingNewLevel5.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel5_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel6
            // 
            this.VillageBuildingNewLevel6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel6.FormattingEnabled = true;
            this.VillageBuildingNewLevel6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel6.Location = new System.Drawing.Point(147, 156);
            this.VillageBuildingNewLevel6.Name = "VillageBuildingNewLevel6";
            this.VillageBuildingNewLevel6.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel6.TabIndex = 9;
            this.VillageBuildingNewLevel6.UseWaitCursor = true;
            this.VillageBuildingNewLevel6.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel6_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel7
            // 
            this.VillageBuildingNewLevel7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel7.FormattingEnabled = true;
            this.VillageBuildingNewLevel7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel7.Location = new System.Drawing.Point(419, 27);
            this.VillageBuildingNewLevel7.Name = "VillageBuildingNewLevel7";
            this.VillageBuildingNewLevel7.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel7.TabIndex = 10;
            this.VillageBuildingNewLevel7.UseWaitCursor = true;
            this.VillageBuildingNewLevel7.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel7_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel8
            // 
            this.VillageBuildingNewLevel8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel8.FormattingEnabled = true;
            this.VillageBuildingNewLevel8.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel8.Location = new System.Drawing.Point(419, 54);
            this.VillageBuildingNewLevel8.Name = "VillageBuildingNewLevel8";
            this.VillageBuildingNewLevel8.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel8.TabIndex = 11;
            this.VillageBuildingNewLevel8.UseWaitCursor = true;
            this.VillageBuildingNewLevel8.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel8_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel9
            // 
            this.VillageBuildingNewLevel9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel9.FormattingEnabled = true;
            this.VillageBuildingNewLevel9.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel9.Location = new System.Drawing.Point(419, 81);
            this.VillageBuildingNewLevel9.Name = "VillageBuildingNewLevel9";
            this.VillageBuildingNewLevel9.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel9.TabIndex = 12;
            this.VillageBuildingNewLevel9.UseWaitCursor = true;
            this.VillageBuildingNewLevel9.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel9_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel10
            // 
            this.VillageBuildingNewLevel10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel10.FormattingEnabled = true;
            this.VillageBuildingNewLevel10.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel10.Location = new System.Drawing.Point(419, 108);
            this.VillageBuildingNewLevel10.Name = "VillageBuildingNewLevel10";
            this.VillageBuildingNewLevel10.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel10.TabIndex = 13;
            this.VillageBuildingNewLevel10.UseWaitCursor = true;
            this.VillageBuildingNewLevel10.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel10_SelectedIndexChanged);
            // 
            // VillageBuildingNewLevel11
            // 
            this.VillageBuildingNewLevel11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageBuildingNewLevel11.FormattingEnabled = true;
            this.VillageBuildingNewLevel11.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.VillageBuildingNewLevel11.Location = new System.Drawing.Point(419, 135);
            this.VillageBuildingNewLevel11.Name = "VillageBuildingNewLevel11";
            this.VillageBuildingNewLevel11.Size = new System.Drawing.Size(121, 21);
            this.VillageBuildingNewLevel11.TabIndex = 14;
            this.VillageBuildingNewLevel11.UseWaitCursor = true;
            this.VillageBuildingNewLevel11.SelectedIndexChanged += new System.EventHandler(this.VillageBuildingNewLevel11_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Special Move Shop Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hill Parts Shop Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cape Parts Shop Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "River Parts Shop Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Valley Parts Shop Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Weapons Shop Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Armor Shop Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Accessory Shop Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Trader Level";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Combat Item Shop Level";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Compound Shop Level";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 195);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VillageBuildingNewLevel11);
            this.Controls.Add(this.VillageBuildingNewLevel10);
            this.Controls.Add(this.VillageBuildingNewLevel9);
            this.Controls.Add(this.VillageBuildingNewLevel8);
            this.Controls.Add(this.VillageBuildingNewLevel7);
            this.Controls.Add(this.VillageBuildingNewLevel6);
            this.Controls.Add(this.VillageBuildingNewLevel5);
            this.Controls.Add(this.VillageBuildingNewLevel4);
            this.Controls.Add(this.VillageBuildingNewLevel3);
            this.Controls.Add(this.VillageBuildingNewLevel2);
            this.Controls.Add(this.VillageBuildingNewLevel1);
            this.Controls.Add(this.NewVillagerCountInput);
            this.Controls.Add(this.VillagerCountDisplay);
            this.Controls.Add(this.VillagerCountLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Bravely Default Village Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox NewVillagerCountInput;
        private System.Windows.Forms.Label VillagerCountDisplay;
        private System.Windows.Forms.Label VillagerCountLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel11;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel10;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel9;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel8;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel7;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel6;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel5;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel4;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel3;
        private System.Windows.Forms.ComboBox VillageBuildingNewLevel2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

