using System;
using System.Drawing;
using System.Windows.Forms;
using YioTranslate.Translate;

namespace YioTranslate
{
    public partial class YioTranslate : Form
    {
        public YioTranslate()
        {
            InitializeComponent();
        }

        private void textFrom_TextChanged(object sender, EventArgs e)
        {
            var translator = new Translator();
            if (radioToPrimitive.Checked)
            {

                string translations = string.Empty;
                var words = textFrom.Text.ToLower().Split(' ');
                foreach (var word in words)
                    if (!string.IsNullOrEmpty(word))
                        translations += translator.TranslateYiok(word, textSugg.Text);

                textTo.Text = translations;
                labelRunes.Text = translations;
            }
            else
            {
                string portugueses = string.Empty;
                var words = textFrom.Text.ToLower().Split(' ');
                foreach (var word in words)
                    if (!string.IsNullOrEmpty(word))
                        portugueses += translator.TranslateToPortuguese(word);

                textTo.Text = portugueses;
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

        private void YioTranslate_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            textFrom_TextChanged(sender, e);
            textFrom.Text = string.Empty;
            textSugg.Text = string.Empty;
            textTo.Text = string.Empty;
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            var pp = sender as GroupBox;
            gfx.Clear(pp.BackColor);
            gfx.DrawString(pp.Text, pp.Font, new SolidBrush(pp.ForeColor), new Point(7, 0));
        }
    }
}
