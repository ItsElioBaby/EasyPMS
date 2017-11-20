namespace EasyPMS
{
    partial class AddQueueItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQueueItem));
            this.label1 = new System.Windows.Forms.Label();
            this.prodName = new Vibe_Theme.TxtBox();
            this.clientName = new Vibe_Theme.TxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateAdded = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.seTypes = new Vibe_Theme.DropDownComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chromeRadioButton1 = new ChromeRadioButton();
            this.chromeRadioButton2 = new ChromeRadioButton();
            this.buttonBlue1 = new Vibe_Theme.ButtonBlue();
            this.initialPrice = new Vibe_Theme.TxtBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.Color.White;
            this.prodName.Image = null;
            this.prodName.Location = new System.Drawing.Point(107, 18);
            this.prodName.MaxLength = 32767;
            this.prodName.Name = "prodName";
            this.prodName.NoRounding = false;
            this.prodName.Size = new System.Drawing.Size(217, 31);
            this.prodName.TabIndex = 1;
            this.prodName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.prodName.UseSystemPasswordChar = false;
            // 
            // clientName
            // 
            this.clientName.BackColor = System.Drawing.Color.White;
            this.clientName.Image = null;
            this.clientName.Location = new System.Drawing.Point(94, 63);
            this.clientName.MaxLength = 32767;
            this.clientName.Name = "clientName";
            this.clientName.NoRounding = false;
            this.clientName.Size = new System.Drawing.Size(126, 31);
            this.clientName.TabIndex = 3;
            this.clientName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.clientName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Added:";
            // 
            // dateAdded
            // 
            this.dateAdded.CustomFormat = "dd / MM / yyy";
            this.dateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAdded.Location = new System.Drawing.Point(94, 114);
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.Size = new System.Drawing.Size(135, 22);
            this.dateAdded.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "SE Type:";
            // 
            // seTypes
            // 
            this.seTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.seTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seTypes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.seTypes.FormattingEnabled = true;
            this.seTypes.ItemHeight = 25;
            this.seTypes.Location = new System.Drawing.Point(399, 18);
            this.seTypes.Name = "seTypes";
            this.seTypes.Size = new System.Drawing.Size(216, 31);
            this.seTypes.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Refund Type:";
            // 
            // chromeRadioButton1
            // 
            this.chromeRadioButton1.Checked = false;
            this.chromeRadioButton1.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            this.chromeRadioButton1.Field = 16;
            this.chromeRadioButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeRadioButton1.Image = null;
            this.chromeRadioButton1.Location = new System.Drawing.Point(424, 71);
            this.chromeRadioButton1.Name = "chromeRadioButton1";
            this.chromeRadioButton1.NoRounding = false;
            this.chromeRadioButton1.Size = new System.Drawing.Size(64, 16);
            this.chromeRadioButton1.TabIndex = 9;
            this.chromeRadioButton1.Text = "Normal";
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
            this.chromeRadioButton2.Location = new System.Drawing.Point(494, 71);
            this.chromeRadioButton2.Name = "chromeRadioButton2";
            this.chromeRadioButton2.NoRounding = false;
            this.chromeRadioButton2.Size = new System.Drawing.Size(87, 16);
            this.chromeRadioButton2.TabIndex = 10;
            this.chromeRadioButton2.Text = "Double-Dip";
            this.chromeRadioButton2.Transparent = false;
            this.chromeRadioButton2.CheckedChanged += new ChromeRadioButton.CheckedChangedEventHandler(this.chromeRadioButton2_CheckedChanged);
            // 
            // buttonBlue1
            // 
            this.buttonBlue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonBlue1.Image = null;
            this.buttonBlue1.Location = new System.Drawing.Point(228, 155);
            this.buttonBlue1.Name = "buttonBlue1";
            this.buttonBlue1.NoRounding = false;
            this.buttonBlue1.Size = new System.Drawing.Size(165, 31);
            this.buttonBlue1.TabIndex = 11;
            this.buttonBlue1.Text = "Add";
            this.buttonBlue1.Click += new System.EventHandler(this.buttonBlue1_Click);
            // 
            // initialPrice
            // 
            this.initialPrice.BackColor = System.Drawing.Color.White;
            this.initialPrice.Image = null;
            this.initialPrice.Location = new System.Drawing.Point(409, 110);
            this.initialPrice.MaxLength = 32767;
            this.initialPrice.Name = "initialPrice";
            this.initialPrice.NoRounding = false;
            this.initialPrice.Size = new System.Drawing.Size(126, 31);
            this.initialPrice.TabIndex = 13;
            this.initialPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.initialPrice.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Item Price:";
            // 
            // AddQueueItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(631, 198);
            this.Controls.Add(this.initialPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBlue1);
            this.Controls.Add(this.chromeRadioButton2);
            this.Controls.Add(this.chromeRadioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateAdded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQueueItem";
            this.Text = "Add new queue item...";
            this.Load += new System.EventHandler(this.AddQueueItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Vibe_Theme.TxtBox prodName;
        private Vibe_Theme.TxtBox clientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateAdded;
        private System.Windows.Forms.Label label4;
        private Vibe_Theme.DropDownComboBox seTypes;
        private System.Windows.Forms.Label label5;
        private ChromeRadioButton chromeRadioButton1;
        private ChromeRadioButton chromeRadioButton2;
        private Vibe_Theme.ButtonBlue buttonBlue1;
        private Vibe_Theme.TxtBox initialPrice;
        private System.Windows.Forms.Label label6;
    }
}