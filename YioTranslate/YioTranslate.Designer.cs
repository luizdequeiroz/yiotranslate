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
            this.groupToSave = new System.Windows.Forms.GroupBox();
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataTranslationsVerbs = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.labelSubstantives = new System.Windows.Forms.Label();
            this.labelSubjects = new System.Windows.Forms.Label();
            this.labelAdjectives = new System.Windows.Forms.Label();
            this.labelVerbs = new System.Windows.Forms.Label();
            this.dataAllVerbs = new System.Windows.Forms.DataGridView();
            this.dataAllAdjectives = new System.Windows.Forms.DataGridView();
            this.dataAllSubjects = new System.Windows.Forms.DataGridView();
            this.dataAllSubstantives = new System.Windows.Forms.DataGridView();
            this.tabVerbs = new System.Windows.Forms.TabPage();
            this.tabAdjectives = new System.Windows.Forms.TabPage();
            this.dataTranslationsAdjectives = new System.Windows.Forms.DataGridView();
            this.tabSubjects = new System.Windows.Forms.TabPage();
            this.dataTranslationsSubjects = new System.Windows.Forms.DataGridView();
            this.tabSubstantives = new System.Windows.Forms.TabPage();
            this.dataTranslationsSubstantives = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.version = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupToSave.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsVerbs)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllVerbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllAdjectives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllSubstantives)).BeginInit();
            this.tabVerbs.SuspendLayout();
            this.tabAdjectives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsAdjectives)).BeginInit();
            this.tabSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubjects)).BeginInit();
            this.tabSubstantives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubstantives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textTo
            // 
            this.textTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTo.Location = new System.Drawing.Point(6, 118);
            this.textTo.Multiline = true;
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(570, 60);
            this.textTo.TabIndex = 5;
            // 
            // radioToPortuguese
            // 
            this.radioToPortuguese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioToPortuguese.AutoSize = true;
            this.radioToPortuguese.Location = new System.Drawing.Point(438, 10);
            this.radioToPortuguese.Name = "radioToPortuguese";
            this.radioToPortuguese.Size = new System.Drawing.Size(129, 17);
            this.radioToPortuguese.TabIndex = 7;
            this.radioToPortuguese.Text = "Primitivo p/ Português";
            this.radioToPortuguese.UseVisualStyleBackColor = true;
            this.radioToPortuguese.CheckedChanged += new System.EventHandler(this.radioToPortuguese_CheckedChanged);
            // 
            // radioToPrimitive
            // 
            this.radioToPrimitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioToPrimitive.AutoSize = true;
            this.radioToPrimitive.Checked = true;
            this.radioToPrimitive.Location = new System.Drawing.Point(303, 10);
            this.radioToPrimitive.Name = "radioToPrimitive";
            this.radioToPrimitive.Size = new System.Drawing.Size(129, 17);
            this.radioToPrimitive.TabIndex = 6;
            this.radioToPrimitive.TabStop = true;
            this.radioToPrimitive.Text = "Português p/ Primitivo";
            this.radioToPrimitive.UseVisualStyleBackColor = true;
            this.radioToPrimitive.CheckedChanged += new System.EventHandler(this.radioToPrimitive_CheckedChanged);
            // 
            // groupToSave
            // 
            this.groupToSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupToSave.BackColor = System.Drawing.Color.White;
            this.groupToSave.Controls.Add(this.label2);
            this.groupToSave.Controls.Add(this.comboType);
            this.groupToSave.Controls.Add(this.buttonSave);
            this.groupToSave.Controls.Add(this.textSugg);
            this.groupToSave.Controls.Add(this.label1);
            this.groupToSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupToSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupToSave.Location = new System.Drawing.Point(6, 184);
            this.groupToSave.Name = "groupToSave";
            this.groupToSave.Size = new System.Drawing.Size(570, 35);
            this.groupToSave.TabIndex = 8;
            this.groupToSave.TabStop = false;
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
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(471, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textSugg
            // 
            this.textSugg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSugg.Location = new System.Drawing.Point(365, 11);
            this.textSugg.Name = "textSugg";
            this.textSugg.Size = new System.Drawing.Size(100, 20);
            this.textSugg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sugestão/Variação";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textFrom);
            this.groupBox2.Controls.Add(this.groupToSave);
            this.groupBox2.Controls.Add(this.textTo);
            this.groupBox2.Location = new System.Drawing.Point(297, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 225);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.comboTranslate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.radioToPrimitive);
            this.groupBox3.Controls.Add(this.radioToPortuguese);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 35);
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
            this.textFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrom.Location = new System.Drawing.Point(6, 10);
            this.textFrom.Multiline = true;
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(570, 60);
            this.textFrom.TabIndex = 2;
            this.textFrom.TextChanged += new System.EventHandler(this.textFrom_TextChanged);
            this.textFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFrom_KeyDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(868, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataTranslationsVerbs
            // 
            this.dataTranslationsVerbs.AllowUserToAddRows = false;
            this.dataTranslationsVerbs.AllowUserToResizeColumns = false;
            this.dataTranslationsVerbs.AllowUserToResizeRows = false;
            this.dataTranslationsVerbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTranslationsVerbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsVerbs.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsVerbs.Name = "dataTranslationsVerbs";
            this.dataTranslationsVerbs.Size = new System.Drawing.Size(853, 342);
            this.dataTranslationsVerbs.TabIndex = 14;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAll);
            this.tabControl.Controls.Add(this.tabVerbs);
            this.tabControl.Controls.Add(this.tabAdjectives);
            this.tabControl.Controls.Add(this.tabSubjects);
            this.tabControl.Controls.Add(this.tabSubstantives);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(16, 244);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(861, 368);
            this.tabControl.TabIndex = 12;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.labelSubstantives);
            this.tabAll.Controls.Add(this.labelSubjects);
            this.tabAll.Controls.Add(this.labelAdjectives);
            this.tabAll.Controls.Add(this.labelVerbs);
            this.tabAll.Controls.Add(this.dataAllVerbs);
            this.tabAll.Controls.Add(this.dataAllAdjectives);
            this.tabAll.Controls.Add(this.dataAllSubjects);
            this.tabAll.Controls.Add(this.dataAllSubstantives);
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(853, 342);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "Todos";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // labelSubstantives
            // 
            this.labelSubstantives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubstantives.Location = new System.Drawing.Point(639, 0);
            this.labelSubstantives.Name = "labelSubstantives";
            this.labelSubstantives.Size = new System.Drawing.Size(214, 21);
            this.labelSubstantives.TabIndex = 22;
            this.labelSubstantives.Text = "SUBSTANTIVOS";
            this.labelSubstantives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubjects
            // 
            this.labelSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjects.Location = new System.Drawing.Point(426, 0);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(214, 21);
            this.labelSubjects.TabIndex = 21;
            this.labelSubjects.Text = "SUJEITOS";
            this.labelSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdjectives
            // 
            this.labelAdjectives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdjectives.Location = new System.Drawing.Point(213, 0);
            this.labelAdjectives.Name = "labelAdjectives";
            this.labelAdjectives.Size = new System.Drawing.Size(214, 21);
            this.labelAdjectives.TabIndex = 20;
            this.labelAdjectives.Text = "ADJETIVOS";
            this.labelAdjectives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVerbs
            // 
            this.labelVerbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerbs.Location = new System.Drawing.Point(0, 0);
            this.labelVerbs.Name = "labelVerbs";
            this.labelVerbs.Size = new System.Drawing.Size(214, 21);
            this.labelVerbs.TabIndex = 19;
            this.labelVerbs.Text = "VERBOS";
            this.labelVerbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataAllVerbs
            // 
            this.dataAllVerbs.AllowUserToAddRows = false;
            this.dataAllVerbs.AllowUserToDeleteRows = false;
            this.dataAllVerbs.AllowUserToResizeColumns = false;
            this.dataAllVerbs.AllowUserToResizeRows = false;
            this.dataAllVerbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAllVerbs.Location = new System.Drawing.Point(0, 24);
            this.dataAllVerbs.Name = "dataAllVerbs";
            this.dataAllVerbs.RowHeadersVisible = false;
            this.dataAllVerbs.RowHeadersWidth = 30;
            this.dataAllVerbs.Size = new System.Drawing.Size(214, 318);
            this.dataAllVerbs.TabIndex = 15;
            // 
            // dataAllAdjectives
            // 
            this.dataAllAdjectives.AllowUserToAddRows = false;
            this.dataAllAdjectives.AllowUserToDeleteRows = false;
            this.dataAllAdjectives.AllowUserToResizeColumns = false;
            this.dataAllAdjectives.AllowUserToResizeRows = false;
            this.dataAllAdjectives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAllAdjectives.Location = new System.Drawing.Point(213, 24);
            this.dataAllAdjectives.Name = "dataAllAdjectives";
            this.dataAllAdjectives.RowHeadersVisible = false;
            this.dataAllAdjectives.Size = new System.Drawing.Size(214, 318);
            this.dataAllAdjectives.TabIndex = 16;
            // 
            // dataAllSubjects
            // 
            this.dataAllSubjects.AllowUserToAddRows = false;
            this.dataAllSubjects.AllowUserToDeleteRows = false;
            this.dataAllSubjects.AllowUserToResizeColumns = false;
            this.dataAllSubjects.AllowUserToResizeRows = false;
            this.dataAllSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAllSubjects.Location = new System.Drawing.Point(426, 24);
            this.dataAllSubjects.Name = "dataAllSubjects";
            this.dataAllSubjects.RowHeadersVisible = false;
            this.dataAllSubjects.Size = new System.Drawing.Size(214, 318);
            this.dataAllSubjects.TabIndex = 17;
            // 
            // dataAllSubstantives
            // 
            this.dataAllSubstantives.AllowUserToAddRows = false;
            this.dataAllSubstantives.AllowUserToDeleteRows = false;
            this.dataAllSubstantives.AllowUserToResizeColumns = false;
            this.dataAllSubstantives.AllowUserToResizeRows = false;
            this.dataAllSubstantives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAllSubstantives.Location = new System.Drawing.Point(639, 24);
            this.dataAllSubstantives.Name = "dataAllSubstantives";
            this.dataAllSubstantives.RowHeadersVisible = false;
            this.dataAllSubstantives.Size = new System.Drawing.Size(214, 318);
            this.dataAllSubstantives.TabIndex = 18;
            // 
            // tabVerbs
            // 
            this.tabVerbs.Controls.Add(this.dataTranslationsVerbs);
            this.tabVerbs.Location = new System.Drawing.Point(4, 22);
            this.tabVerbs.Name = "tabVerbs";
            this.tabVerbs.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerbs.Size = new System.Drawing.Size(853, 342);
            this.tabVerbs.TabIndex = 1;
            this.tabVerbs.Text = "Verbos";
            this.tabVerbs.UseVisualStyleBackColor = true;
            // 
            // tabAdjectives
            // 
            this.tabAdjectives.Controls.Add(this.dataTranslationsAdjectives);
            this.tabAdjectives.Location = new System.Drawing.Point(4, 22);
            this.tabAdjectives.Name = "tabAdjectives";
            this.tabAdjectives.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdjectives.Size = new System.Drawing.Size(853, 342);
            this.tabAdjectives.TabIndex = 2;
            this.tabAdjectives.Text = "Adjetivos";
            this.tabAdjectives.UseVisualStyleBackColor = true;
            // 
            // dataTranslationsAdjectives
            // 
            this.dataTranslationsAdjectives.AllowUserToAddRows = false;
            this.dataTranslationsAdjectives.AllowUserToResizeColumns = false;
            this.dataTranslationsAdjectives.AllowUserToResizeRows = false;
            this.dataTranslationsAdjectives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTranslationsAdjectives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsAdjectives.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsAdjectives.Name = "dataTranslationsAdjectives";
            this.dataTranslationsAdjectives.Size = new System.Drawing.Size(853, 342);
            this.dataTranslationsAdjectives.TabIndex = 15;
            // 
            // tabSubjects
            // 
            this.tabSubjects.Controls.Add(this.dataTranslationsSubjects);
            this.tabSubjects.Location = new System.Drawing.Point(4, 22);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubjects.Size = new System.Drawing.Size(853, 342);
            this.tabSubjects.TabIndex = 3;
            this.tabSubjects.Text = "Sujeitos";
            this.tabSubjects.UseVisualStyleBackColor = true;
            // 
            // dataTranslationsSubjects
            // 
            this.dataTranslationsSubjects.AllowUserToAddRows = false;
            this.dataTranslationsSubjects.AllowUserToResizeColumns = false;
            this.dataTranslationsSubjects.AllowUserToResizeRows = false;
            this.dataTranslationsSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTranslationsSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsSubjects.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsSubjects.Name = "dataTranslationsSubjects";
            this.dataTranslationsSubjects.Size = new System.Drawing.Size(853, 342);
            this.dataTranslationsSubjects.TabIndex = 16;
            // 
            // tabSubstantives
            // 
            this.tabSubstantives.Controls.Add(this.dataTranslationsSubstantives);
            this.tabSubstantives.Location = new System.Drawing.Point(4, 22);
            this.tabSubstantives.Name = "tabSubstantives";
            this.tabSubstantives.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubstantives.Size = new System.Drawing.Size(853, 342);
            this.tabSubstantives.TabIndex = 4;
            this.tabSubstantives.Text = "Substantivos";
            this.tabSubstantives.UseVisualStyleBackColor = true;
            // 
            // dataTranslationsSubstantives
            // 
            this.dataTranslationsSubstantives.AllowUserToAddRows = false;
            this.dataTranslationsSubstantives.AllowUserToResizeColumns = false;
            this.dataTranslationsSubstantives.AllowUserToResizeRows = false;
            this.dataTranslationsSubstantives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTranslationsSubstantives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTranslationsSubstantives.Location = new System.Drawing.Point(0, 0);
            this.dataTranslationsSubstantives.Name = "dataTranslationsSubstantives";
            this.dataTranslationsSubstantives.Size = new System.Drawing.Size(853, 342);
            this.dataTranslationsSubstantives.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::YioTranslate.Properties.Resources._2Primitivos;
            this.pictureBox2.Location = new System.Drawing.Point(23, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(796, 616);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(827, 630);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(46, 13);
            this.version.TabIndex = 15;
            this.version.Text = "v1.0.0.0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // YioTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(891, 652);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.version);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YioTranslate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YioTranslate";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YioTranslate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YioTranslate_MouseMove);
            this.groupToSave.ResumeLayout(false);
            this.groupToSave.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsVerbs)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAllVerbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllAdjectives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllSubstantives)).EndInit();
            this.tabVerbs.ResumeLayout(false);
            this.tabAdjectives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsAdjectives)).EndInit();
            this.tabSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubjects)).EndInit();
            this.tabSubstantives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTranslationsSubstantives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBoxCustom textFrom;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.RadioButton radioToPortuguese;
        private System.Windows.Forms.RadioButton radioToPrimitive;
        private System.Windows.Forms.GroupBox groupToSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textSugg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
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
        private DataGridView dataTranslationsVerbs;
        private DataGridView dataTranslationsAdjectives;
        private DataGridView dataTranslationsSubjects;
        private DataGridView dataTranslationsSubstantives;
        private TabPage tabAll;
        private DataGridView dataAllVerbs;
        private DataGridView dataAllAdjectives;
        private DataGridView dataAllSubjects;
        private DataGridView dataAllSubstantives;
        private Label labelSubstantives;
        private Label labelSubjects;
        private Label labelAdjectives;
        private Label labelVerbs;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label version;
        private PictureBox pictureBox3;
    }
}