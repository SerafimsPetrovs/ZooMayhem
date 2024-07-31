using ZooMayhem.Properties;

namespace ZooMayhem
{
    partial class Feeding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feeding));
            this.feedingYes = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.veganFoodCounter = new System.Windows.Forms.Label();
            this.meatFoodCounter = new System.Windows.Forms.Label();
            this.nextAnimalButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.animalNameLabel = new System.Windows.Forms.Label();
            this.foodTypeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sealYes = new System.Windows.Forms.PictureBox();
            this.sealNo = new System.Windows.Forms.PictureBox();
            this.animalPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sealYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sealNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPic)).BeginInit();
            this.SuspendLayout();
            // 
            // feedingYes
            // 
            this.feedingYes.FlatAppearance.BorderSize = 3;
            this.feedingYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.feedingYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedingYes.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedingYes.Location = new System.Drawing.Point(497, 666);
            this.feedingYes.Name = "feedingYes";
            this.feedingYes.Size = new System.Drawing.Size(158, 82);
            this.feedingYes.TabIndex = 21;
            this.feedingYes.Text = "Yes";
            this.feedingYes.UseVisualStyleBackColor = true;
            this.feedingYes.Click += new System.EventHandler(this.feedingYesButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.AutoEllipsis = true;
            this.skipButton.FlatAppearance.BorderSize = 3;
            this.skipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skipButton.Location = new System.Drawing.Point(715, 666);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(158, 82);
            this.skipButton.TabIndex = 22;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.feedingNoButton_Click);
            // 
            // veganFoodCounter
            // 
            this.veganFoodCounter.Font = new System.Drawing.Font("Consolas", 24F);
            this.veganFoodCounter.Location = new System.Drawing.Point(1072, 250);
            this.veganFoodCounter.Name = "veganFoodCounter";
            this.veganFoodCounter.Size = new System.Drawing.Size(204, 45);
            this.veganFoodCounter.TabIndex = 28;
            this.veganFoodCounter.Text = "Vegan: 100";
            this.veganFoodCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meatFoodCounter
            // 
            this.meatFoodCounter.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meatFoodCounter.Location = new System.Drawing.Point(1079, 190);
            this.meatFoodCounter.Name = "meatFoodCounter";
            this.meatFoodCounter.Size = new System.Drawing.Size(197, 45);
            this.meatFoodCounter.TabIndex = 29;
            this.meatFoodCounter.Text = "Meat: 100";
            this.meatFoodCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextAnimalButton
            // 
            this.nextAnimalButton.FlatAppearance.BorderSize = 3;
            this.nextAnimalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.nextAnimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextAnimalButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextAnimalButton.Location = new System.Drawing.Point(1079, 666);
            this.nextAnimalButton.Name = "nextAnimalButton";
            this.nextAnimalButton.Size = new System.Drawing.Size(271, 82);
            this.nextAnimalButton.TabIndex = 30;
            this.nextAnimalButton.Text = "Next animal";
            this.nextAnimalButton.UseVisualStyleBackColor = true;
            this.nextAnimalButton.Click += new System.EventHandler(this.nextAnimalButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1282, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 45);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1282, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 45);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1113, 70);
            this.label1.TabIndex = 33;
            this.label1.Text = "Will you give them something to eat?\n\n\n\n\n\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Consolas", 24F);
            this.ResultLabel.Location = new System.Drawing.Point(433, 448);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(852, 117);
            this.ResultLabel.TabIndex = 27;
            this.ResultLabel.Text = "Giraffes have been fed with 10 units of vegan food. \r\n";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // animalNameLabel
            // 
            this.animalNameLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalNameLabel.Location = new System.Drawing.Point(430, 220);
            this.animalNameLabel.Name = "animalNameLabel";
            this.animalNameLabel.Size = new System.Drawing.Size(259, 56);
            this.animalNameLabel.TabIndex = 23;
            this.animalNameLabel.Text = "Giraffes";
            this.animalNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodTypeLabel
            // 
            this.foodTypeLabel.Font = new System.Drawing.Font("Consolas", 24F);
            this.foodTypeLabel.Location = new System.Drawing.Point(433, 359);
            this.foodTypeLabel.Name = "foodTypeLabel";
            this.foodTypeLabel.Size = new System.Drawing.Size(363, 56);
            this.foodTypeLabel.TabIndex = 24;
            this.foodTypeLabel.Text = "Type of food: vegan\r\n";
            this.foodTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(714, 220);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(352, 56);
            this.quantityLabel.TabIndex = 25;
            this.quantityLabel.Text = "Quantity: 2";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(379, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(971, 298);
            this.label2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(378, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(972, 140);
            this.label3.TabIndex = 36;
            // 
            // sealYes
            // 
            this.sealYes.BackColor = System.Drawing.Color.Transparent;
            this.sealYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sealYes.BackgroundImage")));
            this.sealYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sealYes.Location = new System.Drawing.Point(431, 642);
            this.sealYes.Name = "sealYes";
            this.sealYes.Size = new System.Drawing.Size(192, 126);
            this.sealYes.TabIndex = 37;
            this.sealYes.TabStop = false;
            this.sealYes.Visible = false;
            // 
            // sealNo
            // 
            this.sealNo.BackColor = System.Drawing.Color.Transparent;
            this.sealNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sealNo.BackgroundImage")));
            this.sealNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sealNo.Location = new System.Drawing.Point(693, 678);
            this.sealNo.Name = "sealNo";
            this.sealNo.Size = new System.Drawing.Size(164, 113);
            this.sealNo.TabIndex = 38;
            this.sealNo.TabStop = false;
            this.sealNo.Visible = false;
            // 
            // animalPic
            // 
            this.animalPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animalPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalPic.Location = new System.Drawing.Point(26, 175);
            this.animalPic.Name = "animalPic";
            this.animalPic.Size = new System.Drawing.Size(346, 438);
            this.animalPic.TabIndex = 34;
            this.animalPic.TabStop = false;
            // 
            // Feeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 825);
            this.ControlBox = false;
            this.Controls.Add(this.sealNo);
            this.Controls.Add(this.sealYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextAnimalButton);
            this.Controls.Add(this.meatFoodCounter);
            this.Controls.Add(this.veganFoodCounter);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.foodTypeLabel);
            this.Controls.Add(this.animalNameLabel);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.feedingYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animalPic);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Feeding";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sealYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sealNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button feedingYes;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Label veganFoodCounter;
        private System.Windows.Forms.Label meatFoodCounter;
        private System.Windows.Forms.Button nextAnimalButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label animalNameLabel;
        private System.Windows.Forms.Label foodTypeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox sealYes;
        private System.Windows.Forms.PictureBox sealNo;
        private System.Windows.Forms.PictureBox animalPic;
    }
}