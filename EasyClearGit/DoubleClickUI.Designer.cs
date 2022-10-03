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
            this.TopMostHeader = new System.Windows.Forms.Label();
            this.TopMostToggle = new System.Windows.Forms.Button();
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
            this.MoreFeatureBar.Size = new System.Drawing.Size(398, 96);
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
            this.HideMore.Location = new System.Drawing.Point(332, 22);
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
            // TopMostHeader
            // 
            this.TopMostHeader.AutoSize = true;
            this.TopMostHeader.Font = new System.Drawing.Font("Marlett", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMostHeader.Location = new System.Drawing.Point(16, 118);
            this.TopMostHeader.Name = "TopMostHeader";
            this.TopMostHeader.Size = new System.Drawing.Size(142, 30);
            this.TopMostHeader.TabIndex = 5;
            this.TopMostHeader.Text = "Is TopMost";
            // 
            // TopMostToggle
            // 
            this.TopMostToggle.BackgroundImage = global::EasyClearGit.Properties.Resources.icons8_checkmark_192;
            this.TopMostToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TopMostToggle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TopMostToggle.FlatAppearance.BorderSize = 0;
            this.TopMostToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.TopMostToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TopMostToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMostToggle.Location = new System.Drawing.Point(331, 113);
            this.TopMostToggle.Name = "TopMostToggle";
            this.TopMostToggle.Size = new System.Drawing.Size(48, 41);
            this.TopMostToggle.TabIndex = 4;
            this.TopMostToggle.UseVisualStyleBackColor = true;
            this.TopMostToggle.Click += new System.EventHandler(this.TopMostToggle_Click);
            // 
            // DoubleClickUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 616);
            this.ControlBox = false;
            this.Controls.Add(this.TopMostToggle);
            this.Controls.Add(this.MoreFeatureBar);
            this.Controls.Add(this.TopMostHeader);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MoreFeatureBar;
        private System.Windows.Forms.Label MoreHeader;
        private System.Windows.Forms.Button HideMore;
        private System.Windows.Forms.Label TopMostHeader;
        private System.Windows.Forms.Button TopMostToggle;
    }
}