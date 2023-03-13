namespace AccountManagement;

public static class AccountManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "AccountManagement";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AccountManagement";
}
