namespace Book_Mangement
{
    partial class catagory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catagory));
            this.cat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.eitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.add = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // cat
            // 
            this.cat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cat.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cat.HintForeColor = System.Drawing.Color.Empty;
            this.cat.HintText = "";
            this.cat.isPassword = false;
            this.cat.LineFocusedColor = System.Drawing.Color.Green;
            this.cat.LineIdleColor = System.Drawing.Color.Gray;
            this.cat.LineMouseHoverColor = System.Drawing.Color.Green;
            this.cat.LineThickness = 8;
            this.cat.Location = new System.Drawing.Point(57, 225);
            this.cat.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.cat.Name = "cat";
            this.cat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cat.Size = new System.Drawing.Size(498, 53);
            this.cat.TabIndex = 3;
            this.cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(145, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الصنف";
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
            this.eitButton.TabIndex = 5;
            this.eitButton.TabStop = false;
            this.eitButton.Zoom = 10;
            this.eitButton.Click += new System.EventHandler(this.EitButton_Click);
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
            this.add.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.SeaGreen;
            this.add.IdleBorderThickness = 1;
            this.add.IdleCornerRadius = 20;
            this.add.IdleFillColor = System.Drawing.Color.White;
            this.add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.add.Location = new System.Drawing.Point(150, 327);
            this.add.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(300, 75);
            this.add.TabIndex = 4;
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // catagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 419);
            this.Controls.Add(this.eitButton);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "catagory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.eitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox cat;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 add;
        private Bunifu.Framework.UI.BunifuImageButton eitButton;
    }
}