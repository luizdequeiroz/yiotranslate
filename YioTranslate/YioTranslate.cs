using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using YioTranslate.Models;
using YioTranslate.Translate;

namespace YioTranslate
{
    public partial class YioTranslate : Form
    {


        private void LoadDataGridViews()
        {
            try
            {
                var dicios = database.SelectAllDicio().OrderBy(d => d.PtBr).ToList();

                if (dicios.Count > 0)
                {
                    dataTranslationsVerbs.AddListToDataTable(dicios.Where(d => d.Type == DicioType.VERB).ToList());
                    dataAllVerbs.AddListToDataTable(dicios.Where(d => d.Type == DicioType.VERB).ToList());

                    dataTranslationsAdjectives.AddListToDataTable(dicios.Where(d => d.Type == DicioType.ADJECTIVE).ToList());
                    dataAllAdjectives.AddListToDataTable(dicios.Where(d => d.Type == DicioType.ADJECTIVE).ToList());

                    dataTranslationsSubjects.AddListToDataTable(dicios.Where(d => d.Type == DicioType.SUBJECT).ToList());
                    dataAllSubjects.AddListToDataTable(dicios.Where(d => d.Type == DicioType.SUBJECT).ToList());

                    dataTranslationsSubstantives.AddListToDataTable(dicios.Where(d => d.Type == DicioType.SUBSTANTIVE).ToList());
                    dataAllSubstantives.AddListToDataTable(dicios.Where(d => d.Type == DicioType.SUBSTANTIVE).ToList());
                }
            }
            catch { }
        }

        private void LoadComboBoxes()
        {
            try
            {
                #region TYPE
                comboType.Items.Insert((int)DicioType.VERB, DicioType.VERB.ToDescriptionString());
                comboType.Items.Insert((int)DicioType.ADJECTIVE, DicioType.ADJECTIVE.ToDescriptionString());
                comboType.Items.Insert((int)DicioType.SUBJECT, DicioType.SUBJECT.ToDescriptionString());
                comboType.Items.Insert((int)DicioType.SUBSTANTIVE, DicioType.SUBSTANTIVE.ToDescriptionString());
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

            groupToSave.Visible = false;
            dataAllVerbs.Columns["Id"].Visible = false;
            dataAllAdjectives.Columns["Id"].Visible = false;
            dataAllSubjects.Columns["Id"].Visible = false;
            dataAllSubstantives.Columns["Id"].Visible = false;

            var assemblyInfo = Assembly.GetExecutingAssembly().GetName();
            version.Text = $"v{assemblyInfo.Version}";
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

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            YioTranslate_MouseMove(sender, e);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            YioTranslate_MouseDown(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Translate(true);

            LoadDataGridViews();
            textFrom.Text = string.Empty;
            textSugg.Text = string.Empty;
            textTo.Text = string.Empty;
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
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            comboType.SelectedIndex = (sender as TabControl).SelectedIndex - 1;

            if (comboType.SelectedIndex < 0)
                groupToSave.Visible = false;
            else
            {
                groupToSave.Visible = true;
                comboType.Text = ((DicioType)comboType.SelectedIndex).ToDescriptionString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/XZpDRnw8wv");
        }

        //private void dataTranslations_Remove(object dataGridView, DataGridViewRowsRemovedEventArgs e)
        //{
        //    try
        //    {
        //        var rowIds = new List<int>();
        //        foreach (DataGridViewCell cell in (dataGridView as DataGridView).SelectedCells)
        //        {
        //            var row = (dataGridView as DataGridView).Rows[cell.RowIndex];
        //            rowIds.Add(Convert.ToInt32(cell.DataGridView[0, cell.RowIndex].Value));
        //        }

        //        foreach (var id in rowIds)
        //        {
        //            var database = new Database();

        //            database.DeleteTranslation(id);
        //        }

        //    }
        //    catch (Exception ex) { }
        //}
    }

    public static class Extension
    {
        public static void AddListToDataTable<T>(this DataGridView dataGridView, IList<T> list)
        {
            var dataTable = new DataTable();

            var columns = new List<DataColumn> {
                new DataColumn("Id"),
                new DataColumn("Português".ToUpper()),
                new DataColumn("Yiokarih".ToUpper())
            }.ToArray();

            try
            {
                dataTable.Columns.AddRange(columns);

                foreach (var item in list)
                {
                    var properties = item.GetType().GetProperties().Select(p => Convert.ToString(p.GetValue(item))).ToList();
                    dataTable.Rows.Add(properties.ToArray());
                }
            }
            catch { }

            dataGridView.DataSource = dataTable;
        }
    }
}
