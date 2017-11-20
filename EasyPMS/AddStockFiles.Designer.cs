namespace EasyPMS
{
    partial class AddStockFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStockFiles));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonBlue1 = new Vibe_Theme.ButtonBlue();
            this.label2 = new System.Windows.Forms.Label();
            this.dropDownComboBox1 = new Vibe_Theme.DropDownComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items found on file:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(16, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 144);
            this.listBox1.TabIndex = 1;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // buttonBlue1
            // 
            this.buttonBlue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonBlue1.Image = null;
            this.buttonBlue1.Location = new System.Drawing.Point(118, 236);
            this.buttonBlue1.Name = "buttonBlue1";
            this.buttonBlue1.NoRounding = false;
            this.buttonBlue1.Size = new System.Drawing.Size(143, 39);
            this.buttonBlue1.TabIndex = 2;
            this.buttonBlue1.Text = "Confirm";
            this.buttonBlue1.Click += new System.EventHandler(this.buttonBlue1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Type:";
            // 
            // dropDownComboBox1
            // 
            this.dropDownComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropDownComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownComboBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dropDownComboBox1.FormattingEnabled = true;
            this.dropDownComboBox1.ItemHeight = 25;
            this.dropDownComboBox1.Location = new System.Drawing.Point(105, 188);
            this.dropDownComboBox1.Name = "dropDownComboBox1";
            this.dropDownComboBox1.Size = new System.Drawing.Size(267, 31);
            this.dropDownComboBox1.TabIndex = 4;
            // 
            // AddStockFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 287);
            this.Controls.Add(this.dropDownComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBlue1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStockFiles";
            this.ShowInTaskbar = false;
            this.Text = "EasyPMS - Add Stock Items";
            this.Load += new System.EventHandler(this.AddStockFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private Vibe_Theme.ButtonBlue buttonBlue1;
        private System.Windows.Forms.Label label2;
        private Vibe_Theme.DropDownComboBox dropDownComboBox1;
    }
}