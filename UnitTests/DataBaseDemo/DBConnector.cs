using System.Data;
using System.Data.SQLite;
using Dapper;
using Xunit;

namespace UnitTests.DataBaseDemo
{
    public class DBConnector
    {
        const string CONNECTION_STR = "Data Source=./DataBaseDemo/DemoDB.db;Version=3";

        public static IDbConnection DbConnection
        {
            get => new SQLiteConnection(CONNECTION_STR);
        }

        [Fact]
        public void testConnectToDemoDB()
        {
            using (IDbConnection connection = DbConnection)
            {
                var output = connection.Query<object>($"select * from TestTable", new DynamicParameters());
            }
        }
    }
}
