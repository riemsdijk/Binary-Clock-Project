/*
The MIT License (MIT)

Copyright (c) 2016 Damian Riemsdijk
*/

using System;
using System.Windows.Forms;

namespace binaryclockproject
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process browser = new System.Diagnostics.Process();

            try
            {
                browser.StartInfo.UseShellExecute = true;
                browser.StartInfo.FileName = "https://github.com/HarailtDark-Cub/Binary-Clock-Project";
                browser.Start();
            }
            catch(Exception ce)
            {
                MessageBox.Show(ce.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
