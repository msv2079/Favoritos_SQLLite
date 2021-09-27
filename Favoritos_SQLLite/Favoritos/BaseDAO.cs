using System.Data;
using System.Data.SQLite;

namespace Favoritos
{
    public class BaseDAO
    {
        private static readonly string connectionString = "Data Source=Favoritos.db;Version=3;";

        protected DataTable ExecuteDataTable(SQLiteCommand command)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                command.Connection = connection;

                var da = new SQLiteDataAdapter(command);
                var dt = new DataTable();
                da.Fill(dt);

                connection.Close();

                return dt;
            }
        }

        protected void ExecuteNonQuery(SQLiteCommand command)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                command.Connection = connection;
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
