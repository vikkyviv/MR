namespace LetterHeadingForm
{
    partial class frmLetterHeadingForm
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
            System.Windows.Forms.Button btnClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLetterHeadingForm));
            this.linkLabelText = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFontStyle = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.linkLblText = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLetterHead = new System.Windows.Forms.RichTextBox();
            this.pictureBxImage = new System.Windows.Forms.PictureBox();
            this.btnAddLogo = new System.Windows.Forms.Button();
            this.grpbxPrintLetterHead = new System.Windows.Forms.GroupBox();
            this.rdbtnprintwithoutlogo = new System.Windows.Forms.RadioButton();
            this.rdbtnprintletterheadlandr = new System.Windows.Forms.RadioButton();
            this.rdbtnPrintLetterHeadrandleft = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxImage)).BeginInit();
            this.grpbxPrintLetterHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnClose.Location = new System.Drawing.Point(596, 427);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(75, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLabelText
            // 
            this.linkLabelText.AutoSize = true;
            this.linkLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelText.Location = new System.Drawing.Point(342, 23);
            this.linkLabelText.Name = "linkLabelText";
            this.linkLabelText.Size = new System.Drawing.Size(341, 20);
            this.linkLabelText.TabIndex = 0;
            this.linkLabelText.TabStop = true;
            this.linkLabelText.Text = "TYPE YOUR LETTER HEAD TEXT HERE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFontStyle);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(btnClose);
            this.panel1.Controls.Add(this.linkLblText);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 473);
            this.panel1.TabIndex = 1;
            // 
            // btnFontStyle
            // 
            this.btnFontStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFontStyle.Location = new System.Drawing.Point(327, 427);
            this.btnFontStyle.Name = "btnFontStyle";
            this.btnFontStyle.Size = new System.Drawing.Size(134, 23);
            this.btnFontStyle.TabIndex = 3;
            this.btnFontStyle.Text = "FontStyle";
            this.btnFontStyle.UseVisualStyleBackColor = true;
            this.btnFontStyle.Click += new System.EventHandler(this.btnFontStyle_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(486, 427);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // linkLblText
            // 
            this.linkLblText.AutoSize = true;
            this.linkLblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblText.Location = new System.Drawing.Point(394, 199);
            this.linkLblText.Name = "linkLblText";
            this.linkLblText.Size = new System.Drawing.Size(238, 20);
            this.linkLblText.TabIndex = 2;
            this.linkLblText.TabStop = true;
            this.linkLblText.Text = "Choose Letter Head Options";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtLetterHead);
            this.panel3.Controls.Add(this.pictureBxImage);
            this.panel3.Controls.Add(this.btnAddLogo);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 170);
            this.panel3.TabIndex = 3;
            // 
            // txtLetterHead
            // 
            this.txtLetterHead.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetterHead.Location = new System.Drawing.Point(137, 18);
            this.txtLetterHead.Name = "txtLetterHead";
            this.txtLetterHead.Size = new System.Drawing.Size(664, 125);
            this.txtLetterHead.TabIndex = 3;
            this.txtLetterHead.Text = "";
            // 
            // pictureBxImage
            // 
            this.pictureBxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBxImage.Location = new System.Drawing.Point(16, 18);
            this.pictureBxImage.Name = "pictureBxImage";
            this.pictureBxImage.Size = new System.Drawing.Size(113, 96);
            this.pictureBxImage.TabIndex = 1;
            this.pictureBxImage.TabStop = false;
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLogo.Location = new System.Drawing.Point(34, 120);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(75, 23);
            this.btnAddLogo.TabIndex = 2;
            this.btnAddLogo.Text = "AddLogo";
            this.btnAddLogo.UseVisualStyleBackColor = false;
            this.btnAddLogo.Click += new System.EventHandler(this.btnAddLogo_Click);
            // 
            // grpbxPrintLetterHead
            // 
            this.grpbxPrintLetterHead.Controls.Add(this.rdbtnprintwithoutlogo);
            this.grpbxPrintLetterHead.Controls.Add(this.rdbtnprintletterheadlandr);
            this.grpbxPrintLetterHead.Controls.Add(this.rdbtnPrintLetterHeadrandleft);
            this.grpbxPrintLetterHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPrintLetterHead.Location = new System.Drawing.Point(319, 295);
            this.grpbxPrintLetterHead.Name = "grpbxPrintLetterHead";
            this.grpbxPrintLetterHead.Size = new System.Drawing.Size(462, 157);
            this.grpbxPrintLetterHead.TabIndex = 2;
            this.grpbxPrintLetterHead.TabStop = false;
            this.grpbxPrintLetterHead.Text = "Print Letter Head";
       
            // 
            // rdbtnprintwithoutlogo
            // 
            this.rdbtnprintwithoutlogo.AutoSize = true;
            this.rdbtnprintwithoutlogo.Location = new System.Drawing.Point(91, 115);
            this.rdbtnprintwithoutlogo.Name = "rdbtnprintwithoutlogo";
            this.rdbtnprintwithoutlogo.Size = new System.Drawing.Size(299, 20);
            this.rdbtnprintwithoutlogo.TabIndex = 2;
            this.rdbtnprintwithoutlogo.TabStop = true;
            this.rdbtnprintwithoutlogo.Text = "Print Without Logo and only Letter Head";
            this.rdbtnprintwithoutlogo.UseVisualStyleBackColor = true;
            this.rdbtnprintwithoutlogo.CheckedChanged += new System.EventHandler(this.rdbtnprintwithoutlogo_CheckedChanged);
            // 
            // rdbtnprintletterheadlandr
            // 
            this.rdbtnprintletterheadlandr.AutoSize = true;
            this.rdbtnprintletterheadlandr.Location = new System.Drawing.Point(91, 78);
            this.rdbtnprintletterheadlandr.Name = "rdbtnprintletterheadlandr";
            this.rdbtnprintletterheadlandr.Size = new System.Drawing.Size(308, 20);
            this.rdbtnprintletterheadlandr.TabIndex = 1;
            this.rdbtnprintletterheadlandr.TabStop = true;
            this.rdbtnprintletterheadlandr.Text = "Print Letter Head on left ang logo on right";
            this.rdbtnprintletterheadlandr.UseVisualStyleBackColor = true;
            this.rdbtnprintletterheadlandr.CheckedChanged += new System.EventHandler(this.rdbtnprintletterheadlandr_CheckedChanged);
            // 
            // rdbtnPrintLetterHeadrandleft
            // 
            this.rdbtnPrintLetterHeadrandleft.AutoSize = true;
            this.rdbtnPrintLetterHeadrandleft.Location = new System.Drawing.Point(91, 38);
            this.rdbtnPrintLetterHeadrandleft.Name = "rdbtnPrintLetterHeadrandleft";
            this.rdbtnPrintLetterHeadrandleft.Size = new System.Drawing.Size(308, 20);
            this.rdbtnPrintLetterHeadrandleft.TabIndex = 0;
            this.rdbtnPrintLetterHeadrandleft.TabStop = true;
            this.rdbtnPrintLetterHeadrandleft.Text = "Print Letter Head on right ang logo on left";
            this.rdbtnPrintLetterHeadrandleft.UseVisualStyleBackColor = true;
            this.rdbtnPrintLetterHeadrandleft.CheckedChanged += new System.EventHandler(this.rdbtnPrintLetterHeadrandleft_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmLetterHeadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 541);
            this.Controls.Add(this.grpbxPrintLetterHead);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelText);
            this.Name = "frmLetterHeadingForm";
            this.Text = "LETTER HEADING FORM";
            this.Load += new System.EventHandler(this.frmLetterHeadingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxImage)).EndInit();
            this.grpbxPrintLetterHead.ResumeLayout(false);
            this.grpbxPrintLetterHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddLogo;
        private System.Windows.Forms.PictureBox pictureBxImage;
        private System.Windows.Forms.Button btnFontStyle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel linkLblText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpbxPrintLetterHead;
        private System.Windows.Forms.RadioButton rdbtnprintwithoutlogo;
        private System.Windows.Forms.RadioButton rdbtnprintletterheadlandr;
        private System.Windows.Forms.RadioButton rdbtnPrintLetterHeadrandleft;
        private System.Windows.Forms.RichTextBox txtLetterHead;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

