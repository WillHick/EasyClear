using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyClearGit
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
        private void UI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

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
    }
}
