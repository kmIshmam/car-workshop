using System.Data.SqlClient;

public static class DBconnect
{
    public static string loggedinusername;
    public static string loggedinuserrole;

    private static readonly string ConnectionString =
        @"Data Source=ZENX\SQLEXPRESS;
          Initial Catalog=cwmsystem;
          Integrated Security=True;
          Persist Security Info=False;
          Pooling=False;
          MultipleActiveResultSets=False;
          Encrypt=True;
          TrustServerCertificate=True;
          Application Name=""SQL Server Management Studio""";

    public static SqlConnection Connect()
    {
        return new SqlConnection(ConnectionString);
    }
}