using System;
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
    public partial class UI : Form
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        public UI()
        {
            InitializeComponent();
        }
        private void UI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(UI.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 14 - base.Size.Width, workingArea.Bottom - 14 - base.Size.Height);

            int ClearInt = 1;
            ClearTick.Start();
            ClearTick.Enabled = true;
            ClearTick.Interval = ClearInt;
        }
        private void ToggleClearing_Click(object sender, EventArgs e)
        {
            if (ClearTick.Enabled == true)
            {
                ClearTick.Enabled = false;
                ToggleClearing.BackgroundImage = EasyClearGit.Properties.Resources.icons8_uncheckmark_192;

                ToggleHeader.Text = "Off";

                ClearTick.Stop();
            }
            else if (ClearTick.Enabled == false)
            {
                ClearTick.Enabled = true;
                ToggleClearing.BackgroundImage = EasyClearGit.Properties.Resources.icons8_checkmark_192;

                ToggleHeader.Text = "On";

                ClearTick.Start();
            }
        }
        private void ClearTick_Tick(object sender, EventArgs e)
        {
            //Add Stat Count And Clear
            
            if (Clipboard.ContainsText())
            {
                Clipboard.Clear();
            }
            if (Clipboard.ContainsImage())
            {
                Clipboard.Clear();
            }
            if (Clipboard.ContainsAudio())
            {
                Clipboard.Clear();
            }
        }
    }
}
