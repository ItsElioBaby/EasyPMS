namespace EasyPMS
{
    partial class SearchItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new Vibe_Theme.TxtBox();
            this.chromeRadioButton1 = new ChromeRadioButton();
            this.chromeRadioButton2 = new ChromeRadioButton();
            this.chromeButton1 = new ChromeButton();
            this.chromeButton2 = new ChromeButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keywords:";
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.White;
            this.txtBox1.Image = null;
            this.txtBox1.Location = new System.Drawing.Point(12, 29);
            this.txtBox1.MaxLength = 32767;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.NoRounding = false;
            this.txtBox1.Size = new System.Drawing.Size(289, 31);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox1.UseSystemPasswordChar = false;
            // 
            // chromeRadioButton1
            // 
            this.chromeRadioButton1.Checked = true;
            this.chromeRadioButton1.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            this.chromeRadioButton1.Field = 16;
            this.chromeRadioButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeRadioButton1.Image = null;
            this.chromeRadioButton1.Location = new System.Drawing.Point(16, 74);
            this.chromeRadioButton1.Name = "chromeRadioButton1";
            this.chromeRadioButton1.NoRounding = false;
            this.chromeRadioButton1.Size = new System.Drawing.Size(90, 16);
            this.chromeRadioButton1.TabIndex = 2;
            this.chromeRadioButton1.Text = "Stock Item";
            this.chromeRadioButton1.Transparent = false;
            this.chromeRadioButton1.CheckedChanged += new ChromeRadioButton.CheckedChangedEventHandler(this.chromeRadioButton1_CheckedChanged);
            // 
            // chromeRadioButton2
            // 
            this.chromeRadioButton2.Checked = false;
            this.chromeRadioButton2.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            this.chromeRadioButton2.Field = 16;
            this.chromeRadioButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeRadioButton2.Image = null;
            this.chromeRadioButton2.Location = new System.Drawing.Point(112, 74);
            this.chromeRadioButton2.Name = "chromeRadioButton2";
            this.chromeRadioButton2.NoRounding = false;
            this.chromeRadioButton2.Size = new System.Drawing.Size(112, 16);
            this.chromeRadioButton2.TabIndex = 3;
            this.chromeRadioButton2.Text = "Product Type";
            this.chromeRadioButton2.Transparent = false;
            this.chromeRadioButton2.CheckedChanged += new ChromeRadioButton.CheckedChangedEventHandler(this.chromeRadioButton2_CheckedChanged);
            // 
            // chromeButton1
            // 
            this.chromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.chromeButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeButton1.Image = null;
            this.chromeButton1.Location = new System.Drawing.Point(30, 109);
            this.chromeButton1.Name = "chromeButton1";
            this.chromeButton1.NoRounding = false;
            this.chromeButton1.Size = new System.Drawing.Size(121, 27);
            this.chromeButton1.TabIndex = 4;
            this.chromeButton1.Text = "Find First";
            this.chromeButton1.Transparent = false;
            this.chromeButton1.Click += new System.EventHandler(this.chromeButton1_Click);
            // 
            // chromeButton2
            // 
            this.chromeButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.chromeButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeButton2.Image = null;
            this.chromeButton2.Location = new System.Drawing.Point(157, 109);
            this.chromeButton2.Name = "chromeButton2";
            this.chromeButton2.NoRounding = false;
            this.chromeButton2.Size = new System.Drawing.Size(121, 27);
            this.chromeButton2.TabIndex = 5;
            this.chromeButton2.Text = "Find Next";
            this.chromeButton2.Transparent = false;
            this.chromeButton2.Click += new System.EventHandler(this.chromeButton2_Click);
            // 
            // SearchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(329, 151);
            this.Controls.Add(this.chromeButton2);
            this.Controls.Add(this.chromeButton1);
            this.Controls.Add(this.chromeRadioButton2);
            this.Controls.Add(this.chromeRadioButton1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchItems";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search Items";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Vibe_Theme.TxtBox txtBox1;
        private ChromeRadioButton chromeRadioButton1;
        private ChromeRadioButton chromeRadioButton2;
        private ChromeButton chromeButton1;
        private ChromeButton chromeButton2;
    }
}