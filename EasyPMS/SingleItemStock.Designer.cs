namespace EasyPMS
{
    partial class SingleItemStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleItemStock));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new Vibe_Theme.TxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropDownComboBox1 = new Vibe_Theme.DropDownComboBox();
            this.buttonBlue1 = new Vibe_Theme.ButtonBlue();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Data:";
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.White;
            this.txtBox1.Image = null;
            this.txtBox1.Location = new System.Drawing.Point(15, 38);
            this.txtBox1.MaxLength = 32767;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.NoRounding = false;
            this.txtBox1.Size = new System.Drawing.Size(314, 31);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox1.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Type:";
            // 
            // dropDownComboBox1
            // 
            this.dropDownComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropDownComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownComboBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dropDownComboBox1.FormattingEnabled = true;
            this.dropDownComboBox1.ItemHeight = 25;
            this.dropDownComboBox1.Location = new System.Drawing.Point(18, 105);
            this.dropDownComboBox1.Name = "dropDownComboBox1";
            this.dropDownComboBox1.Size = new System.Drawing.Size(311, 31);
            this.dropDownComboBox1.TabIndex = 3;
            // 
            // buttonBlue1
            // 
            this.buttonBlue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonBlue1.Image = null;
            this.buttonBlue1.Location = new System.Drawing.Point(104, 152);
            this.buttonBlue1.Name = "buttonBlue1";
            this.buttonBlue1.NoRounding = false;
            this.buttonBlue1.Size = new System.Drawing.Size(114, 34);
            this.buttonBlue1.TabIndex = 4;
            this.buttonBlue1.Text = "Confirm";
            this.buttonBlue1.Click += new System.EventHandler(this.buttonBlue1_Click);
            // 
            // SingleItemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(341, 198);
            this.Controls.Add(this.buttonBlue1);
            this.Controls.Add(this.dropDownComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingleItemStock";
            this.ShowInTaskbar = false;
            this.Text = "EasyPMS - Add New Stock Item";
            this.Load += new System.EventHandler(this.SingleItemStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Vibe_Theme.TxtBox txtBox1;
        private System.Windows.Forms.Label label2;
        private Vibe_Theme.DropDownComboBox dropDownComboBox1;
        private Vibe_Theme.ButtonBlue buttonBlue1;
    }
}