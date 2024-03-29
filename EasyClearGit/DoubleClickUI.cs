﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyClearGit
{
    public partial class DoubleClickUI : Form
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        EasyClearGit.Properties.MoreInfoUI MUI = new EasyClearGit.Properties.MoreInfoUI();

        public DoubleClickUI()
        {
            InitializeComponent();
        }
        private void DoubleClickUI_Load(object sender, EventArgs e)
        {
            int UIWidth = 402;
            this.Width = UIWidth;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(DoubleClickUI.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 14 - base.Size.Width, workingArea.Bottom - 344 - base.Size.Height);
        }
        private void HideMore_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RestartApp_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void AppInfo_Click(object sender, EventArgs e)
        {
            MUI.Show();
        }
    }
}
