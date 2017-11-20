namespace EasyPMS
{
    partial class AddSEProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSEProd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox1 = new Vibe_Theme.TxtBox();
            this.txtBox2 = new Vibe_Theme.TxtBox();
            this.txtBox3 = new Vibe_Theme.TxtBox();
            this.buttonBlue1 = new Vibe_Theme.ButtonBlue();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "SE Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Double-Dip Percentage:";
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.White;
            this.txtBox1.Image = null;
            this.txtBox1.Location = new System.Drawing.Point(125, 17);
            this.txtBox1.MaxLength = 32767;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.NoRounding = false;
            this.txtBox1.Size = new System.Drawing.Size(205, 31);
            this.txtBox1.TabIndex = 3;
            this.txtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox1.UseSystemPasswordChar = false;
            // 
            // txtBox2
            // 
            this.txtBox2.BackColor = System.Drawing.Color.White;
            this.txtBox2.Image = null;
            this.txtBox2.Location = new System.Drawing.Point(92, 67);
            this.txtBox2.MaxLength = 32767;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.NoRounding = false;
            this.txtBox2.Size = new System.Drawing.Size(70, 31);
            this.txtBox2.TabIndex = 4;
            this.txtBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox2.UseSystemPasswordChar = false;
            // 
            // txtBox3
            // 
            this.txtBox3.BackColor = System.Drawing.Color.White;
            this.txtBox3.Image = null;
            this.txtBox3.Location = new System.Drawing.Point(155, 120);
            this.txtBox3.MaxLength = 32767;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.NoRounding = false;
            this.txtBox3.Size = new System.Drawing.Size(70, 31);
            this.txtBox3.TabIndex = 5;
            this.txtBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox3.UseSystemPasswordChar = false;
            // 
            // buttonBlue1
            // 
            this.buttonBlue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonBlue1.Image = null;
            this.buttonBlue1.Location = new System.Drawing.Point(92, 170);
            this.buttonBlue1.Name = "buttonBlue1";
            this.buttonBlue1.NoRounding = false;
            this.buttonBlue1.Size = new System.Drawing.Size(136, 34);
            this.buttonBlue1.TabIndex = 6;
            this.buttonBlue1.Text = "Confirm";
            this.buttonBlue1.Click += new System.EventHandler(this.buttonBlue1_Click);
            // 
            // AddSEProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(338, 216);
            this.Controls.Add(this.buttonBlue1);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSEProd";
            this.ShowInTaskbar = false;
            this.Text = "EasyPMS - Add New SE Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Vibe_Theme.TxtBox txtBox1;
        private Vibe_Theme.TxtBox txtBox2;
        private Vibe_Theme.TxtBox txtBox3;
        private Vibe_Theme.ButtonBlue buttonBlue1;
    }
}