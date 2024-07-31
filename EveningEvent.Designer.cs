namespace ZooMayhem
{
    partial class EveningEvent
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
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.eventTextLabel = new System.Windows.Forms.Label();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.EventPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EventPic)).BeginInit();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.FlatAppearance.BorderSize = 3;
            this.yesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesButton.Location = new System.Drawing.Point(526, 754);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(179, 59);
            this.yesButton.TabIndex = 8;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.FlatAppearance.BorderSize = 3;
            this.noButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noButton.Location = new System.Drawing.Point(761, 754);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(179, 59);
            this.noButton.TabIndex = 9;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // eventTextLabel
            // 
            this.eventTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventTextLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTextLabel.Location = new System.Drawing.Point(0, 526);
            this.eventTextLabel.Name = "eventTextLabel";
            this.eventTextLabel.Size = new System.Drawing.Size(1379, 211);
            this.eventTextLabel.TabIndex = 10;
            this.eventTextLabel.Text = "label1";
            this.eventTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextDayButton
            // 
            this.nextDayButton.FlatAppearance.BorderSize = 3;
            this.nextDayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.nextDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextDayButton.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextDayButton.Location = new System.Drawing.Point(1026, 757);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(341, 59);
            this.nextDayButton.TabIndex = 11;
            this.nextDayButton.Text = "Finish the day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // EventPic
            // 
            this.EventPic.BackgroundImage = global::ZooMayhem.Properties.Resources.no_pictures_3875433;
            this.EventPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EventPic.Location = new System.Drawing.Point(0, -4);
            this.EventPic.Name = "EventPic";
            this.EventPic.Size = new System.Drawing.Size(1379, 527);
            this.EventPic.TabIndex = 13;
            this.EventPic.TabStop = false;
            // 
            // EveningEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 825);
            this.Controls.Add(this.eventTextLabel);
            this.Controls.Add(this.EventPic);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EveningEvent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            ((System.ComponentModel.ISupportInitialize)(this.EventPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label eventTextLabel;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.PictureBox EventPic;
    }
}