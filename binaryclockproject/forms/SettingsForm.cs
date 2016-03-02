/*
The MIT License (MIT)

Copyright (c) 2016 Damian Riemsdijk
*/

using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace binaryclockproject
{
    public partial class SettingsForm : Form
    {
        RegistryKey registrykey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (registrykey.GetValue("binaryclockproject") == null)
                startupCheckBox.Checked = false;
            else
                startupCheckBox.Checked = true;

            //
            hourPB.BackColor = Properties.Settings.Default.hourColor;
            minutePB.BackColor = Properties.Settings.Default.minuteColor;
            secondPB.BackColor = Properties.Settings.Default.secondColor;
            falsePB.BackColor = Properties.Settings.Default.falseColor;
            backgroundPB.BackColor = Properties.Settings.Default.backgroundColor;

            numericUpDown.Value = (int)(Properties.Settings.Default.opacity * 100);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.hourColor = hourPB.BackColor;
            Properties.Settings.Default.minuteColor = minutePB.BackColor;
            Properties.Settings.Default.secondColor = secondPB.BackColor;
            Properties.Settings.Default.falseColor = falsePB.BackColor;
            Properties.Settings.Default.backgroundColor = backgroundPB.BackColor;
            Properties.Settings.Default.opacity = (double)(numericUpDown.Value / 100);
            Properties.Settings.Default.Save();

            try
            {
                if (startupCheckBox.Checked)
                    registrykey.SetValue("binaryclockproject", Application.ExecutablePath.ToString());
                else
                    registrykey.DeleteValue("binaryclockproject", false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("You need to run this application to see effect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picturebox = (PictureBox)sender;

            ColorDialog colordialog = new ColorDialog();

            if (colordialog.ShowDialog() == DialogResult.OK)
                picturebox.BackColor = colordialog.Color;
        }
    }
}
