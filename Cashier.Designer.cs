namespace ZooMayhem
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.showChartsButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyImage = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showIncomesButton = new System.Windows.Forms.Button();
            this.earningChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.allInfoLabel = new System.Windows.Forms.Label();
            this.hireCafeButton = new System.Windows.Forms.Button();
            this.hireShopButton = new System.Windows.Forms.Button();
            this.HireCleanerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(428, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounting Office";
            // 
            // showChartsButton
            // 
            this.showChartsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showChartsButton.BackColor = System.Drawing.Color.Tan;
            this.showChartsButton.FlatAppearance.BorderSize = 3;
            this.showChartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showChartsButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showChartsButton.Location = new System.Drawing.Point(22, 269);
            this.showChartsButton.Name = "showChartsButton";
            this.showChartsButton.Size = new System.Drawing.Size(216, 61);
            this.showChartsButton.TabIndex = 1;
            this.showChartsButton.Text = "View charts";
            this.showChartsButton.UseVisualStyleBackColor = false;
            this.showChartsButton.Click += new System.EventHandler(this.showChartsButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(1151, 24);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(130, 55);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "1000";
            // 
            // moneyImage
            // 
            this.moneyImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moneyImage.BackgroundImage")));
            this.moneyImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moneyImage.Location = new System.Drawing.Point(1287, 24);
            this.moneyImage.Name = "moneyImage";
            this.moneyImage.Size = new System.Drawing.Size(63, 55);
            this.moneyImage.TabIndex = 4;
            this.moneyImage.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.backButton.Location = new System.Drawing.Point(12, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 48);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 262);
            this.label2.TabIndex = 7;
            // 
            // showIncomesButton
            // 
            this.showIncomesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showIncomesButton.BackColor = System.Drawing.Color.Tan;
            this.showIncomesButton.FlatAppearance.BorderSize = 3;
            this.showIncomesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showIncomesButton.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.showIncomesButton.Location = new System.Drawing.Point(22, 356);
            this.showIncomesButton.Name = "showIncomesButton";
            this.showIncomesButton.Size = new System.Drawing.Size(216, 61);
            this.showIncomesButton.TabIndex = 11;
            this.showIncomesButton.Text = "View incomes";
            this.showIncomesButton.UseVisualStyleBackColor = false;
            this.showIncomesButton.Click += new System.EventHandler(this.showIncomesButton_Click);
            // 
            // earningChart
            // 
            this.earningChart.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Cursor;
            chartArea1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            this.earningChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            legend1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.earningChart.Legends.Add(legend1);
            this.earningChart.Location = new System.Drawing.Point(359, 117);
            this.earningChart.Name = "earningChart";
            this.earningChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Wave;
            series1.BorderWidth = 8;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.LawnGreen;
            series1.Name = "Earn";
            series1.YValuesPerPoint = 4;
            series2.BorderWidth = 8;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.LabelBorderWidth = 8;
            series2.Legend = "Legend1";
            series2.LegendText = "Expenses";
            series2.Name = "Expenses";
            series3.BorderWidth = 8;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Clean income";
            this.earningChart.Series.Add(series1);
            this.earningChart.Series.Add(series2);
            this.earningChart.Series.Add(series3);
            this.earningChart.Size = new System.Drawing.Size(991, 584);
            this.earningChart.TabIndex = 2;
            this.earningChart.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Income and expenses";
            this.earningChart.Titles.Add(title1);
            this.earningChart.Visible = false;
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeesButton.BackColor = System.Drawing.Color.Tan;
            this.EmployeesButton.FlatAppearance.BorderSize = 3;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.EmployeesButton.Location = new System.Drawing.Point(22, 433);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(216, 61);
            this.EmployeesButton.TabIndex = 14;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // allInfoLabel
            // 
            this.allInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allInfoLabel.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.allInfoLabel.Location = new System.Drawing.Point(438, 94);
            this.allInfoLabel.Name = "allInfoLabel";
            this.allInfoLabel.Size = new System.Drawing.Size(912, 709);
            this.allInfoLabel.TabIndex = 20;
            this.allInfoLabel.Text = resources.GetString("allInfoLabel.Text");
            this.allInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allInfoLabel.Visible = false;
            this.allInfoLabel.Click += new System.EventHandler(this.allInfoLabel_Click);
            // 
            // hireCafeButton
            // 
            this.hireCafeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hireCafeButton.BackColor = System.Drawing.Color.Tan;
            this.hireCafeButton.FlatAppearance.BorderSize = 3;
            this.hireCafeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireCafeButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hireCafeButton.Location = new System.Drawing.Point(263, 94);
            this.hireCafeButton.Name = "hireCafeButton";
            this.hireCafeButton.Size = new System.Drawing.Size(169, 206);
            this.hireCafeButton.TabIndex = 21;
            this.hireCafeButton.Text = "Hire";
            this.hireCafeButton.UseVisualStyleBackColor = false;
            this.hireCafeButton.Visible = false;
            this.hireCafeButton.Click += new System.EventHandler(this.hireCafeButton_Click);
            // 
            // hireShopButton
            // 
            this.hireShopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hireShopButton.BackColor = System.Drawing.Color.Tan;
            this.hireShopButton.FlatAppearance.BorderSize = 3;
            this.hireShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireShopButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hireShopButton.Location = new System.Drawing.Point(263, 316);
            this.hireShopButton.Name = "hireShopButton";
            this.hireShopButton.Size = new System.Drawing.Size(169, 156);
            this.hireShopButton.TabIndex = 22;
            this.hireShopButton.Text = "Hire";
            this.hireShopButton.UseVisualStyleBackColor = false;
            this.hireShopButton.Visible = false;
            this.hireShopButton.Click += new System.EventHandler(this.hireShopButton_Click);
            // 
            // HireCleanerButton
            // 
            this.HireCleanerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HireCleanerButton.BackColor = System.Drawing.Color.Tan;
            this.HireCleanerButton.FlatAppearance.BorderSize = 3;
            this.HireCleanerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HireCleanerButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HireCleanerButton.Location = new System.Drawing.Point(263, 488);
            this.HireCleanerButton.Name = "HireCleanerButton";
            this.HireCleanerButton.Size = new System.Drawing.Size(169, 315);
            this.HireCleanerButton.TabIndex = 23;
            this.HireCleanerButton.Text = "Hire";
            this.HireCleanerButton.UseVisualStyleBackColor = false;
            this.HireCleanerButton.Visible = false;
            this.HireCleanerButton.Click += new System.EventHandler(this.HireCleanerButton_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(263, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1087, 10);
            this.label3.TabIndex = 24;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(263, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1087, 10);
            this.label4.TabIndex = 25;
            this.label4.Visible = false;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 825);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HireCleanerButton);
            this.Controls.Add(this.hireShopButton);
            this.Controls.Add(this.hireCafeButton);
            this.Controls.Add(this.allInfoLabel);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.showIncomesButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.moneyImage);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.showChartsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.earningChart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cashier";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.moneyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showChartsButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.PictureBox moneyImage;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showIncomesButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart earningChart;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Label allInfoLabel;
        private System.Windows.Forms.Button hireCafeButton;
        private System.Windows.Forms.Button hireShopButton;
        private System.Windows.Forms.Button HireCleanerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}