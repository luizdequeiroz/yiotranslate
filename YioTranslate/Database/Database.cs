using System;
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
            InsertTranslate("arma", "ilzi", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("ferramenta", "qilze", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("roupa", "laopi", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("pedra", "pide", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("minério", "zelilea", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("madeira", "zidele", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("galho", "tirsa", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("galho", "zidele dirina", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("árvore", "amira", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("presente", "pihil", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("lua", "aul", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("lua-cheia", "aul marama", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("lua-cheia", "marama", type: DicioType.SUBSTANTIVE, deleteIfExists: true);

            InsertTranslate("comida", "qaze", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("carne", "qaze", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("água", "hidi", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("fogo", "biral", type: DicioType.SUBSTANTIVE, deleteIfExists: true);
            InsertTranslate("sangue", "qileda", type: DicioType.SUBSTANTIVE, deleteIfExists: true);

            InsertTranslate("líder", "pappa iwi", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("chefe", "pappa iwi", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("rainha", "kuini", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("princesa", "piriniha", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("cacique", "rangatira", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("sacerdote", "rangatira", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("caçador", "ranga", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("capitão", "kapene", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("soldado", "hoia", type: DicioType.SUBJECT, deleteIfExists: true);

            InsertTranslate("animal", "ilezir", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("pessoa", "pihhai", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("monstro", "zalga", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("espírito", "Pelega", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("deus", "dioh", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("divindade", "dielde", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("ancestral", "pihhida", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("lobo", "raca", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("urso", "olha", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("rinoceronte", "bseq", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("mascarado", "zibilida", type: DicioType.SUBJECT, deleteIfExists: true);
            InsertTranslate("burro", "burr", type: DicioType.SUBJECT, deleteIfExists: true);

            InsertTranslate("fome", "qaze", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("sede", "hidi", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("calor", "biral", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("frio", "qelea", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("morrendo", "qelea", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("ferido", "qileda", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("venenoso", "jilaha", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("envenenado", "jilaha", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("pequeno", "dirina", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("grande", "fala", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("amigo", "izeta", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("inimigo", "elezeta", type: DicioType.ADJECTIVE, deleteIfExists: true);

            InsertTranslate("preso", "piliha", type: DicioType.ADJECTIVE, deleteIfExists: true);
            InsertTranslate("solto", "harga", type: DicioType.ADJECTIVE, deleteIfExists: true);

            InsertTranslate("ir", "jizah", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("vamos", "jizah", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("fugir", "qoviz", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("atacar", "gibiu", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("correr", "baliu", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("partir", "baliu", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("matar", "zigiu", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("comer", "bazil", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("dançar-pra-batalha", "haka", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("dançar-pra-gradecer", "heah", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("prender", "piliha", type: DicioType.VERB, deleteIfExists: true);
            InsertTranslate("soltar", "harga", type: DicioType.VERB, deleteIfExists: true);
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

        public void InsertTranslate(string ptbr, string yiok, string sugg = null, DicioType type = DicioType.SUBSTANTIVE, bool deleteIfExists = false)
        {
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $@"
                    {(deleteIfExists ? "delete from Dicio where ptbr = @ptbr and yiok = @yiok;" : "")}
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
