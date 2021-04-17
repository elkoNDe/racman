﻿
namespace racman
{
    partial class RAC1Form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button5 = new System.Windows.Forms.Button();
            this.gbsreset = new System.Windows.Forms.Button();
            this.ghostrac = new System.Windows.Forms.Button();
            this.killyourself = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loadpos = new System.Windows.Forms.Button();
            this.loadPlanetButton = new System.Windows.Forms.Button();
            this.savepos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.positions_comboBox = new System.Windows.Forms.ComboBox();
            this.planets_comboBox = new System.Windows.Forms.ComboBox();
            this.unlockGoldBoltsButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bolts_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unlocksWindowButton = new System.Windows.Forms.Button();
            this.infHealth = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(341, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // gbsreset
            // 
            this.gbsreset.Location = new System.Drawing.Point(227, 80);
            this.gbsreset.Name = "gbsreset";
            this.gbsreset.Size = new System.Drawing.Size(135, 23);
            this.gbsreset.TabIndex = 11;
            this.gbsreset.Text = "Reset All Gold Bolts";
            this.gbsreset.UseVisualStyleBackColor = true;
            this.gbsreset.Click += new System.EventHandler(this.gbsreset_Click);
            // 
            // ghostrac
            // 
            this.ghostrac.Location = new System.Drawing.Point(227, 109);
            this.ghostrac.Name = "ghostrac";
            this.ghostrac.Size = new System.Drawing.Size(135, 23);
            this.ghostrac.TabIndex = 8;
            this.ghostrac.Text = "Ghost Ratchet";
            this.ghostrac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ghostrac.UseVisualStyleBackColor = true;
            this.ghostrac.Click += new System.EventHandler(this.ghostrac_Click);
            // 
            // killyourself
            // 
            this.killyourself.Location = new System.Drawing.Point(12, 81);
            this.killyourself.Name = "killyourself";
            this.killyourself.Size = new System.Drawing.Size(115, 23);
            this.killyourself.TabIndex = 7;
            this.killyourself.Text = "Die";
            this.killyourself.UseVisualStyleBackColor = true;
            this.killyourself.Click += new System.EventHandler(this.killyourself_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // loadpos
            // 
            this.loadpos.Location = new System.Drawing.Point(12, 52);
            this.loadpos.Name = "loadpos";
            this.loadpos.Size = new System.Drawing.Size(115, 23);
            this.loadpos.TabIndex = 1;
            this.loadpos.Text = "Load Position";
            this.loadpos.UseVisualStyleBackColor = true;
            this.loadpos.Click += new System.EventHandler(this.loadPosButton_Click);
            // 
            // loadPlanetButton
            // 
            this.loadPlanetButton.Location = new System.Drawing.Point(133, 130);
            this.loadPlanetButton.Name = "loadPlanetButton";
            this.loadPlanetButton.Size = new System.Drawing.Size(75, 23);
            this.loadPlanetButton.TabIndex = 14;
            this.loadPlanetButton.Text = "Load";
            this.loadPlanetButton.UseVisualStyleBackColor = true;
            this.loadPlanetButton.Click += new System.EventHandler(this.loadPlanetButton_Click_1);
            // 
            // savepos
            // 
            this.savepos.Location = new System.Drawing.Point(12, 23);
            this.savepos.Name = "savepos";
            this.savepos.Size = new System.Drawing.Size(115, 23);
            this.savepos.TabIndex = 0;
            this.savepos.Text = "Save Position";
            this.savepos.UseVisualStyleBackColor = true;
            this.savepos.Click += new System.EventHandler(this.savePosButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 21;
            // 
            // positions_comboBox
            // 
            this.positions_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positions_comboBox.FormattingEnabled = true;
            this.positions_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.positions_comboBox.Location = new System.Drawing.Point(133, 25);
            this.positions_comboBox.Name = "positions_comboBox";
            this.positions_comboBox.Size = new System.Drawing.Size(75, 21);
            this.positions_comboBox.TabIndex = 27;
            // 
            // planets_comboBox
            // 
            this.planets_comboBox.FormattingEnabled = true;
            this.planets_comboBox.Items.AddRange(new object[] {
            "Veldin",
            "Novalis",
            "Aridia",
            "Kerwan",
            "Eudora",
            "Rilgar",
            "Blarg",
            "Umbris",
            "Batalia",
            "Gaspar",
            "Orxon",
            "Pokitaru",
            "Hoven",
            "Gemlik",
            "Oltanis",
            "Quartu",
            "Kalebo III",
            "Fleet",
            "Veldin 2"});
            this.planets_comboBox.Location = new System.Drawing.Point(15, 132);
            this.planets_comboBox.Name = "planets_comboBox";
            this.planets_comboBox.Size = new System.Drawing.Size(112, 21);
            this.planets_comboBox.TabIndex = 28;
            this.planets_comboBox.SelectedIndexChanged += new System.EventHandler(this.planets_comboBox_SelectedIndexChanged);
            // 
            // unlockGoldBoltsButton
            // 
            this.unlockGoldBoltsButton.Location = new System.Drawing.Point(228, 51);
            this.unlockGoldBoltsButton.Name = "unlockGoldBoltsButton";
            this.unlockGoldBoltsButton.Size = new System.Drawing.Size(135, 23);
            this.unlockGoldBoltsButton.TabIndex = 31;
            this.unlockGoldBoltsButton.Text = "Unlock All Gold  Bolts";
            this.unlockGoldBoltsButton.UseVisualStyleBackColor = true;
            this.unlockGoldBoltsButton.Click += new System.EventHandler(this.unlockGoldBoltsButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 41;
            // 
            // bolts_textBox
            // 
            this.bolts_textBox.Location = new System.Drawing.Point(228, 25);
            this.bolts_textBox.Name = "bolts_textBox";
            this.bolts_textBox.Size = new System.Drawing.Size(135, 20);
            this.bolts_textBox.TabIndex = 62;
            this.bolts_textBox.TextChanged += new System.EventHandler(this.bolts_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Load Planet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Bolt Count:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // unlocksWindowButton
            // 
            this.unlocksWindowButton.Location = new System.Drawing.Point(227, 180);
            this.unlocksWindowButton.Name = "unlocksWindowButton";
            this.unlocksWindowButton.Size = new System.Drawing.Size(75, 23);
            this.unlocksWindowButton.TabIndex = 72;
            this.unlocksWindowButton.Text = "Unlocks";
            this.unlocksWindowButton.UseVisualStyleBackColor = true;
            this.unlocksWindowButton.Click += new System.EventHandler(this.unlocksWindowButton_Click);
            // 
            // infHealth
            // 
            this.infHealth.AutoSize = true;
            this.infHealth.Location = new System.Drawing.Point(227, 152);
            this.infHealth.Name = "infHealth";
            this.infHealth.Size = new System.Drawing.Size(91, 17);
            this.infHealth.TabIndex = 70;
            this.infHealth.Text = "Infinite Health";
            this.infHealth.UseVisualStyleBackColor = true;
            this.infHealth.CheckedChanged += new System.EventHandler(this.infHealth_Checkbox_Changed);
            // 
            // RAC1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 231);
            this.Controls.Add(this.unlocksWindowButton);
            this.Controls.Add(this.infHealth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbsreset);
            this.Controls.Add(this.bolts_textBox);
            this.Controls.Add(this.ghostrac);
            this.Controls.Add(this.killyourself);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadpos);
            this.Controls.Add(this.loadPlanetButton);
            this.Controls.Add(this.savepos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.positions_comboBox);
            this.Controls.Add(this.planets_comboBox);
            this.Controls.Add(this.unlockGoldBoltsButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RAC1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratchet & Clank 1 - NPEA00385 (PAL)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button gbsreset;
        private System.Windows.Forms.Button ghostrac;
        private System.Windows.Forms.Button killyourself;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadpos;
        private System.Windows.Forms.Button loadPlanetButton;
        private System.Windows.Forms.Button savepos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox positions_comboBox;
        private System.Windows.Forms.ComboBox planets_comboBox;
        private System.Windows.Forms.Button unlockGoldBoltsButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bolts_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button unlocksWindowButton;
        private System.Windows.Forms.CheckBox infHealth;
    }
}

