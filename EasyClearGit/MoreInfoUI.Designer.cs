namespace EasyClearGit.Properties
{
    partial class MoreInfoUI
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
            this.InfoFeatureBar = new System.Windows.Forms.Panel();
            this.HideInfo = new System.Windows.Forms.Button();
            this.InfoHeader = new System.Windows.Forms.Label();
            this.VersionHeader = new System.Windows.Forms.Label();
            this.VersionOutput = new System.Windows.Forms.Label();
            this.LocationOutput = new System.Windows.Forms.Label();
            this.StartHeader = new System.Windows.Forms.Label();
            this.StartTimeOutput = new System.Windows.Forms.Label();
            this.StartTimeHeader = new System.Windows.Forms.Label();
            this.RuntimeToggleHeader = new System.Windows.Forms.Label();
            this.ToggleRuntime = new System.Windows.Forms.Button();
            this.InfoFeatureBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoFeatureBar
            // 
            this.InfoFeatureBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoFeatureBar.Controls.Add(this.HideInfo);
            this.InfoFeatureBar.Controls.Add(this.InfoHeader);
            this.InfoFeatureBar.Location = new System.Drawing.Point(-1, -1);
            this.InfoFeatureBar.Margin = new System.Windows.Forms.Padding(2);
            this.InfoFeatureBar.Name = "InfoFeatureBar";
            this.InfoFeatureBar.Size = new System.Drawing.Size(347, 62);
            this.InfoFeatureBar.TabIndex = 4;
            // 
            // HideInfo
            // 
            this.HideInfo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.HideInfo.FlatAppearance.BorderSize = 0;
            this.HideInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.HideInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.HideInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideInfo.Font = new System.Drawing.Font("MS Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.HideInfo.Location = new System.Drawing.Point(304, 14);
            this.HideInfo.Margin = new System.Windows.Forms.Padding(2);
            this.HideInfo.Name = "HideInfo";
            this.HideInfo.Size = new System.Drawing.Size(40, 39);
            this.HideInfo.TabIndex = 4;
            this.HideInfo.Text = ">";
            this.HideInfo.UseVisualStyleBackColor = true;
            this.HideInfo.Click += new System.EventHandler(this.HideInfo_Click);
            // 
            // InfoHeader
            // 
            this.InfoHeader.AutoSize = true;
            this.InfoHeader.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoHeader.Location = new System.Drawing.Point(9, 21);
            this.InfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoHeader.Name = "InfoHeader";
            this.InfoHeader.Size = new System.Drawing.Size(192, 37);
            this.InfoHeader.TabIndex = 3;
            this.InfoHeader.Text = "Information";
            // 
            // VersionHeader
            // 
            this.VersionHeader.AutoSize = true;
            this.VersionHeader.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionHeader.Location = new System.Drawing.Point(10, 100);
            this.VersionHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionHeader.Name = "VersionHeader";
            this.VersionHeader.Size = new System.Drawing.Size(100, 29);
            this.VersionHeader.TabIndex = 5;
            this.VersionHeader.Text = "Version";
            // 
            // VersionOutput
            // 
            this.VersionOutput.AutoSize = true;
            this.VersionOutput.Font = new System.Drawing.Font("Marlett", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionOutput.Location = new System.Drawing.Point(12, 121);
            this.VersionOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionOutput.Name = "VersionOutput";
            this.VersionOutput.Size = new System.Drawing.Size(35, 24);
            this.VersionOutput.TabIndex = 6;
            this.VersionOutput.Text = "int";
            // 
            // LocationOutput
            // 
            this.LocationOutput.AutoSize = true;
            this.LocationOutput.Font = new System.Drawing.Font("Marlett", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationOutput.Location = new System.Drawing.Point(11, 162);
            this.LocationOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocationOutput.Name = "LocationOutput";
            this.LocationOutput.Size = new System.Drawing.Size(93, 24);
            this.LocationOutput.TabIndex = 8;
            this.LocationOutput.Text = "pathway";
            // 
            // StartHeader
            // 
            this.StartHeader.AutoSize = true;
            this.StartHeader.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartHeader.Location = new System.Drawing.Point(9, 141);
            this.StartHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartHeader.Name = "StartHeader";
            this.StartHeader.Size = new System.Drawing.Size(175, 29);
            this.StartHeader.TabIndex = 7;
            this.StartHeader.Text = "Start Location";
            // 
            // StartTimeOutput
            // 
            this.StartTimeOutput.AutoSize = true;
            this.StartTimeOutput.Font = new System.Drawing.Font("Marlett", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeOutput.Location = new System.Drawing.Point(11, 203);
            this.StartTimeOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTimeOutput.Name = "StartTimeOutput";
            this.StartTimeOutput.Size = new System.Drawing.Size(35, 24);
            this.StartTimeOutput.TabIndex = 10;
            this.StartTimeOutput.Text = "int";
            // 
            // StartTimeHeader
            // 
            this.StartTimeHeader.AutoSize = true;
            this.StartTimeHeader.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeHeader.Location = new System.Drawing.Point(10, 182);
            this.StartTimeHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTimeHeader.Name = "StartTimeHeader";
            this.StartTimeHeader.Size = new System.Drawing.Size(130, 29);
            this.StartTimeHeader.TabIndex = 9;
            this.StartTimeHeader.Text = "Start Time";
            // 
            // RuntimeToggleHeader
            // 
            this.RuntimeToggleHeader.AutoSize = true;
            this.RuntimeToggleHeader.Font = new System.Drawing.Font("Marlett", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeToggleHeader.Location = new System.Drawing.Point(9, 73);
            this.RuntimeToggleHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RuntimeToggleHeader.Name = "RuntimeToggleHeader";
            this.RuntimeToggleHeader.Size = new System.Drawing.Size(189, 30);
            this.RuntimeToggleHeader.TabIndex = 12;
            this.RuntimeToggleHeader.Text = "Runtime Count";
            // 
            // ToggleRuntime
            // 
            this.ToggleRuntime.BackgroundImage = global::EasyClearGit.Properties.Resources.icons8_checkmark_192;
            this.ToggleRuntime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleRuntime.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleRuntime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleRuntime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleRuntime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleRuntime.Location = new System.Drawing.Point(303, 71);
            this.ToggleRuntime.Margin = new System.Windows.Forms.Padding(2);
            this.ToggleRuntime.Name = "ToggleRuntime";
            this.ToggleRuntime.Size = new System.Drawing.Size(31, 25);
            this.ToggleRuntime.TabIndex = 11;
            this.ToggleRuntime.UseVisualStyleBackColor = true;
            this.ToggleRuntime.Click += new System.EventHandler(this.ToggleRuntime_Click);
            // 
            // MoreInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 431);
            this.ControlBox = false;
            this.Controls.Add(this.RuntimeToggleHeader);
            this.Controls.Add(this.ToggleRuntime);
            this.Controls.Add(this.StartTimeOutput);
            this.Controls.Add(this.StartTimeHeader);
            this.Controls.Add(this.LocationOutput);
            this.Controls.Add(this.StartHeader);
            this.Controls.Add(this.VersionOutput);
            this.Controls.Add(this.VersionHeader);
            this.Controls.Add(this.InfoFeatureBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MoreInfoUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EasyClear Information";
            this.Load += new System.EventHandler(this.MoreInfoUI_Load);
            this.InfoFeatureBar.ResumeLayout(false);
            this.InfoFeatureBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel InfoFeatureBar;
        private System.Windows.Forms.Button HideInfo;
        private System.Windows.Forms.Label InfoHeader;
        private System.Windows.Forms.Label VersionHeader;
        private System.Windows.Forms.Label VersionOutput;
        private System.Windows.Forms.Label LocationOutput;
        private System.Windows.Forms.Label StartHeader;
        private System.Windows.Forms.Label StartTimeOutput;
        private System.Windows.Forms.Label StartTimeHeader;
        private System.Windows.Forms.Label RuntimeToggleHeader;
        private System.Windows.Forms.Button ToggleRuntime;
    }
}