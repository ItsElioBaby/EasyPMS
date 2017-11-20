namespace EasyPMS
{
    partial class SearchQueue
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
            this.chromeCheckbox1 = new ChromeCheckbox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.prodName = new Vibe_Theme.TxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chromeButton2 = new ChromeButton();
            this.chromeButton1 = new ChromeButton();
            this.txtBox1 = new Vibe_Theme.TxtBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chromeCheckbox1
            // 
            this.chromeCheckbox1.Checked = true;
            this.chromeCheckbox1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.chromeCheckbox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeCheckbox1.Image = null;
            this.chromeCheckbox1.Location = new System.Drawing.Point(174, 195);
            this.chromeCheckbox1.Name = "chromeCheckbox1";
            this.chromeCheckbox1.NoRounding = false;
            this.chromeCheckbox1.Size = new System.Drawing.Size(92, 17);
            this.chromeCheckbox1.TabIndex = 25;
            this.chromeCheckbox1.Text = "Include Date";
            this.chromeCheckbox1.Transparent = false;
            this.chromeCheckbox1.CheckedChanged += new ChromeCheckbox.CheckedChangedEventHandler(this.chromeCheckbox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd / MM   / yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date Added:";
            // 
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.Color.White;
            this.prodName.Image = null;
            this.prodName.Location = new System.Drawing.Point(9, 116);
            this.prodName.MaxLength = 32767;
            this.prodName.Name = "prodName";
            this.prodName.NoRounding = false;
            this.prodName.Size = new System.Drawing.Size(337, 31);
            this.prodName.TabIndex = 22;
            this.prodName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.prodName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Name:";
            // 
            // chromeButton2
            // 
            this.chromeButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.chromeButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeButton2.Image = null;
            this.chromeButton2.Location = new System.Drawing.Point(188, 234);
            this.chromeButton2.Name = "chromeButton2";
            this.chromeButton2.NoRounding = false;
            this.chromeButton2.Size = new System.Drawing.Size(141, 29);
            this.chromeButton2.TabIndex = 20;
            this.chromeButton2.Text = "Find Next";
            this.chromeButton2.Transparent = false;
            this.chromeButton2.Click += new System.EventHandler(this.chromeButton2_Click);
            // 
            // chromeButton1
            // 
            this.chromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.chromeButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeButton1.Image = null;
            this.chromeButton1.Location = new System.Drawing.Point(40, 234);
            this.chromeButton1.Name = "chromeButton1";
            this.chromeButton1.NoRounding = false;
            this.chromeButton1.Size = new System.Drawing.Size(141, 29);
            this.chromeButton1.TabIndex = 19;
            this.chromeButton1.Text = "Find First";
            this.chromeButton1.Transparent = false;
            this.chromeButton1.Click += new System.EventHandler(this.chromeButton1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.White;
            this.txtBox1.Image = null;
            this.txtBox1.Location = new System.Drawing.Point(9, 39);
            this.txtBox1.MaxLength = 32767;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.NoRounding = false;
            this.txtBox1.Size = new System.Drawing.Size(337, 31);
            this.txtBox1.TabIndex = 18;
            this.txtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox1.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client Name:";
            // 
            // SearchQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(366, 278);
            this.Controls.Add(this.chromeCheckbox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chromeButton2);
            this.Controls.Add(this.chromeButton1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQueue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search Queue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChromeCheckbox chromeCheckbox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private Vibe_Theme.TxtBox prodName;
        private System.Windows.Forms.Label label2;
        private ChromeButton chromeButton2;
        private ChromeButton chromeButton1;
        private Vibe_Theme.TxtBox txtBox1;
        private System.Windows.Forms.Label label1;
    }
}