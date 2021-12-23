﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using YioTranslate.Models;

namespace YioTranslate
{
    public class Database
    {
        public void Init()
        {
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    create table Dicio (
                        id integer primary key AUTOINCREMENT,
                        ptbr text not null,
                        yiok text not null,
                        sugg text null,
                        type integer not null
                    );
                ";

                try
                {
                    command.ExecuteNonQuery();
                }
                catch { }
            }

            PopuleInitialData();
        }

        private void PopuleInitialData()
        {
            InsertTranslate("arma", "ilzi", type: DicioType.SUBSTANTIVE);
            InsertTranslate("ferramenta", "qilze", type: DicioType.SUBSTANTIVE);
            InsertTranslate("roupa", "laopi", type: DicioType.SUBSTANTIVE);
            InsertTranslate("pedra", "pide", type: DicioType.SUBSTANTIVE);
            InsertTranslate("minério", "zelilea", type: DicioType.SUBSTANTIVE);
            InsertTranslate("madeira", "zidele", type: DicioType.SUBSTANTIVE);
            InsertTranslate("galho", "tirsa", type: DicioType.SUBSTANTIVE);
            InsertTranslate("galho", "zidele dirina", type: DicioType.SUBSTANTIVE);
            InsertTranslate("árvore", "amira", type: DicioType.SUBSTANTIVE);
            InsertTranslate("presente", "pihil", type: DicioType.SUBSTANTIVE);
            InsertTranslate("lua", "aul", type: DicioType.SUBSTANTIVE);
            InsertTranslate("lua-cheia", "aul marama", type: DicioType.SUBSTANTIVE);
            InsertTranslate("lua-cheia", "marama", type: DicioType.SUBSTANTIVE);

            InsertTranslate("comida", "qaze", type: DicioType.SUBSTANTIVE);
            InsertTranslate("carne", "qaze", type: DicioType.SUBSTANTIVE);
            InsertTranslate("água", "hidi", type: DicioType.SUBSTANTIVE);
            InsertTranslate("fogo", "biral", type: DicioType.SUBSTANTIVE);
            InsertTranslate("sangue", "qileda", type: DicioType.SUBSTANTIVE);

            InsertTranslate("líder", "pappa iwi", type: DicioType.SUBJECT);
            InsertTranslate("chefe", "pappa iwi", type: DicioType.SUBJECT);
            InsertTranslate("rainha", "kuini", type: DicioType.SUBJECT);
            InsertTranslate("princesa", "piriniha", type: DicioType.SUBJECT);
            InsertTranslate("cacique", "rangatira", type: DicioType.SUBJECT);
            InsertTranslate("sacerdote", "rangatira", type: DicioType.SUBJECT);
            InsertTranslate("caçador", "ranga", type: DicioType.SUBJECT);
            InsertTranslate("capitão", "kapene", type: DicioType.SUBJECT);
            InsertTranslate("soldado", "hoia", type: DicioType.SUBJECT);

            InsertTranslate("animal", "ilezir", type: DicioType.SUBJECT);
            InsertTranslate("pessoa", "pihhai", type: DicioType.SUBJECT);
            InsertTranslate("monstro", "zalga", type: DicioType.SUBJECT);
            InsertTranslate("espírito", "Pelega", type: DicioType.SUBJECT);
            InsertTranslate("deus", "dioh", type: DicioType.SUBJECT);
            InsertTranslate("divindade", "dielde", type: DicioType.SUBJECT);
            InsertTranslate("ancestral", "pihhida", type: DicioType.SUBJECT);
            InsertTranslate("lobo", "raca", type: DicioType.SUBJECT);
            InsertTranslate("urso", "olha", type: DicioType.SUBJECT);
            InsertTranslate("rinoceronte", "bseq", type: DicioType.SUBJECT);
            InsertTranslate("mascarado", "zibilida", type: DicioType.SUBJECT);
            InsertTranslate("burro", "burr", type: DicioType.SUBJECT);

            InsertTranslate("fome", "qaze", type: DicioType.ADJECTIVE);
            InsertTranslate("sede", "hidi", type: DicioType.ADJECTIVE);
            InsertTranslate("calor", "biral", type: DicioType.ADJECTIVE);
            InsertTranslate("frio", "qelea", type: DicioType.ADJECTIVE);
            InsertTranslate("morrendo", "qelea", type: DicioType.ADJECTIVE);
            InsertTranslate("ferido", "qileda", type: DicioType.ADJECTIVE);
            InsertTranslate("venenoso", "jilaha", type: DicioType.ADJECTIVE);
            InsertTranslate("envenenado", "jilaha", type: DicioType.ADJECTIVE);
            InsertTranslate("pequeno", "dirina", type: DicioType.ADJECTIVE);
            InsertTranslate("grande", "fala", type: DicioType.ADJECTIVE);
            InsertTranslate("amigo", "izeta", type: DicioType.ADJECTIVE);
            InsertTranslate("inimigo", "elezeta", type: DicioType.ADJECTIVE);

            InsertTranslate("preso", "piliha", type: DicioType.ADJECTIVE);
            InsertTranslate("solto", "harga", type: DicioType.ADJECTIVE);

            InsertTranslate("ir", "jizah", type: DicioType.VERB);
            InsertTranslate("vamos", "jizah", type: DicioType.VERB);
            InsertTranslate("fugir", "qoviz", type: DicioType.VERB);
            InsertTranslate("atacar", "gibiu", type: DicioType.VERB);
            InsertTranslate("correr", "baliu", type: DicioType.VERB);
            InsertTranslate("partir", "baliu", type: DicioType.VERB);
            InsertTranslate("matar", "zigiu", type: DicioType.VERB);
            InsertTranslate("comer", "bazil", type: DicioType.VERB);
            InsertTranslate("dançar-pra-batalha", "haka", type: DicioType.VERB);
            InsertTranslate("dançar-pra-gradecer", "heah", type: DicioType.VERB);
            InsertTranslate("prender", "piliha", type: DicioType.VERB);
            InsertTranslate("soltar", "harga", type: DicioType.VERB);
        }

        public IList<Dicio> SelectAll()
        {
            var dicios = new List<Dicio>();
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    select id, ptbr, yiok, sugg, type from Dicio;
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dicios.Add(new Dicio
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            PtBr =
#if DEBUG
                                "*********",
#else
                                reader["ptbr"].ToString(),
#endif
                            Yiok = reader["yiok"].ToString().ToUpper(),
                            Sugg = reader["sugg"].ToString().ToUpper(),
                            Type = (DicioType)Convert.ToInt32(reader["type"])
                        });
                    }
                }

                return dicios;
            }
        }

        public void InsertTranslate(string ptbr, string yiok, string sugg = null, DicioType type = DicioType.SUBSTANTIVE)
        {
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    -- delete from Dicio where ptbr = @ptbr;
                    insert into Dicio (ptbr, yiok, sugg, type) 
                    values (@ptbr, @yiok, @sugg, @type);
                ";

                command.Parameters.AddWithValue("@ptbr", ptbr);
                command.Parameters.AddWithValue("@yiok", yiok);
                command.Parameters.AddWithValue("@sugg", sugg);
                command.Parameters.AddWithValue("@type", (int)type);

                command.ExecuteNonQuery();
            }
        }

        public Dicio SelectTranslateByPortuguese(string word)
        {
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    select ptbr, yiok, sugg, type from Dicio where ptbr = @ptbr;
                ";

                command.Parameters.AddWithValue("@ptbr", word);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Dicio
                        {
                            PtBr = reader["ptbr"].ToString(),
                            Yiok = reader["yiok"].ToString(),
                            Sugg = reader["sugg"].ToString(),
                            Type = (DicioType)Convert.ToInt32(reader["type"])
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public Dicio SelectTranslateByTranslation(string yiokOrSugg)
        {
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    select ptbr, yiok, sugg, type from Dicio where yiok = @yiok or sugg = @sugg;
                ";

                command.Parameters.AddWithValue("@yiok", yiokOrSugg);
                command.Parameters.AddWithValue("@sugg", yiokOrSugg);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Dicio
                        {
                            PtBr = reader["ptbr"].ToString(),
                            Yiok = reader["yiok"].ToString(),
                            Sugg = reader["sugg"].ToString(),
                            Type = (DicioType)Convert.ToInt32(reader["type"])
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void DeleteTranslation(int id)
        {
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    delete from Dicio where id = @id;
                ";

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
