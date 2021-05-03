namespace Book_Mangement
{
    partial class Deteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deteles));
            this.bPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bAuthor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCover = new System.Windows.Forms.PictureBox();
            this.bRate = new Bunifu.Framework.UI.BunifuRating();
            this.bDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bCatagory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eitButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bPrice
            // 
            this.bPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bPrice.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrice.ForeColor = System.Drawing.Color.White;
            this.bPrice.HintForeColor = System.Drawing.Color.Empty;
            this.bPrice.HintText = "";
            this.bPrice.isPassword = false;
            this.bPrice.LineFocusedColor = System.Drawing.Color.Green;
            this.bPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.bPrice.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bPrice.LineThickness = 4;
            this.bPrice.Location = new System.Drawing.Point(391, 249);
            this.bPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bPrice.Name = "bPrice";
            this.bPrice.Size = new System.Drawing.Size(279, 29);
            this.bPrice.TabIndex = 11;
            this.bPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bPrice.OnValueChanged += new System.EventHandler(this.BPrice_OnValueChanged);
            // 
            // bAuthor
            // 
            this.bAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bAuthor.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAuthor.ForeColor = System.Drawing.Color.White;
            this.bAuthor.HintForeColor = System.Drawing.Color.Empty;
            this.bAuthor.HintText = "";
            this.bAuthor.isPassword = false;
            this.bAuthor.LineFocusedColor = System.Drawing.Color.Green;
            this.bAuthor.LineIdleColor = System.Drawing.Color.Gray;
            this.bAuthor.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bAuthor.LineThickness = 4;
            this.bAuthor.Location = new System.Drawing.Point(391, 167);
            this.bAuthor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.Size = new System.Drawing.Size(279, 29);
            this.bAuthor.TabIndex = 12;
            this.bAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bAuthor.OnValueChanged += new System.EventHandler(this.BAuthor_OnValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(697, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "التصنيف";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(716, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "السعر";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(716, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "المؤلف";
            // 
            // bName
            // 
            this.bName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bName.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bName.ForeColor = System.Drawing.Color.White;
            this.bName.HintForeColor = System.Drawing.Color.Empty;
            this.bName.HintText = "";
            this.bName.isPassword = false;
            this.bName.LineFocusedColor = System.Drawing.Color.Green;
            this.bName.LineIdleColor = System.Drawing.Color.Gray;
            this.bName.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bName.LineThickness = 4;
            this.bName.Location = new System.Drawing.Point(382, 85);
            this.bName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(279, 29);
            this.bName.TabIndex = 13;
            this.bName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bName.OnValueChanged += new System.EventHandler(this.BName_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(689, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم الكتاب";
            // 
            // bCover
            // 
            this.bCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCover.Image = global::Book_Mangement.Properties.Resources.images;
            this.bCover.Location = new System.Drawing.Point(133, 293);
            this.bCover.Name = "bCover";
            this.bCover.Size = new System.Drawing.Size(198, 172);
            this.bCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bCover.TabIndex = 17;
            this.bCover.TabStop = false;
            // 
            // bRate
            // 
            this.bRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRate.BackColor = System.Drawing.Color.Transparent;
            this.bRate.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.bRate.Location = new System.Drawing.Point(92, 191);
            this.bRate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bRate.Name = "bRate";
            this.bRate.Size = new System.Drawing.Size(239, 29);
            this.bRate.TabIndex = 16;
            this.bRate.Value = 0;
            // 
            // bDate
            // 
            this.bDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDate.BackColor = System.Drawing.Color.SeaGreen;
            this.bDate.BorderRadius = 0;
            this.bDate.ForeColor = System.Drawing.Color.White;
            this.bDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bDate.FormatCustom = null;
            this.bDate.Location = new System.Drawing.Point(-141, 87);
            this.bDate.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(472, 36);
            this.bDate.TabIndex = 14;
            this.bDate.Value = new System.DateTime(2021, 4, 30, 15, 31, 54, 530);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(229, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "غلاف الكتاب";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(286, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "التقيم";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(273, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "التاريخ";
            // 
            // bCatagory
            // 
            this.bCatagory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCatagory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bCatagory.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCatagory.ForeColor = System.Drawing.Color.White;
            this.bCatagory.HintForeColor = System.Drawing.Color.Empty;
            this.bCatagory.HintText = "";
            this.bCatagory.isPassword = false;
            this.bCatagory.LineFocusedColor = System.Drawing.Color.Green;
            this.bCatagory.LineIdleColor = System.Drawing.Color.Gray;
            this.bCatagory.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bCatagory.LineThickness = 4;
            this.bCatagory.Location = new System.Drawing.Point(391, 335);
            this.bCatagory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bCatagory.Name = "bCatagory";
            this.bCatagory.Size = new System.Drawing.Size(279, 29);
            this.bCatagory.TabIndex = 11;
            this.bCatagory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bCatagory.OnValueChanged += new System.EventHandler(this.BCatagory_OnValueChanged);
            // 
            // eitButton
            // 
            this.eitButton.BackColor = System.Drawing.Color.White;
            this.eitButton.Image = ((System.Drawing.Image)(resources.GetObject("eitButton.Image")));
            this.eitButton.ImageActive = null;
            this.eitButton.Location = new System.Drawing.Point(12, 12);
            this.eitButton.Name = "eitButton";
            this.eitButton.Size = new System.Drawing.Size(32, 30);
            this.eitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eitButton.TabIndex = 18;
            this.eitButton.TabStop = false;
            this.eitButton.Zoom = 10;
            this.eitButton.Click += new System.EventHandler(this.EitButton_Click);
            // 
            // Deteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(781, 577);
            this.Controls.Add(this.eitButton);
            this.Controls.Add(this.bCatagory);
            this.Controls.Add(this.bPrice);
            this.Controls.Add(this.bAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCover);
            this.Controls.Add(this.bRate);
            this.Controls.Add(this.bDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Deteles";
            this.Opacity = 0.85D;
            this.Text = "Deteles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Deteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuMaterialTextbox bPrice;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox bCover;
        public Bunifu.Framework.UI.BunifuRating bRate;
        public Bunifu.Framework.UI.BunifuDatepicker bDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bCatagory;
        private Bunifu.Framework.UI.BunifuImageButton eitButton;
    }
}