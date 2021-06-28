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
                    delete from Dicio where ptbr = @ptbr;
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
