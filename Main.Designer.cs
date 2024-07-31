using ZooMayhem.Properties;

namespace ZooMayhem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dayLabel = new System.Windows.Forms.Label();
            this.feedingButton = new System.Windows.Forms.Button();
            this.newsButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            this.dayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayLabel.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.Location = new System.Drawing.Point(12, 9);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(187, 65);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "Day 1";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feedingButton
            // 
            this.feedingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.feedingButton.FlatAppearance.BorderSize = 0;
            this.feedingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.feedingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedingButton.Font = new System.Drawing.Font("Consolas", 27.75F);
            this.feedingButton.Location = new System.Drawing.Point(761, 101);
            this.feedingButton.Name = "feedingButton";
            this.feedingButton.Size = new System.Drawing.Size(214, 57);
            this.feedingButton.TabIndex = 2;
            this.feedingButton.Text = "Feeding";
            this.feedingButton.UseVisualStyleBackColor = false;
            this.feedingButton.Click += new System.EventHandler(this.feedingButton_Click);
            // 
            // newsButton
            // 
            this.newsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(196)))), ((int)(((byte)(147)))));
            this.newsButton.FlatAppearance.BorderSize = 0;
            this.newsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.newsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsButton.Font = new System.Drawing.Font("Consolas", 27.75F);
            this.newsButton.Location = new System.Drawing.Point(1097, 69);
            this.newsButton.Name = "newsButton";
            this.newsButton.Size = new System.Drawing.Size(207, 59);
            this.newsButton.TabIndex = 3;
            this.newsButton.Text = "News";
            this.newsButton.UseVisualStyleBackColor = false;
            this.newsButton.Click += new System.EventHandler(this.newsButton_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(107)))), ((int)(((byte)(108)))));
            this.rulesButton.FlatAppearance.BorderSize = 0;
            this.rulesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.rulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rulesButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesButton.Location = new System.Drawing.Point(852, 239);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(133, 61);
            this.rulesButton.TabIndex = 4;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = false;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.musicButton.FlatAppearance.BorderSize = 0;
            this.musicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.musicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicButton.Location = new System.Drawing.Point(1134, 586);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(127, 59);
            this.musicButton.TabIndex = 5;
            this.musicButton.Text = "Play";
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(208)))), ((int)(((byte)(211)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(82, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Accounting";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextDayButton
            // 
            this.nextDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.nextDayButton.FlatAppearance.BorderSize = 0;
            this.nextDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextDayButton.Font = new System.Drawing.Font("Consolas", 27.75F);
            this.nextDayButton.Location = new System.Drawing.Point(488, 426);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(196, 61);
            this.nextDayButton.TabIndex = 8;
            this.nextDayButton.Text = "Next day";
            this.nextDayButton.UseVisualStyleBackColor = false;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 825);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.newsButton);
            this.Controls.Add(this.feedingButton);
            this.Controls.Add(this.dayLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Button feedingButton;
        private System.Windows.Forms.Button newsButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextDayButton;
    }
}