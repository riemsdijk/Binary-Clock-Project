/*
The MIT License (MIT)

Copyright (c) 2016 Damian Riemsdijk
*/
using System;
using System.Windows.Forms;

namespace binaryclockproject
{
    public partial class MainForm : Form
    {
        
        private GraphicalPresentation[] graphicForHour = new GraphicalPresentation[2];
        private GraphicalPresentation[] graphicForMinute = new GraphicalPresentation[2];
        private GraphicalPresentation[] graphicForSecond = new GraphicalPresentation[2];

        private BinaryTime time;

        public MainForm()
        {
            InitializeComponent();

            time = new BinaryTime();
            time.UpdateTime();

            graphicForHour[0] = new GraphicalPresentation(new PictureBox[] { hourTensPB1, hourTensPB2 }, Properties.Settings.Default.hourColor, Properties.Settings.Default.falseColor);
            graphicForHour[1] = new GraphicalPresentation(new PictureBox[] { hourOnesPB1, hourOnesPB2, hourOnesPB3, hourOnesPB4 }, Properties.Settings.Default.hourColor, Properties.Settings.Default.falseColor);

            graphicForMinute[0] = new GraphicalPresentation(new PictureBox[] { minuteTensPB1, minuteTensPB2, minuteTensPB3 }, Properties.Settings.Default.minuteColor, Properties.Settings.Default.falseColor);
            graphicForMinute[1] = new GraphicalPresentation(new PictureBox[] { minuteOnesPB1, minuteOnesPB2, minuteOnesPB3, minuteOnesPB4 }, Properties.Settings.Default.minuteColor, Properties.Settings.Default.falseColor);

            graphicForSecond[0] = new GraphicalPresentation(new PictureBox[] { secondTensPB1, secondTensPB2, secondTensPB3 }, Properties.Settings.Default.secondColor, Properties.Settings.Default.falseColor);
            graphicForSecond[1] = new GraphicalPresentation(new PictureBox[] { secondOnesPB1, secondOnesPB2, secondOnesPB3, secondOnesPB4 }, Properties.Settings.Default.secondColor, Properties.Settings.Default.falseColor);

            MainForm_UpdateComponent();
            timer.Start();

        }

        private void MainForm_UpdateComponent()
        {
            //Update labels
            hourTensLabel.Text = time.Hour.Tens.ToString();
            hourOnesLabel.Text = time.Hour.Ones.ToString();

            minuteTensLabel.Text = time.Minute.Tens.ToString();
            minuteOnesLabel.Text = time.Minute.Ones.ToString();

            secondTensLabel.Text = time.Second.Tens.ToString();
            secondOnesLabel.Text = time.Second.Ones.ToString();

            //Update graphics
            graphicForHour[0].SetValue(time.BinaryHour.Tens);
            graphicForHour[1].SetValue(time.BinaryHour.Ones);

            graphicForMinute[0].SetValue(time.BinaryMinute.Tens);
            graphicForMinute[1].SetValue(time.BinaryMinute.Ones);

            graphicForSecond[0].SetValue(time.BinarySecond.Tens);
            graphicForSecond[1].SetValue(time.BinarySecond.Ones);
        }

        //Form events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(Properties.Settings.Default.Location.X, Properties.Settings.Default.Location.Y);
            this.Opacity = Properties.Settings.Default.opacity;
            this.FormBorderStyle = Properties.Settings.Default.borderStyle;
            this.BackColor = Properties.Settings.Default.backgroundColor;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;

            if (this.FormBorderStyle == FormBorderStyle.FixedToolWindow)
                menuTitlebar.Checked = true;
            else
                menuTitlebar.Checked = false;
               
            
            menu.Show(this.DesktopLocation.X + e.X, this.DesktopLocation.Y + e.Y);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.borderStyle = this.FormBorderStyle;
            Properties.Settings.Default.Save();
        }

        // Timer event
        private void timer_Tick(object sender, EventArgs e)
        {
            time.UpdateTime();
            MainForm_UpdateComponent();
        }

        // Menu items events
        private void menuTitlebar_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            else
                this.FormBorderStyle = FormBorderStyle.None;
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
