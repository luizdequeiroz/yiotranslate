using NHunspell;
using System;
using System.Linq;
using YioTranslate.Models;

namespace YioTranslate.Translate
{
    public class Translator
    {
        public string[] removeNoLetter(string str)
        {
            string vStr = str;
            string nStr = "";
            foreach (var c in str)
                if (((int)c > 47 && (int)c < 58) || ((int)c > 64 && (int)c < 91) || ((int)c > 96 && (int)c < 123) || ((int)c > 127) || c == '\n')
                    nStr += c;
            string removed = vStr.Replace(nStr, "");
            if (string.IsNullOrEmpty(removed))
                removed = "";
            return new string[] { removed, nStr };
        }

        public string LeaYiokariVariation(string txtyiok)
        {
            string variation = " " + txtyiok;

            variation = variation.Replace(" ih ", " ï ").Replace(" ah ", " ä ");
            variation = variation.Replace(" di ", " di").Replace(" dih ", " dï ");
            variation = variation.Replace(" da ", " da").Replace(" dah ", " dä ");
            variation = variation.Replace(" li ", " li").Replace(" lih ", " lï ");
            variation = variation.Replace(" la ", " la").Replace(" lah ", " lä ");

            variation = variation.Replace(" hoc ", " hoc");
            variation = variation.Replace(" hacli", " hacli ");

            variation = variation.Replace(" ilge", " ilge ");
            variation = variation.Replace(" pla", " pla ");

            variation = variation.Replace("hh", "rr").Replace("ll", "ül");
            variation = variation.Replace("tl", "tïl").Replace("dl", "dïl");
            variation = variation.Replace("lh", "ll");
            variation = variation.Replace("hb", "rb").Replace("bb", "x");
            variation = variation.Replace("hg", "rg").Replace("ht", "rt");
            variation = variation.Replace("hp", "rp");

            /* influência do idioma comum */
            variation = variation.Replace("bi ", "be ").Replace("ci ", "ce ");
            variation = variation.Replace("di ", "de ").Replace("fi ", "fe ");
            variation = variation.Replace("gi ", "ge ").Replace("hi ", "he ");
            variation = variation.Replace("ji ", "je ").Replace("ki ", "ke ");
            variation = variation.Replace("li ", "le ").Replace("pi ", "pe ");
            variation = variation.Replace("ri ", "re ").Replace("si ", "se ");
            variation = variation.Replace("vi ", "ve ");

            variation = variation.Substring(1, variation.Length - 1);

            var txtlist = variation.Split(' ');
            for (int i = 0; i < txtlist.Count(); i++)
                if (!string.IsNullOrEmpty(txtlist[i]))
                {
                    if (txtlist[i].Last() == 'h') txtlist[i] = txtlist[i].Replace(txtlist[i].Last().ToString(), "'s");
                    if (txtlist[i].First() == '\'')
                    {
                        var txt = txtlist[i].ToCharArray();
                        txt[0] = ' ';
                        txt[1] = 'h';
                        txtlist[i] = new String(txt).Trim();
                    }
                    if (txtlist[i].Count() == 4)
                    {
                        txtlist[i] += " ";
                        txtlist[i] = txtlist[i].Replace("a ", "ä ").Replace("e ", "ë ").Replace("o ", "ü ");
                    }
                    /* influência do idioma comum */
                    txtlist[i] = txtlist[i].Replace("hoczolda", "zoldahoc");
                }
            variation = String.Join(" ", txtlist).Replace("  ", " ");

            variation = variation.Replace("cie", "cë");
            variation = variation.Replace("ada's", "ära's");
            variation = variation.Replace("qa", "ka").Replace("qe", "que");

            return variation;
        }

        public string YiokalVariation(string txtyiok)
        {
            string variation = " " + txtyiok;

            variation = variation.Replace(" ih ", " i-").Replace(" ah ", " ah-");
            variation = variation.Replace(" di ", " di-").Replace(" dih ", " dih-");
            variation = variation.Replace(" da ", " da-").Replace(" dah ", " dah-");
            variation = variation.Replace(" li ", " li-").Replace(" lih ", " lih-");
            variation = variation.Replace(" la ", " la-").Replace(" lah ", " lah-");

            variation = variation.Replace(" hoc ", " hoke");
            variation = variation.Replace(" hacli", " racli ");

            variation = variation.Replace(" ilge", " ilge ");
            variation = variation.Replace(" pla", " pla ");

            variation = variation.Replace("hh", "hr").Replace("ll", "ll");
            variation = variation.Replace("tl", "tt").Replace("dl", "d");
            variation = variation.Replace("lh", "lh");
            variation = variation.Replace("hb", "b").Replace("bb", "b");
            variation = variation.Replace("hg", "g").Replace("ht", "t");

            variation = variation.Substring(1, variation.Length - 1);

            var txtlist = variation.Split(' ');
            for (int i = 0; i < txtlist.Count(); i++)
                if (!string.IsNullOrEmpty(txtlist[i]))
                {
                    if (txtlist[i].Last() == 'h') txtlist[i] = txtlist[i].Replace(txtlist[i].Last().ToString(), "ys");
                    if (txtlist[i].First() == 'y')
                    {
                        var txt = txtlist[i].ToCharArray();
                        txt[0] = ' ';
                        txt[1] = 'h';
                        txtlist[i] = new String(txt).Trim();
                    }
                    txtlist[i] = txtlist[i].Replace("hoczolda", "zoldahoc");
                }
            variation = String.Join(" ", txtlist).Replace("  ", " ");
            variation = variation.Replace("ys-", "h-").Replace("-ys", "h");

            variation = variation.Replace("cie", "ke");

            return variation;
        }

        public string TranslateYiok(string word, string suggestion = null, DicioType dicioType = DicioType.SUBSTANTIVE, bool IsToSave = false)
        {
            var database = new Database();
            var dicio = database.SelectTranslateByPortuguese(word);
            if (dicio != null)
            {
                string translation;
                if (!string.IsNullOrEmpty(dicio.Sugg))
                {
                    translation = dicio.Sugg;
                    if (IsToSave) database.InsertTranslate(word, dicio.Yiok, translation, dicioType);

                    return translation;
                }

                translation = dicio.Yiok;

                if (IsToSave) database.InsertTranslate(word, translation, suggestion, dicioType);

                return translation;
            }

            using (var hspell = new Hunspell("dicio\\pt_BR.aff", "dicio\\pt_BR.dic"))
            {
                string translation = string.Empty;
                string lports = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜÃÕáéíóúàèìòùâêîôûäëïöüãõç 1234567890-([{?!.:;,$%_+=/\\<>^\"\'}])\t\n";
                string lyioks = "ICBDIQTSEVKRZLAPQLHGOJWXYMicbdiqtsevkrzlapqlhgojwxymIIEAOIIEAOIIEAOIIEAOIAiieaoiieaoiieaoiieaoiab 1234567890-([{?!.:;,$%_+=/\\<>^\"\'}])\t\n";

                foreach (var character in word)
                    for (int i = 0; i < lports.Length; i++)
                        if (character == lports.ToCharArray()[i])
                            translation += lyioks.ToCharArray()[i];

                string _word = word;

                var remocao = removeNoLetter(_word);
                string ch = remocao[0];
                _word = remocao[1];

                if (!hspell.Spell(_word))
                    translation = _word + ch;
                else
                {
                    translation = translation.Replace("x", "sc");

                    if (IsToSave) database.InsertTranslate(word, translation, suggestion, dicioType);
                }

                translation = translation + " ";

                return translation;
            }
        }

        public string TranslateToPortuguese(string word)
        {
            var database = new Database();

            var dicio = database.SelectTranslateByTranslation(word);

            if (dicio != null)
            {
                return dicio.PtBr + " ";
            }
            return word + " ";
        }
    }
}