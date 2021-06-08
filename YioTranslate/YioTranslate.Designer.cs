namespace YioTranslate
{
    partial class YioTranslate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YioTranslate));
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.radioToPortuguese = new System.Windows.Forms.RadioButton();
            this.radioToPrimitive = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSugg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(6, 10);
            this.textFrom.Multiline = true;
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(494, 88);
            this.textFrom.TabIndex = 2;
            this.textFrom.TextChanged += new System.EventHandler(this.textFrom_TextChanged);
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(6, 145);
            this.textTo.Multiline = true;
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(494, 88);
            this.textTo.TabIndex = 5;
            // 
            // radioToPortuguese
            // 
            this.radioToPortuguese.AutoSize = true;
            this.radioToPortuguese.Location = new System.Drawing.Point(141, 12);
            this.radioToPortuguese.Name = "radioToPortuguese";
            this.radioToPortuguese.Size = new System.Drawing.Size(129, 17);
            this.radioToPortuguese.TabIndex = 7;
            this.radioToPortuguese.Text = "Primitivo p/ Português";
            this.radioToPortuguese.UseVisualStyleBackColor = true;
            this.radioToPortuguese.CheckedChanged += new System.EventHandler(this.radioToPortuguese_CheckedChanged);
            // 
            // radioToPrimitive
            // 
            this.radioToPrimitive.AutoSize = true;
            this.radioToPrimitive.Checked = true;
            this.radioToPrimitive.Location = new System.Drawing.Point(6, 12);
            this.radioToPrimitive.Name = "radioToPrimitive";
            this.radioToPrimitive.Size = new System.Drawing.Size(129, 17);
            this.radioToPrimitive.TabIndex = 6;
            this.radioToPrimitive.TabStop = true;
            this.radioToPrimitive.Text = "Português p/ Primitivo";
            this.radioToPrimitive.UseVisualStyleBackColor = true;
            this.radioToPrimitive.CheckedChanged += new System.EventHandler(this.radioToPrimitive_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textSugg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioToPrimitive);
            this.groupBox1.Controls.Add(this.radioToPortuguese);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(8, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 35);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // textSugg
            // 
            this.textSugg.Location = new System.Drawing.Point(355, 11);
            this.textSugg.Name = "textSugg";
            this.textSugg.Size = new System.Drawing.Size(100, 20);
            this.textSugg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sugestão";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textFrom);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textTo);
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 241);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Location = new System.Drawing.Point(488, 18);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(460, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YioTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(530, 543);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YioTranslate";
            this.Text = "YioTranslate";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YioTranslate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YioTranslate_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.RadioButton radioToPortuguese;
        private System.Windows.Forms.RadioButton radioToPrimitive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textSugg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
    }
}