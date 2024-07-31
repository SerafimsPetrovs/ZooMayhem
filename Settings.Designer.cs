namespace ZooMayhem
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicBackLabel = new System.Windows.Forms.Label();
            this.musicButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(471, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // musicBackLabel
            // 
            this.musicBackLabel.BackColor = System.Drawing.Color.IndianRed;
            this.musicBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.musicBackLabel.Location = new System.Drawing.Point(590, 213);
            this.musicBackLabel.Name = "musicBackLabel";
            this.musicBackLabel.Size = new System.Drawing.Size(263, 100);
            this.musicBackLabel.TabIndex = 1;
            this.musicBackLabel.Click += new System.EventHandler(this.musicBackLabel_Click);
            // 
            // musicButton
            // 
            this.musicButton.BackColor = System.Drawing.Color.DimGray;
            this.musicButton.FlatAppearance.BorderSize = 3;
            this.musicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.musicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicButton.Location = new System.Drawing.Point(725, 213);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(128, 100);
            this.musicButton.TabIndex = 6;
            this.musicButton.Text = "Off";
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 740);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(133, 73);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 825);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.musicBackLabel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label musicBackLabel;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button backButton;
    }
}