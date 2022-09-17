namespace EasyClearGit
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            this.ToggleFeatureBar = new System.Windows.Forms.Panel();
            this.ToggleHeader = new System.Windows.Forms.Label();
            this.ClearTick = new System.Windows.Forms.Timer(this.components);
            this.ToggleClearing = new System.Windows.Forms.Button();
            this.StatsHeader = new System.Windows.Forms.Label();
            this.TextNum = new System.Windows.Forms.Label();
            this.PhrasesText = new System.Windows.Forms.Label();
            this.ImagesText = new System.Windows.Forms.Label();
            this.ImagesNum = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.Label();
            this.TotalNum = new System.Windows.Forms.Label();
            this.ToggleFeatureBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToggleFeatureBar
            // 
            this.ToggleFeatureBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleFeatureBar.Controls.Add(this.ToggleHeader);
            this.ToggleFeatureBar.Controls.Add(this.ToggleClearing);
            this.ToggleFeatureBar.Location = new System.Drawing.Point(-1, -1);
            this.ToggleFeatureBar.Name = "ToggleFeatureBar";
            this.ToggleFeatureBar.Size = new System.Drawing.Size(383, 96);
            this.ToggleFeatureBar.TabIndex = 2;
            // 
            // ToggleHeader
            // 
            this.ToggleHeader.AutoSize = true;
            this.ToggleHeader.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleHeader.Location = new System.Drawing.Point(14, 29);
            this.ToggleHeader.Name = "ToggleHeader";
            this.ToggleHeader.Size = new System.Drawing.Size(60, 37);
            this.ToggleHeader.TabIndex = 3;
            this.ToggleHeader.Text = "On";
            // 
            // ClearTick
            // 
            this.ClearTick.Interval = 1;
            // 
            // ToggleClearing
            // 
            this.ToggleClearing.BackgroundImage = global::EasyClearGit.Properties.Resources.icons8_checkmark_192;
            this.ToggleClearing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleClearing.FlatAppearance.BorderSize = 0;
            this.ToggleClearing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleClearing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleClearing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleClearing.Location = new System.Drawing.Point(316, 25);
            this.ToggleClearing.Name = "ToggleClearing";
            this.ToggleClearing.Size = new System.Drawing.Size(51, 47);
            this.ToggleClearing.TabIndex = 2;
            this.ToggleClearing.UseVisualStyleBackColor = true;
            this.ToggleClearing.Click += new System.EventHandler(this.ToggleClearing_Click);
            // 
            // StatsHeader
            // 
            this.StatsHeader.AutoSize = true;
            this.StatsHeader.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsHeader.Location = new System.Drawing.Point(13, 110);
            this.StatsHeader.Name = "StatsHeader";
            this.StatsHeader.Size = new System.Drawing.Size(96, 37);
            this.StatsHeader.TabIndex = 4;
            this.StatsHeader.Text = "Stats";
            // 
            // TextNum
            // 
            this.TextNum.AutoSize = true;
            this.TextNum.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNum.Location = new System.Drawing.Point(13, 159);
            this.TextNum.Name = "TextNum";
            this.TextNum.Size = new System.Drawing.Size(35, 37);
            this.TextNum.TabIndex = 5;
            this.TextNum.Text = "0";
            // 
            // PhrasesText
            // 
            this.PhrasesText.AutoSize = true;
            this.PhrasesText.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhrasesText.Location = new System.Drawing.Point(16, 196);
            this.PhrasesText.Name = "PhrasesText";
            this.PhrasesText.Size = new System.Drawing.Size(165, 24);
            this.PhrasesText.TabIndex = 6;
            this.PhrasesText.Text = "Phrases Cleared";
            // 
            // ImagesText
            // 
            this.ImagesText.AutoSize = true;
            this.ImagesText.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagesText.Location = new System.Drawing.Point(210, 196);
            this.ImagesText.Name = "ImagesText";
            this.ImagesText.Size = new System.Drawing.Size(155, 24);
            this.ImagesText.TabIndex = 8;
            this.ImagesText.Text = "Images Cleared";
            // 
            // ImagesNum
            // 
            this.ImagesNum.AutoSize = true;
            this.ImagesNum.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagesNum.Location = new System.Drawing.Point(207, 159);
            this.ImagesNum.Name = "ImagesNum";
            this.ImagesNum.Size = new System.Drawing.Size(35, 37);
            this.ImagesNum.TabIndex = 7;
            this.ImagesNum.Text = "0";
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalText.Location = new System.Drawing.Point(16, 271);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(192, 24);
            this.TotalText.TabIndex = 10;
            this.TotalText.Text = "Total Items Cleared";
            // 
            // TotalNum
            // 
            this.TotalNum.AutoSize = true;
            this.TotalNum.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNum.Location = new System.Drawing.Point(13, 234);
            this.TotalNum.Name = "TotalNum";
            this.TotalNum.Size = new System.Drawing.Size(35, 37);
            this.TotalNum.TabIndex = 9;
            this.TotalNum.Text = "0";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 627);
            this.ControlBox = false;
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.TotalNum);
            this.Controls.Add(this.ImagesText);
            this.Controls.Add(this.ImagesNum);
            this.Controls.Add(this.PhrasesText);
            this.Controls.Add(this.TextNum);
            this.Controls.Add(this.StatsHeader);
            this.Controls.Add(this.ToggleFeatureBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UI";
            this.Opacity = 0.99D;
            this.Text = "EasyClear";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ToggleFeatureBar.ResumeLayout(false);
            this.ToggleFeatureBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToggleFeatureBar;
        private System.Windows.Forms.Label ToggleHeader;
        private System.Windows.Forms.Button ToggleClearing;
        private System.Windows.Forms.Timer ClearTick;
        private System.Windows.Forms.Label StatsHeader;
        private System.Windows.Forms.Label TextNum;
        private System.Windows.Forms.Label PhrasesText;
        private System.Windows.Forms.Label ImagesText;
        private System.Windows.Forms.Label ImagesNum;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.Label TotalNum;
    }
}

