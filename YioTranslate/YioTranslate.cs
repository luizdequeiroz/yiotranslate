using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YioTranslate.Models;
using YioTranslate.Translate;

namespace YioTranslate
{
    public partial class YioTranslate : Form
    {
        public DataTable ConvertListToDataTable<T>(IList<T> list)
        {
            var oDataTable = new DataTable();
            var columns = new List<DataColumn> {
                new DataColumn("ID"),
                new DataColumn("Português".ToUpper()),
                new DataColumn("Yiokarih".ToUpper()),
                new DataColumn("Tipo".ToUpper())
            }.ToArray();

            try
            {
                oDataTable.Columns.AddRange(columns);

                foreach (var item in list)
                {
                    var properties = item.GetType().GetProperties().Select(p => Convert.ToString(p.GetValue(item))).ToList();
                    oDataTable.Rows.Add(properties.ToArray());
                }
            }
            catch { }

            return oDataTable;
        }

        private void LoadDataGridViews()
        {
            try
            {
                var dicios = database.SelectAllDicio();

                if (dicios.Count > 0)
                {
                    //dataTranslationsNone.DataSource = ConvertListToDataTable(dicios.Where(d => d.Type == DicioType.None).ToList());
                    dataTranslationsVerbs.DataSource = ConvertListToDataTable(dicios.Where(d => d.Type == DicioType.VERB).ToList());
                    dataTranslationsAdjectives.DataSource = ConvertListToDataTable(dicios.Where(d => d.Type == DicioType.ADJECTIVE).ToList());
                    dataTranslationsSubjects.DataSource = ConvertListToDataTable(dicios.Where(d => d.Type == DicioType.SUBJECT).ToList());
                    dataTranslationsSubstantives.DataSource = ConvertListToDataTable(dicios.Where(d => d.Type == DicioType.SUBSTANTIVE).ToList());
                }
            }
            catch { }
        }

        private void LoadComboBoxes()
        {
            try
            {
                #region TYPE
                comboType.Items.Insert((int)DicioType.NONE, DicioType.NONE.ToDescriptionString());
                comboType.Items.Insert((int)DicioType.VERB, DicioType.VERB.ToDescriptionString());
                comboType.Items.Insert((int)DicioType.ADJECTIVE, DicioType.ADJECTIVE.ToDescriptionString());
                comboType.Items.Insert((int)DicioType.SUBJECT, DicioType.SUBJECT.ToDescriptionString());
                comboType.Items.Insert((int)DicioType.SUBSTANTIVE, DicioType.SUBSTANTIVE.ToDescriptionString());

                comboType.SelectedIndex = (int)DicioType.NONE;
                comboType.Text = ((DicioType)comboType.SelectedIndex).ToDescriptionString();
                #endregion
                #region TRANSLATE
                comboTranslate.Items.Insert(0, "Palavra");
                comboTranslate.Items.Insert(1, "Texto");
                comboTranslate.SelectedIndex = 0;
                comboTranslate.Text = "Palavra";
                #endregion
            }
            catch { }
        }

        public YioTranslate()
        {
            database = new Database();

            InitializeComponent();
            LoadDataGridViews();
            LoadComboBoxes();
        }

        private void Translate(bool IsToSave)
        {
            try
            {
                var dicioTypeSelected = (DicioType)comboType.SelectedIndex;

                var translator = new Translator();
                string translations = string.Empty;
                var words = textFrom.Text.ToLower().Split(' ');
                foreach (var word in words)
                    if (!string.IsNullOrEmpty(word))
                        translations += translator.TranslateYiok(word, textSugg.Text, dicioTypeSelected, IsToSave);

                textTo.Text = translations;

                //var allRelationships = new List<string>();
                //var translationsArray = translations.Split(' ').Where(t => !string.IsNullOrEmpty(t)).ToArray();
                //foreach(var translation in translationsArray)
                //{
                //    var relationships = database.SelectRelationshipsByYiokWord(translation).Select(r => $"{r.MainDicio} {r.AdjunctDicio}").ToList();
                //    allRelationships.AddRange(relationships);
                //}

                //allRelationships = allRelationships.Distinct().ToList();

                //textSampleYiok.Text = string.Join("\n", allRelationships);
                //textSamplePtbr.Text = string.Join("\n", allRelationships.Select(r => translator.TranslateToPortuguese(r)));
            }
            catch (Exception ex) { }
        }

        private void textFrom_TextChanged(object sender, EventArgs e)
        {
            if (radioToPrimitive.Checked)
            {
                Translate(false);
            }
            else
            {
                try
                {
                    var translator = new Translator();
                    string portugueses = string.Empty;
                    var words = textFrom.Text.ToLower().Split(' ');
                    foreach (var word in words)
                        if (!string.IsNullOrEmpty(word))
                            portugueses += translator.TranslateToPortuguese(word);

                    textTo.Text = portugueses;
                }
                catch { }
            }
        }

        private void radioToPrimitive_CheckedChanged(object sender, EventArgs e)
        {
            textFrom_TextChanged(sender, e);
        }

        private void radioToPortuguese_CheckedChanged(object sender, EventArgs e)
        {
            textFrom_TextChanged(sender, e);
        }

        Point lastPoint;
        private readonly Database database;

        private void YioTranslate_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastPoint.X;
                    this.Top += e.Y - lastPoint.Y;
                }
            }
            catch { }
        }

        private void YioTranslate_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            YioTranslate_MouseMove(sender, e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            YioTranslate_MouseDown(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //if (comboTranslate.SelectedIndex == 1)
            //    ConnectWords(true);
            /*else*/
            Translate(true);

            LoadDataGridViews();
            textFrom.Text = string.Empty;
            textSugg.Text = string.Empty;
            textTo.Text = string.Empty;
        }

        private void ConnectWords(bool IsToSave)
        {
            var words = textTo.Text.ToLower().Split(' ').Where(w => !string.IsNullOrEmpty(w)).ToArray();
            for (var i = 0; i < words.Length; i++)
            {
                if ((i + 1) < words.Length)
                {
                    var main = words[i];
                    var adjunct = words[i + 1];

                    database.InsertRelationship(main, adjunct);
                }
            }
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics gfx = e.Graphics;
                var pp = sender as GroupBox;
                gfx.Clear(pp.BackColor);
                gfx.DrawString(pp.Text, pp.Font, new SolidBrush(pp.ForeColor), new Point(7, 0));
            }
            catch { }
        }

        private void textFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboTranslate.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void comboTranslate_SelectedIndexChanged(object sender, EventArgs e)
        {
            textFrom.Text = string.Empty;
            textTo.Text = string.Empty;

            //if ((sender as ComboBox).SelectedIndex == 1)
            //    buttonSave.Text = "Relacionar";
            /*else*/
            buttonSave.Text = "Salvar";
        }

        private void dataTranslations_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DeleteTranslation(sender as DataGridView);
                }
            }
            catch { }
        }

        private void DeleteTranslation(DataGridView dataGridView)
        {
            var rowIds = new List<int>();
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                var row = dataGridView.Rows[cell.RowIndex];
                rowIds.Add(Convert.ToInt32(cell.DataGridView[0, cell.RowIndex].Value));
            }

            foreach (var id in rowIds)
            {
                var database = new Database();

                database.DeleteTranslation(id);
            }

            LoadDataGridViews();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            comboType.SelectedIndex = (sender as TabControl).SelectedIndex + 1;
            comboType.Text = ((DicioType)comboType.SelectedIndex).ToDescriptionString();
        }
    }
}
