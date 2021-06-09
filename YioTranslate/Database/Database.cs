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
                        sugg text null
                    );
                ";

                try
                {
                    command.ExecuteNonQuery();
                }
                catch { }
            }
        }

        public void InsertTranslate(string ptbr, string yiok, string sugg = null)
        {
            using (var connection = new SQLiteConnection("Data Source=yio.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    delete from Dicio where ptbr = @ptbr;
                    insert into Dicio (ptbr, yiok, sugg) 
                    values (@ptbr, @yiok, @sugg);
                ";

                command.Parameters.AddWithValue("@ptbr", ptbr);
                command.Parameters.AddWithValue("@yiok", yiok);
                command.Parameters.AddWithValue("@sugg", sugg);

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
                    select ptbr, yiok, sugg from Dicio where ptbr = @ptbr;
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
                            Sugg = reader["sugg"].ToString()
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
                    select ptbr, yiok, sugg from Dicio where yiok = @yiok or sugg = @sugg;
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
                            Sugg = reader["sugg"].ToString()
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
