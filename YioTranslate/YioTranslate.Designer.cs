using System.Drawing;
using System.Windows.Forms;

public class TextBoxCustom : TextBox
{
    protected override bool ProcessCmdKey(ref Message m, Keys keyData)
    {
        if (keyData == (Keys.Control | Keys.Back))
        {
            SendKeys.SendWait("^+{LEFT}{BACKSPACE}");
            return true;
        }

        return base.ProcessCmdKey(ref m, keyData);
    }
}

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
            this.textTo = new System.Windows.Forms.TextBox();
            this.radioToPortuguese = new System.Windows.Forms.RadioButton();
            this.radioToPrimitive = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textSugg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboTranslate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFrom = new TextBoxCustom();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataTranslationsVerbs = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVerbs = new System.Windows.Forms.TabPage();
            this.tabAdjectives = new System.Windows.Forms.TabPage();
            this.dataTranslationsAdjectives = new System.Windows.Forms.DataGridView();
            this.tabSubjects = new System.Windows.Forms.TabPage();
            this.dataTranslationsSubjects = new System.Windows.Forms.DataGridView();
            this.tabSubstantives = new System.Windows.Forms.TabPage();
            this.dataTranslationsSubstantives = new System.Windows.Forms.DataGridView();
            this.textSampleYiok = new System.Windows.Forms.TextBox();
            this.textSamplePtbr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsVerbs)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabVerbs.SuspendLayout();
            this.tabAdjectives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsAdjectives)).BeginInit();
            this.tabSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubjects)).BeginInit();
            this.tabSubstantives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubstantives)).BeginInit();
            this.SuspendLayout();
            // 
            // textTo
            // 
            this.textTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTo.Location = new System.Drawing.Point(6, 158);
            this.textTo.Multiline = true;
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(494, 60);
            this.textTo.TabIndex = 5;
            // 
            // radioToPortuguese
            // 
            this.radioToPortuguese.AutoSize = true;
            this.radioToPortuguese.Location = new System.Drawing.Point(362, 10);
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
            this.radioToPrimitive.Location = new System.Drawing.Point(227, 10);
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textSugg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(6, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 35);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(40, 10);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(114, 21);
            this.comboType.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(395, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textSugg
            // 
            this.textSugg.Location = new System.Drawing.Point(289, 11);
            this.textSugg.Name = "textSugg";
            this.textSugg.Size = new System.Drawing.Size(100, 20);
            this.textSugg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sugestão/Variação";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textFrom);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textTo);
            this.groupBox2.Location = new System.Drawing.Point(16, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 225);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.comboTranslate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.radioToPrimitive);
            this.groupBox3.Controls.Add(this.radioToPortuguese);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 35);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // comboTranslate
            // 
            this.comboTranslate.FormattingEnabled = true;
            this.comboTranslate.Location = new System.Drawing.Point(57, 9);
            this.comboTranslate.Name = "comboTranslate";
            this.comboTranslate.Size = new System.Drawing.Size(114, 21);
            this.comboTranslate.TabIndex = 15;
            this.comboTranslate.SelectedIndexChanged += new System.EventHandler(this.comboTranslate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Traduzir";
            // 
            // textFrom
            // 
            this.textFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrom.Location = new System.Drawing.Point(6, 10);
            this.textFrom.Multiline = true;
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(494, 60);
            this.textFrom.TabIndex = 2;
            this.textFrom.TextChanged += new System.EventHandler(this.textFrom_TextChanged);
            this.textFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFrom_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(511, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataTranslationsVerbs
            // 
            this.dataTranslationsVerbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsVerbs.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsVerbs.Name = "dataTranslationsVerbs";
            this.dataTranslationsVerbs.Size = new System.Drawing.Size(498, 254);
            this.dataTranslationsVerbs.TabIndex = 14;
            this.dataTranslationsVerbs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTranslations_KeyUp);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVerbs);
            this.tabControl.Controls.Add(this.tabAdjectives);
            this.tabControl.Controls.Add(this.tabSubjects);
            this.tabControl.Controls.Add(this.tabSubstantives);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(16, 295);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(506, 280);
            this.tabControl.TabIndex = 12;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabVerbs
            // 
            this.tabVerbs.Controls.Add(this.dataTranslationsVerbs);
            this.tabVerbs.Location = new System.Drawing.Point(4, 22);
            this.tabVerbs.Name = "tabVerbs";
            this.tabVerbs.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerbs.Size = new System.Drawing.Size(498, 254);
            this.tabVerbs.TabIndex = 0;
            this.tabVerbs.Text = "Verbos";
            this.tabVerbs.UseVisualStyleBackColor = true;
            // 
            // tabAdjectives
            // 
            this.tabAdjectives.Controls.Add(this.dataTranslationsAdjectives);
            this.tabAdjectives.Location = new System.Drawing.Point(4, 22);
            this.tabAdjectives.Name = "tabAdjectives";
            this.tabAdjectives.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdjectives.Size = new System.Drawing.Size(498, 254);
            this.tabAdjectives.TabIndex = 1;
            this.tabAdjectives.Text = "Adjetivos";
            this.tabAdjectives.UseVisualStyleBackColor = true;
            // 
            // dataTranslationsAdjectives
            // 
            this.dataTranslationsAdjectives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsAdjectives.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsAdjectives.Name = "dataTranslationsAdjectives";
            this.dataTranslationsAdjectives.Size = new System.Drawing.Size(498, 254);
            this.dataTranslationsAdjectives.TabIndex = 15;
            this.dataTranslationsAdjectives.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTranslations_KeyUp);
            // 
            // tabSubjects
            // 
            this.tabSubjects.Controls.Add(this.dataTranslationsSubjects);
            this.tabSubjects.Location = new System.Drawing.Point(4, 22);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubjects.Size = new System.Drawing.Size(498, 254);
            this.tabSubjects.TabIndex = 2;
            this.tabSubjects.Text = "Sujeitos";
            this.tabSubjects.UseVisualStyleBackColor = true;
            // 
            // dataTranslationsSubjects
            // 
            this.dataTranslationsSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsSubjects.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsSubjects.Name = "dataTranslationsSubjects";
            this.dataTranslationsSubjects.Size = new System.Drawing.Size(498, 254);
            this.dataTranslationsSubjects.TabIndex = 16;
            this.dataTranslationsSubjects.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTranslations_KeyUp);
            // 
            // tabSubstantives
            // 
            this.tabSubstantives.Controls.Add(this.dataTranslationsSubstantives);
            this.tabSubstantives.Location = new System.Drawing.Point(4, 22);
            this.tabSubstantives.Name = "tabSubstantives";
            this.tabSubstantives.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubstantives.Size = new System.Drawing.Size(498, 254);
            this.tabSubstantives.TabIndex = 3;
            this.tabSubstantives.Text = "Substantivos";
            this.tabSubstantives.UseVisualStyleBackColor = true;
            // 
            // dataTranslationsSubstantives
            // 
            this.dataTranslationsSubstantives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsSubstantives.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsSubstantives.Name = "dataTranslationsSubstantives";
            this.dataTranslationsSubstantives.Size = new System.Drawing.Size(498, 254);
            this.dataTranslationsSubstantives.TabIndex = 17;
            this.dataTranslationsSubstantives.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTranslations_KeyUp);
            // 
            // textSamplesYiok
            // 
            this.textSampleYiok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.textSampleYiok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSampleYiok.Enabled = false;
            this.textSampleYiok.ForeColor = System.Drawing.SystemColors.Window;
            this.textSampleYiok.Location = new System.Drawing.Point(16, 582);
            this.textSampleYiok.Multiline = true;
            this.textSampleYiok.Name = "textSamplesYiok";
            this.textSampleYiok.Size = new System.Drawing.Size(253, 69);
            this.textSampleYiok.TabIndex = 13;
            // 
            // textSamplePtbr
            // 
            this.textSamplePtbr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.textSamplePtbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSamplePtbr.Enabled = false;
            this.textSamplePtbr.ForeColor = System.Drawing.SystemColors.Window;
            this.textSamplePtbr.Location = new System.Drawing.Point(269, 582);
            this.textSamplePtbr.Multiline = true;
            this.textSamplePtbr.Name = "textSamplePtbr";
            this.textSamplePtbr.Size = new System.Drawing.Size(253, 69);
            this.textSamplePtbr.TabIndex = 14;
            // 
            // YioTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(534, 663);
            this.Controls.Add(this.textSamplePtbr);
            this.Controls.Add(this.textSampleYiok);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YioTranslate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YioTranslate";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YioTranslate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YioTranslate_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsVerbs)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabVerbs.ResumeLayout(false);
            this.tabAdjectives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsAdjectives)).EndInit();
            this.tabSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubjects)).EndInit();
            this.tabSubstantives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubstantives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBoxCustom textFrom;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.RadioButton radioToPortuguese;
        private System.Windows.Forms.RadioButton radioToPrimitive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textSugg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private DataGridView dataTranslationsVerbs;
        private GroupBox groupBox3;
        private Label label2;
        private ComboBox comboType;
        private ComboBox comboTranslate;
        private Label label3;
        private TabControl tabControl;
        private TabPage tabVerbs;
        private TabPage tabAdjectives;
        private TabPage tabSubjects;
        private TabPage tabSubstantives;
        private DataGridView dataTranslationsAdjectives;
        private DataGridView dataTranslationsSubjects;
        private DataGridView dataTranslationsSubstantives;
        private TextBox textSampleYiok;
        private TextBox textSamplePtbr;
    }
}