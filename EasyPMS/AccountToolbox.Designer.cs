namespace EasyPMS
{
    partial class AccountToolbox
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountToolbox));
            this.groupDropBox1 = new Vibe_Theme.GroupDropBox();
            this.mSales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mRev = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numShops = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanelBox1 = new Vibe_Theme.GroupPanelBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupPanelBox2 = new Vibe_Theme.GroupPanelBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupPanelBox3 = new Vibe_Theme.GroupPanelBox();
            this.buttonGreen1 = new Vibe_Theme.ButtonGreen();
            this.buttonBlue2 = new Vibe_Theme.ButtonBlue();
            this.buttonBlue1 = new Vibe_Theme.ButtonBlue();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupDropBox1.SuspendLayout();
            this.groupPanelBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupPanelBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupPanelBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDropBox1
            // 
            this.groupDropBox1.Checked = true;
            this.groupDropBox1.Controls.Add(this.mSales);
            this.groupDropBox1.Controls.Add(this.label5);
            this.groupDropBox1.Controls.Add(this.mRev);
            this.groupDropBox1.Controls.Add(this.label2);
            this.groupDropBox1.Controls.Add(this.numShops);
            this.groupDropBox1.Controls.Add(this.label1);
            this.groupDropBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupDropBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupDropBox1.Location = new System.Drawing.Point(3, 12);
            this.groupDropBox1.MinimumSize = new System.Drawing.Size(5, 30);
            this.groupDropBox1.Name = "groupDropBox1";
            this.groupDropBox1.NoRounding = false;
            this.groupDropBox1.OpenSize = new System.Drawing.Size(162, 247);
            this.groupDropBox1.Size = new System.Drawing.Size(162, 247);
            this.groupDropBox1.TabIndex = 0;
            this.groupDropBox1.Text = "Account Details";
            // 
            // mSales
            // 
            this.mSales.AutoSize = true;
            this.mSales.Location = new System.Drawing.Point(11, 204);
            this.mSales.Name = "mSales";
            this.mSales.Size = new System.Drawing.Size(16, 17);
            this.mSales.TabIndex = 5;
            this.mSales.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "This month sales:";
            // 
            // mRev
            // 
            this.mRev.AutoSize = true;
            this.mRev.BackColor = System.Drawing.Color.Transparent;
            this.mRev.Location = new System.Drawing.Point(11, 132);
            this.mRev.Name = "mRev";
            this.mRev.Size = new System.Drawing.Size(47, 17);
            this.mRev.TabIndex = 3;
            this.mRev.Text = "0 USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "This month revenue:";
            // 
            // numShops
            // 
            this.numShops.AutoSize = true;
            this.numShops.Location = new System.Drawing.Point(11, 62);
            this.numShops.Name = "numShops";
            this.numShops.Size = new System.Drawing.Size(16, 17);
            this.numShops.TabIndex = 1;
            this.numShops.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of shops:";
            // 
            // groupPanelBox1
            // 
            this.groupPanelBox1.Controls.Add(this.chart1);
            this.groupPanelBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupPanelBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupPanelBox1.Location = new System.Drawing.Point(172, 12);
            this.groupPanelBox1.Name = "groupPanelBox1";
            this.groupPanelBox1.NoRounding = false;
            this.groupPanelBox1.Size = new System.Drawing.Size(443, 247);
            this.groupPanelBox1.TabIndex = 1;
            this.groupPanelBox1.Text = "Shops Revenues";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Shops";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(437, 200);
            this.chart1.TabIndex = 1;
            // 
            // groupPanelBox2
            // 
            this.groupPanelBox2.Controls.Add(this.chart2);
            this.groupPanelBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupPanelBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupPanelBox2.Location = new System.Drawing.Point(3, 266);
            this.groupPanelBox2.Name = "groupPanelBox2";
            this.groupPanelBox2.NoRounding = false;
            this.groupPanelBox2.Size = new System.Drawing.Size(612, 201);
            this.groupPanelBox2.TabIndex = 2;
            this.groupPanelBox2.Text = "This Month\'s Profits";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.YellowGreen;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chart2.BackSecondaryColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chart2.BorderlineColor = System.Drawing.Color.OrangeRed;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.Green;
            this.chart2.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart2.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chart2.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.chart2.BorderSkin.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            this.chart2.BorderSkin.BorderColor = System.Drawing.Color.Blue;
            this.chart2.BorderSkin.PageColor = System.Drawing.SystemColors.Window;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(8, 36);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Shops";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(589, 149);
            this.chart2.TabIndex = 2;
            // 
            // groupPanelBox3
            // 
            this.groupPanelBox3.Controls.Add(this.buttonGreen1);
            this.groupPanelBox3.Controls.Add(this.buttonBlue2);
            this.groupPanelBox3.Controls.Add(this.buttonBlue1);
            this.groupPanelBox3.Controls.Add(this.listBox1);
            this.groupPanelBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupPanelBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupPanelBox3.Location = new System.Drawing.Point(622, 13);
            this.groupPanelBox3.Name = "groupPanelBox3";
            this.groupPanelBox3.NoRounding = false;
            this.groupPanelBox3.Size = new System.Drawing.Size(335, 454);
            this.groupPanelBox3.TabIndex = 3;
            this.groupPanelBox3.Text = "Available Shops";
            // 
            // buttonGreen1
            // 
            this.buttonGreen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGreen1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonGreen1.Image = null;
            this.buttonGreen1.Location = new System.Drawing.Point(184, 357);
            this.buttonGreen1.Name = "buttonGreen1";
            this.buttonGreen1.NoRounding = false;
            this.buttonGreen1.Size = new System.Drawing.Size(136, 66);
            this.buttonGreen1.TabIndex = 3;
            this.buttonGreen1.Text = "Create a new Shop";
            this.buttonGreen1.Click += new System.EventHandler(this.buttonGreen1_Click);
            // 
            // buttonBlue2
            // 
            this.buttonBlue2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue2.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonBlue2.Image = null;
            this.buttonBlue2.Location = new System.Drawing.Point(16, 393);
            this.buttonBlue2.Name = "buttonBlue2";
            this.buttonBlue2.NoRounding = false;
            this.buttonBlue2.Size = new System.Drawing.Size(162, 30);
            this.buttonBlue2.TabIndex = 2;
            this.buttonBlue2.Text = "Remove Shop";
            this.buttonBlue2.Click += new System.EventHandler(this.buttonBlue2_Click);
            // 
            // buttonBlue1
            // 
            this.buttonBlue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonBlue1.Image = null;
            this.buttonBlue1.Location = new System.Drawing.Point(16, 357);
            this.buttonBlue1.Name = "buttonBlue1";
            this.buttonBlue1.NoRounding = false;
            this.buttonBlue1.Size = new System.Drawing.Size(162, 30);
            this.buttonBlue1.TabIndex = 1;
            this.buttonBlue1.Text = "Open Shop";
            this.buttonBlue1.Click += new System.EventHandler(this.buttonBlue1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 308);
            this.listBox1.TabIndex = 0;
            // 
            // AccountToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(969, 479);
            this.Controls.Add(this.groupPanelBox3);
            this.Controls.Add(this.groupPanelBox2);
            this.Controls.Add(this.groupPanelBox1);
            this.Controls.Add(this.groupDropBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountToolbox";
            this.Text = "EasyPMS - Account Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountToolbox_FormClosed);
            this.Load += new System.EventHandler(this.AccountToolbox_Load);
            this.groupDropBox1.ResumeLayout(false);
            this.groupDropBox1.PerformLayout();
            this.groupPanelBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupPanelBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupPanelBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Vibe_Theme.GroupDropBox groupDropBox1;
        private System.Windows.Forms.Label numShops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mRev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mSales;
        private System.Windows.Forms.Label label5;
        private Vibe_Theme.GroupPanelBox groupPanelBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Vibe_Theme.GroupPanelBox groupPanelBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Vibe_Theme.GroupPanelBox groupPanelBox3;
        private Vibe_Theme.ButtonBlue buttonBlue2;
        private Vibe_Theme.ButtonBlue buttonBlue1;
        private System.Windows.Forms.ListBox listBox1;
        private Vibe_Theme.ButtonGreen buttonGreen1;
    }
}