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
    public partial class DoubleClickUI : Form
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public DoubleClickUI()
        {
            InitializeComponent();
        }
        private void DoubleClickUI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(DoubleClickUI.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
        }
        private void HideMore_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void TopMostToggle_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {                
                TopMostToggle.BackgroundImage = EasyClearGit.Properties.Resources.icons8_uncheckmark_192;

                this.TopMost = true;
            }
            else if (this.TopMost == true)
            {
                TopMostToggle.BackgroundImage = EasyClearGit.Properties.Resources.icons8_checkmark_192;

                this.TopMost = false;
            }
        }
    }
}
