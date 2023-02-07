namespace EasyClearGit
{
    partial class DoubleClickUI
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
            this.MoreFeatureBar = new System.Windows.Forms.Panel();
            this.HideMore = new System.Windows.Forms.Button();
            this.MoreHeader = new System.Windows.Forms.Label();
            this.ExitApp = new System.Windows.Forms.Button();
            this.RestartApp = new System.Windows.Forms.Button();
            this.AppInfo = new System.Windows.Forms.Button();
            this.MoreFeatureBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoreFeatureBar
            // 
            this.MoreFeatureBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MoreFeatureBar.Controls.Add(this.HideMore);
            this.MoreFeatureBar.Controls.Add(this.MoreHeader);
            this.MoreFeatureBar.Location = new System.Drawing.Point(-2, -1);
            this.MoreFeatureBar.Name = "MoreFeatureBar";
            this.MoreFeatureBar.Size = new System.Drawing.Size(384, 96);
            this.MoreFeatureBar.TabIndex = 3;
            // 
            // HideMore
            // 
            this.HideMore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.HideMore.FlatAppearance.BorderSize = 0;
            this.HideMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.HideMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.HideMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideMore.Font = new System.Drawing.Font("MS Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.HideMore.Location = new System.Drawing.Point(319, 22);
            this.HideMore.Name = "HideMore";
            this.HideMore.Size = new System.Drawing.Size(60, 60);
            this.HideMore.TabIndex = 4;
            this.HideMore.Text = ">";
            this.HideMore.UseVisualStyleBackColor = true;
            this.HideMore.Click += new System.EventHandler(this.HideMore_Click);
            // 
            // MoreHeader
            // 
            this.MoreHeader.AutoSize = true;
            this.MoreHeader.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreHeader.Location = new System.Drawing.Point(14, 32);
            this.MoreHeader.Name = "MoreHeader";
            this.MoreHeader.Size = new System.Drawing.Size(94, 37);
            this.MoreHeader.TabIndex = 3;
            this.MoreHeader.Text = "More";
            // 
            // ExitApp
            // 
            this.ExitApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExitApp.FlatAppearance.BorderSize = 0;
            this.ExitApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitApp.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitApp.Location = new System.Drawing.Point(10, 205);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(217, 45);
            this.ExitApp.TabIndex = 6;
            this.ExitApp.Text = "Exit Application";
            this.ExitApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // RestartApp
            // 
            this.RestartApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RestartApp.FlatAppearance.BorderSize = 0;
            this.RestartApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RestartApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RestartApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartApp.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartApp.Location = new System.Drawing.Point(10, 159);
            this.RestartApp.Name = "RestartApp";
            this.RestartApp.Size = new System.Drawing.Size(261, 45);
            this.RestartApp.TabIndex = 7;
            this.RestartApp.Text = "Restart Application";
            this.RestartApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RestartApp.UseVisualStyleBackColor = true;
            this.RestartApp.Click += new System.EventHandler(this.RestartApp_Click);
            // 
            // AppInfo
            // 
            this.AppInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AppInfo.FlatAppearance.BorderSize = 0;
            this.AppInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AppInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AppInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppInfo.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppInfo.Location = new System.Drawing.Point(10, 111);
            this.AppInfo.Name = "AppInfo";
            this.AppInfo.Size = new System.Drawing.Size(225, 45);
            this.AppInfo.TabIndex = 8;
            this.AppInfo.Text = "More Information";
            this.AppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppInfo.UseVisualStyleBackColor = true;
            this.AppInfo.Click += new System.EventHandler(this.AppInfo_Click);
            // 
            // DoubleClickUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 266);
            this.ControlBox = false;
            this.Controls.Add(this.AppInfo);
            this.Controls.Add(this.RestartApp);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.MoreFeatureBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoubleClickUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EasyClear More";
            this.Load += new System.EventHandler(this.DoubleClickUI_Load);
            this.MoreFeatureBar.ResumeLayout(false);
            this.MoreFeatureBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MoreFeatureBar;
        private System.Windows.Forms.Label MoreHeader;
        private System.Windows.Forms.Button HideMore;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button RestartApp;
        private System.Windows.Forms.Button AppInfo;
    }
}