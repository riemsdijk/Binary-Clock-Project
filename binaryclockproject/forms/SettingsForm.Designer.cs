namespace binaryclockproject
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundPB = new System.Windows.Forms.PictureBox();
            this.falsePB = new System.Windows.Forms.PictureBox();
            this.secondPB = new System.Windows.Forms.PictureBox();
            this.minutePB = new System.Windows.Forms.PictureBox();
            this.hourPB = new System.Windows.Forms.PictureBox();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falsePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPB)).BeginInit();
            this.TabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Location = new System.Drawing.Point(6, 20);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(182, 17);
            this.startupCheckBox.TabIndex = 1;
            this.startupCheckBox.Text = "Run the application automatically";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundPB
            // 
            this.backgroundPB.Location = new System.Drawing.Point(167, 69);
            this.backgroundPB.Name = "backgroundPB";
            this.backgroundPB.Size = new System.Drawing.Size(100, 21);
            this.backgroundPB.TabIndex = 4;
            this.backgroundPB.TabStop = false;
            this.backgroundPB.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // falsePB
            // 
            this.falsePB.Location = new System.Drawing.Point(167, 19);
            this.falsePB.Name = "falsePB";
            this.falsePB.Size = new System.Drawing.Size(100, 21);
            this.falsePB.TabIndex = 3;
            this.falsePB.TabStop = false;
            this.falsePB.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // secondPB
            // 
            this.secondPB.Location = new System.Drawing.Point(9, 121);
            this.secondPB.Name = "secondPB";
            this.secondPB.Size = new System.Drawing.Size(100, 21);
            this.secondPB.TabIndex = 2;
            this.secondPB.TabStop = false;
            this.secondPB.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // minutePB
            // 
            this.minutePB.Location = new System.Drawing.Point(9, 69);
            this.minutePB.Name = "minutePB";
            this.minutePB.Size = new System.Drawing.Size(100, 21);
            this.minutePB.TabIndex = 1;
            this.minutePB.TabStop = false;
            this.minutePB.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // hourPB
            // 
            this.hourPB.Location = new System.Drawing.Point(9, 19);
            this.hourPB.Name = "hourPB";
            this.hourPB.Size = new System.Drawing.Size(100, 21);
            this.hourPB.TabIndex = 0;
            this.hourPB.TabStop = false;
            this.hourPB.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.tabPage1);
            this.TabPage.Controls.Add(this.tabPage2);
            this.TabPage.Location = new System.Drawing.Point(12, 12);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(290, 199);
            this.TabPage.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.backgroundPB);
            this.tabPage1.Controls.Add(this.hourPB);
            this.tabPage1.Controls.Add(this.falsePB);
            this.tabPage1.Controls.Add(this.minutePB);
            this.tabPage1.Controls.Add(this.secondPB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Colors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(167, 122);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Opacity [%]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color of backgroud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color of binary \"False\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color of Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color of Minute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color of Hour";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.startupCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(282, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(30, 217);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(192, 217);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.TabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings : Binary Clock Project";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falsePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPB)).EndInit();
            this.TabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.PictureBox falsePB;
        private System.Windows.Forms.PictureBox secondPB;
        private System.Windows.Forms.PictureBox minutePB;
        private System.Windows.Forms.PictureBox hourPB;
        private System.Windows.Forms.PictureBox backgroundPB;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}