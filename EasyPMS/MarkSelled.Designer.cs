namespace EasyPMS
{
    partial class MarkSelled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkSelled));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new Vibe_Theme.TxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_amount = new System.Windows.Forms.Label();
            this.buttonGreen1 = new Vibe_Theme.ButtonGreen();
            this.buttonGreen2 = new Vibe_Theme.ButtonGreen();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox2 = new Vibe_Theme.TxtBox();
            this.label5 = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buyer Name:";
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.White;
            this.txtBox1.Image = null;
            this.txtBox1.Location = new System.Drawing.Point(106, 25);
            this.txtBox1.MaxLength = 32767;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.NoRounding = false;
            this.txtBox1.Size = new System.Drawing.Size(96, 31);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox1.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items Bought:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(116, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 102);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Amount:";
            // 
            // t_amount
            // 
            this.t_amount.AutoSize = true;
            this.t_amount.Location = new System.Drawing.Point(116, 268);
            this.t_amount.Name = "t_amount";
            this.t_amount.Size = new System.Drawing.Size(58, 14);
            this.t_amount.TabIndex = 5;
            this.t_amount.Text = "{TOTAL}";
            // 
            // buttonGreen1
            // 
            this.buttonGreen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGreen1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonGreen1.Image = null;
            this.buttonGreen1.Location = new System.Drawing.Point(75, 306);
            this.buttonGreen1.Name = "buttonGreen1";
            this.buttonGreen1.NoRounding = false;
            this.buttonGreen1.Size = new System.Drawing.Size(137, 32);
            this.buttonGreen1.TabIndex = 6;
            this.buttonGreen1.Text = "Confirm";
            this.buttonGreen1.Click += new System.EventHandler(this.buttonGreen1_Click);
            // 
            // buttonGreen2
            // 
            this.buttonGreen2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGreen2.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonGreen2.Image = null;
            this.buttonGreen2.Location = new System.Drawing.Point(218, 306);
            this.buttonGreen2.Name = "buttonGreen2";
            this.buttonGreen2.NoRounding = false;
            this.buttonGreen2.Size = new System.Drawing.Size(137, 32);
            this.buttonGreen2.TabIndex = 7;
            this.buttonGreen2.Text = "Dismiss";
            this.buttonGreen2.Click += new System.EventHandler(this.buttonGreen2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price:";
            // 
            // txtBox2
            // 
            this.txtBox2.BackColor = System.Drawing.Color.White;
            this.txtBox2.Image = null;
            this.txtBox2.Location = new System.Drawing.Point(106, 204);
            this.txtBox2.MaxLength = 32767;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.NoRounding = false;
            this.txtBox2.Size = new System.Drawing.Size(96, 31);
            this.txtBox2.TabIndex = 9;
            this.txtBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox2.UseSystemPasswordChar = false;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Summary:";
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(285, 204);
            this.summary.MaxLength = 500;
            this.summary.Multiline = true;
            this.summary.Name = "summary";
            this.summary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.summary.Size = new System.Drawing.Size(194, 78);
            this.summary.TabIndex = 11;
            // 
            // MarkSelled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(491, 353);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGreen2);
            this.Controls.Add(this.buttonGreen1);
            this.Controls.Add(this.t_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkSelled";
            this.ShowInTaskbar = false;
            this.Text = "Add to history";
            this.Load += new System.EventHandler(this.MarkSelled_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Vibe_Theme.TxtBox txtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label t_amount;
        private Vibe_Theme.ButtonGreen buttonGreen1;
        private Vibe_Theme.ButtonGreen buttonGreen2;
        private System.Windows.Forms.Label label4;
        private Vibe_Theme.TxtBox txtBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox summary;
    }
}