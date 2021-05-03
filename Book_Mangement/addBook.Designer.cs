namespace Book_Mangement
{
    partial class addBook
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBook));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.eitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bcatagoy = new System.Windows.Forms.ComboBox();
            this.bPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bAuthor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addPicture = new System.Windows.Forms.LinkLabel();
            this.bCover = new System.Windows.Forms.PictureBox();
            this.bRate = new Bunifu.Framework.UI.BunifuRating();
            this.bDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bCover)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eitButton);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 41);
            this.panel1.TabIndex = 0;
            // 
            // eitButton
            // 
            this.eitButton.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.eitButton, BunifuAnimatorNS.DecorationType.None);
            this.eitButton.Image = ((System.Drawing.Image)(resources.GetObject("eitButton.Image")));
            this.eitButton.ImageActive = null;
            this.eitButton.Location = new System.Drawing.Point(5, 5);
            this.eitButton.Name = "eitButton";
            this.eitButton.Size = new System.Drawing.Size(32, 30);
            this.eitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eitButton.TabIndex = 3;
            this.eitButton.TabStop = false;
            this.eitButton.Zoom = 10;
            this.eitButton.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 76);
            this.panel2.TabIndex = 1;
            // 
            // add
            // 
            this.add.ActiveBorderThickness = 1;
            this.add.ActiveCornerRadius = 20;
            this.add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.add.ActiveForecolor = System.Drawing.Color.White;
            this.add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.ButtonText = "اضافه ";
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.add, BunifuAnimatorNS.DecorationType.None);
            this.add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.SeaGreen;
            this.add.IdleBorderThickness = 1;
            this.add.IdleCornerRadius = 20;
            this.add.IdleFillColor = System.Drawing.Color.White;
            this.add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.add.Location = new System.Drawing.Point(201, 12);
            this.add.Margin = new System.Windows.Forms.Padding(5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(178, 50);
            this.add.TabIndex = 1;
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 365);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bcatagoy);
            this.groupBox2.Controls.Add(this.bPrice);
            this.groupBox2.Controls.Add(this.bAuthor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bName);
            this.groupBox2.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(333, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(279, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات اساسيه";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Book_Mangement.Properties.Resources.kTKoB87zc;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(54, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bcatagoy
            // 
            this.bunifuTransition1.SetDecoration(this.bcatagoy, BunifuAnimatorNS.DecorationType.None);
            this.bcatagoy.FormattingEnabled = true;
            this.bcatagoy.Location = new System.Drawing.Point(122, 259);
            this.bcatagoy.Name = "bcatagoy";
            this.bcatagoy.Size = new System.Drawing.Size(151, 31);
            this.bcatagoy.TabIndex = 2;
            // 
            // bPrice
            // 
            this.bPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bPrice, BunifuAnimatorNS.DecorationType.None);
            this.bPrice.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bPrice.HintForeColor = System.Drawing.Color.Empty;
            this.bPrice.HintText = "";
            this.bPrice.isPassword = false;
            this.bPrice.LineFocusedColor = System.Drawing.Color.Green;
            this.bPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.bPrice.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bPrice.LineThickness = 4;
            this.bPrice.Location = new System.Drawing.Point(0, 190);
            this.bPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bPrice.Name = "bPrice";
            this.bPrice.Size = new System.Drawing.Size(279, 29);
            this.bPrice.TabIndex = 1;
            this.bPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bAuthor
            // 
            this.bAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bAuthor, BunifuAnimatorNS.DecorationType.None);
            this.bAuthor.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAuthor.HintForeColor = System.Drawing.Color.Empty;
            this.bAuthor.HintText = "";
            this.bAuthor.isPassword = false;
            this.bAuthor.LineFocusedColor = System.Drawing.Color.Green;
            this.bAuthor.LineIdleColor = System.Drawing.Color.Gray;
            this.bAuthor.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bAuthor.LineThickness = 4;
            this.bAuthor.Location = new System.Drawing.Point(0, 128);
            this.bAuthor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.Size = new System.Drawing.Size(279, 29);
            this.bAuthor.TabIndex = 1;
            this.bAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(214, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "التصنيف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(229, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "السعر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(224, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "المؤلف";
            // 
            // bName
            // 
            this.bName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bName, BunifuAnimatorNS.DecorationType.None);
            this.bName.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bName.HintForeColor = System.Drawing.Color.Empty;
            this.bName.HintText = "";
            this.bName.isPassword = false;
            this.bName.LineFocusedColor = System.Drawing.Color.Green;
            this.bName.LineIdleColor = System.Drawing.Color.Gray;
            this.bName.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bName.LineThickness = 4;
            this.bName.Location = new System.Drawing.Point(0, 66);
            this.bName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(279, 29);
            this.bName.TabIndex = 1;
            this.bName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(204, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الكتاب";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPicture);
            this.groupBox1.Controls.Add(this.bCover);
            this.groupBox1.Controls.Add(this.bRate);
            this.groupBox1.Controls.Add(this.bDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(270, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات ثانويه";
            // 
            // addPicture
            // 
            this.addPicture.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.addPicture, BunifuAnimatorNS.DecorationType.None);
            this.addPicture.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addPicture.Location = new System.Drawing.Point(69, 293);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(78, 23);
            this.addPicture.TabIndex = 4;
            this.addPicture.TabStop = true;
            this.addPicture.Text = "تحديد الصورة";
            this.addPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddPicture_LinkClicked);
            // 
            // bCover
            // 
            this.bunifuTransition1.SetDecoration(this.bCover, BunifuAnimatorNS.DecorationType.None);
            this.bCover.Image = global::Book_Mangement.Properties.Resources.images;
            this.bCover.Location = new System.Drawing.Point(69, 190);
            this.bCover.Name = "bCover";
            this.bCover.Size = new System.Drawing.Size(102, 91);
            this.bCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bCover.TabIndex = 3;
            this.bCover.TabStop = false;
            // 
            // bRate
            // 
            this.bRate.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bRate, BunifuAnimatorNS.DecorationType.None);
            this.bRate.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.bRate.Location = new System.Drawing.Point(3, 128);
            this.bRate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bRate.Name = "bRate";
            this.bRate.Size = new System.Drawing.Size(239, 29);
            this.bRate.TabIndex = 2;
            this.bRate.Value = 0;
            // 
            // bDate
            // 
            this.bDate.BackColor = System.Drawing.Color.SeaGreen;
            this.bDate.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.bDate, BunifuAnimatorNS.DecorationType.None);
            this.bDate.ForeColor = System.Drawing.Color.White;
            this.bDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bDate.FormatCustom = null;
            this.bDate.Location = new System.Drawing.Point(0, 66);
            this.bDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(270, 29);
            this.bDate.TabIndex = 1;
            this.bDate.Value = new System.DateTime(2021, 4, 30, 15, 31, 54, 530);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(189, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "غلاف الكتاب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(230, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "التقيم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(220, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "التاريخ";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 4;
            // 
            // addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 482);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "addBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.AddBook_Activated);
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton eitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel addPicture;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public Bunifu.Framework.UI.BunifuThinButton2 add;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bPrice;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bAuthor;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bName;
        public System.Windows.Forms.PictureBox bCover;
        public Bunifu.Framework.UI.BunifuRating bRate;
        public Bunifu.Framework.UI.BunifuDatepicker bDate;
        public System.Windows.Forms.ComboBox bcatagoy;
    }
}