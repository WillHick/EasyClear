using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyClearGit.Properties
{
    public partial class MoreInfoUI : Form
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public MoreInfoUI()
        {
            InitializeComponent();
        }
        private void MoreInfoUI_Load(object sender, EventArgs e)
        {
            int WindowWidth = 369;

            this.CenterToScreen();

            this.Width = WindowWidth;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(MoreInfoUI.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));

            /* Get Information */

            VersionOutput.Text = Application.ProductVersion;
            LocationOutput.Text = Application.StartupPath.ToString();

            /* Get Start Time */

            StartTimeOutput.Text = DateTime.Now.ToShortTimeString();
        }
        private void HideInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ToggleRuntime_Click(object sender, EventArgs e)
        {

        }
    }
}
