namespace EasyPMS
{
    partial class CreateShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateShop));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new Vibe_Theme.TxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonGreen1 = new Vibe_Theme.ButtonGreen();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Name:";
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.White;
            this.txtBox1.Image = null;
            this.txtBox1.Location = new System.Drawing.Point(92, 17);
            this.txtBox1.MaxLength = 32767;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.NoRounding = false;
            this.txtBox1.Size = new System.Drawing.Size(187, 31);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox1.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shop Type:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 18);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Products Shop";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 18);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "SE/Refunds Shop";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // buttonGreen1
            // 
            this.buttonGreen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGreen1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonGreen1.Image = null;
            this.buttonGreen1.Location = new System.Drawing.Point(66, 116);
            this.buttonGreen1.Name = "buttonGreen1";
            this.buttonGreen1.NoRounding = false;
            this.buttonGreen1.Size = new System.Drawing.Size(135, 32);
            this.buttonGreen1.TabIndex = 5;
            this.buttonGreen1.Text = "Create Shop";
            this.buttonGreen1.Click += new System.EventHandler(this.buttonGreen1_Click);
            // 
            // CreateShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(298, 160);
            this.Controls.Add(this.buttonGreen1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateShop";
            this.ShowInTaskbar = false;
            this.Text = "EasyPMS - Create Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Vibe_Theme.TxtBox txtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Vibe_Theme.ButtonGreen buttonGreen1;


    }
}