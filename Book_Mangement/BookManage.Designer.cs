namespace Book_Mangement
{
    partial class BookManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManage));
            this.header = new System.Windows.Forms.Panel();
            this.bigScreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.smallScreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.eitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.detelesB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editeB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookdata = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.search = new Bunifu.Framework.UI.BunifuTextbox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).BeginInit();
            this.footer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookdata)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Gainsboro;
            this.header.Controls.Add(this.search);
            this.header.Controls.Add(this.bigScreen);
            this.header.Controls.Add(this.smallScreen);
            this.header.Controls.Add(this.eitButton);
            this.header.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(684, 40);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // bigScreen
            // 
            this.bigScreen.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.bigScreen, BunifuAnimatorNS.DecorationType.None);
            this.bigScreen.Image = ((System.Drawing.Image)(resources.GetObject("bigScreen.Image")));
            this.bigScreen.ImageActive = null;
            this.bigScreen.Location = new System.Drawing.Point(51, 7);
            this.bigScreen.Name = "bigScreen";
            this.bigScreen.Size = new System.Drawing.Size(32, 30);
            this.bigScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bigScreen.TabIndex = 0;
            this.bigScreen.TabStop = false;
            this.bigScreen.Zoom = 10;
            this.bigScreen.Click += new System.EventHandler(this.BigScreen_Click);
            // 
            // smallScreen
            // 
            this.smallScreen.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.smallScreen, BunifuAnimatorNS.DecorationType.None);
            this.smallScreen.Image = ((System.Drawing.Image)(resources.GetObject("smallScreen.Image")));
            this.smallScreen.ImageActive = null;
            this.smallScreen.Location = new System.Drawing.Point(89, 7);
            this.smallScreen.Name = "smallScreen";
            this.smallScreen.Size = new System.Drawing.Size(32, 30);
            this.smallScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smallScreen.TabIndex = 0;
            this.smallScreen.TabStop = false;
            this.smallScreen.Zoom = 10;
            this.smallScreen.Click += new System.EventHandler(this.SmallScreen_Click);
            // 
            // eitButton
            // 
            this.eitButton.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.eitButton, BunifuAnimatorNS.DecorationType.None);
            this.eitButton.Image = ((System.Drawing.Image)(resources.GetObject("eitButton.Image")));
            this.eitButton.ImageActive = null;
            this.eitButton.Location = new System.Drawing.Point(13, 7);
            this.eitButton.Name = "eitButton";
            this.eitButton.Size = new System.Drawing.Size(32, 30);
            this.eitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eitButton.TabIndex = 0;
            this.eitButton.TabStop = false;
            this.eitButton.Zoom = 10;
            this.eitButton.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "برنامج اداره الكتب";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Silver;
            this.footer.Controls.Add(this.detelesB);
            this.footer.Controls.Add(this.deleteB);
            this.footer.Controls.Add(this.editeB);
            this.footer.Controls.Add(this.addB);
            this.bunifuTransition1.SetDecoration(this.footer, BunifuAnimatorNS.DecorationType.None);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 397);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(684, 84);
            this.footer.TabIndex = 1;
            // 
            // detelesB
            // 
            this.detelesB.ActiveBorderThickness = 1;
            this.detelesB.ActiveCornerRadius = 20;
            this.detelesB.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.detelesB.ActiveForecolor = System.Drawing.Color.White;
            this.detelesB.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.detelesB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.detelesB.BackColor = System.Drawing.Color.Silver;
            this.detelesB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("detelesB.BackgroundImage")));
            this.detelesB.ButtonText = "تفاصيل";
            this.detelesB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.detelesB, BunifuAnimatorNS.DecorationType.None);
            this.detelesB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detelesB.ForeColor = System.Drawing.Color.SeaGreen;
            this.detelesB.IdleBorderThickness = 1;
            this.detelesB.IdleCornerRadius = 20;
            this.detelesB.IdleFillColor = System.Drawing.Color.White;
            this.detelesB.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.detelesB.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.detelesB.Location = new System.Drawing.Point(22, 29);
            this.detelesB.Margin = new System.Windows.Forms.Padding(5);
            this.detelesB.Name = "detelesB";
            this.detelesB.Size = new System.Drawing.Size(142, 41);
            this.detelesB.TabIndex = 0;
            this.detelesB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.detelesB.Click += new System.EventHandler(this.detelesB_Click);
            // 
            // deleteB
            // 
            this.deleteB.ActiveBorderThickness = 1;
            this.deleteB.ActiveCornerRadius = 20;
            this.deleteB.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.deleteB.ActiveForecolor = System.Drawing.Color.White;
            this.deleteB.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.deleteB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteB.BackColor = System.Drawing.Color.Silver;
            this.deleteB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteB.BackgroundImage")));
            this.deleteB.ButtonText = "حذف الكتاب";
            this.deleteB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.deleteB, BunifuAnimatorNS.DecorationType.None);
            this.deleteB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteB.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteB.IdleBorderThickness = 1;
            this.deleteB.IdleCornerRadius = 20;
            this.deleteB.IdleFillColor = System.Drawing.Color.White;
            this.deleteB.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.deleteB.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.deleteB.Location = new System.Drawing.Point(188, 29);
            this.deleteB.Margin = new System.Windows.Forms.Padding(5);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(142, 41);
            this.deleteB.TabIndex = 0;
            this.deleteB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // editeB
            // 
            this.editeB.ActiveBorderThickness = 1;
            this.editeB.ActiveCornerRadius = 20;
            this.editeB.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.editeB.ActiveForecolor = System.Drawing.Color.White;
            this.editeB.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.editeB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editeB.BackColor = System.Drawing.Color.Silver;
            this.editeB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editeB.BackgroundImage")));
            this.editeB.ButtonText = "تعديل الكتاب";
            this.editeB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.editeB, BunifuAnimatorNS.DecorationType.None);
            this.editeB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeB.ForeColor = System.Drawing.Color.SeaGreen;
            this.editeB.IdleBorderThickness = 1;
            this.editeB.IdleCornerRadius = 20;
            this.editeB.IdleFillColor = System.Drawing.Color.White;
            this.editeB.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.editeB.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.editeB.Location = new System.Drawing.Point(354, 29);
            this.editeB.Margin = new System.Windows.Forms.Padding(5);
            this.editeB.Name = "editeB";
            this.editeB.Size = new System.Drawing.Size(142, 41);
            this.editeB.TabIndex = 0;
            this.editeB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editeB.Click += new System.EventHandler(this.EditeB_Click);
            // 
            // addB
            // 
            this.addB.ActiveBorderThickness = 1;
            this.addB.ActiveCornerRadius = 20;
            this.addB.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addB.ActiveForecolor = System.Drawing.Color.White;
            this.addB.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addB.BackColor = System.Drawing.Color.Silver;
            this.addB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addB.BackgroundImage")));
            this.addB.ButtonText = "اضافه كتاب جديد";
            this.addB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.addB, BunifuAnimatorNS.DecorationType.None);
            this.addB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.ForeColor = System.Drawing.Color.SeaGreen;
            this.addB.IdleBorderThickness = 1;
            this.addB.IdleCornerRadius = 20;
            this.addB.IdleFillColor = System.Drawing.Color.White;
            this.addB.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addB.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addB.Location = new System.Drawing.Point(520, 29);
            this.addB.Margin = new System.Windows.Forms.Padding(5);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(142, 41);
            this.addB.TabIndex = 0;
            this.addB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bookdata);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 357);
            this.panel3.TabIndex = 2;
            // 
            // bookdata
            // 
            this.bookdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.bookdata, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookdata.Location = new System.Drawing.Point(0, 0);
            this.bookdata.Name = "bookdata";
            this.bookdata.RowTemplate.Height = 35;
            this.bookdata.Size = new System.Drawing.Size(684, 357);
            this.bookdata.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.search;
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
            this.bunifuTransition1.Interval = 5;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Silver;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.search, BunifuAnimatorNS.DecorationType.None);
            this.search.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.search.Icon = ((System.Drawing.Image)(resources.GetObject("search.Icon")));
            this.search.Location = new System.Drawing.Point(433, 9);
            this.search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(229, 23);
            this.search.TabIndex = 1;
            this.search.text = "";
            this.search.OnTextChange += new System.EventHandler(this.Search_OnTextChange);
            // 
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BookManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookManage";
            this.Activated += new System.EventHandler(this.BookManage_Activated);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).EndInit();
            this.footer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bigScreen;
        private Bunifu.Framework.UI.BunifuImageButton smallScreen;
        private Bunifu.Framework.UI.BunifuImageButton eitButton;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 detelesB;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteB;
        private Bunifu.Framework.UI.BunifuThinButton2 editeB;
        private Bunifu.Framework.UI.BunifuThinButton2 addB;
        private System.Windows.Forms.DataGridView bookdata;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuTextbox search;
    }
}

