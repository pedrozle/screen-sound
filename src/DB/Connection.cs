using Microsoft.Data.SqlClient;

namespace ScreenSound.DB;

internal class Connection
{
    private readonly string connectionString = "Server=localhost,1433;Database=ScreenSound;User Id=sa;Password=S3nh@Segura;TrustServerCertificate=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

}