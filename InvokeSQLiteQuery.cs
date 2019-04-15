using System.Management.Automation;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace InvokeSQLiteQuery
{
    /// <summary>
    /// <para type="synopsis">Invoke a SQLite query to your SQLite database.</para>
    /// <para type="description"></para>
    /// </summary>
    /// <example>
    ///   <para>Invoke a SQLite query:</para>
    ///   <code>Invoke-SQLiteQuery -Database "$HOME/SampleDB.sqlite" -Query (Get-Content "$HOME/SampleDB.sql" | Out-String)</code>
    ///   <para>Query SQLITE_MASTER table with SELECT statement:</para>
    ///   <code>Invoke-SQLiteQuery -Database $HOME/SQLite.db -Query "SELECT name FROM sqlite_master WHERE type='table';"</code>
    /// </example>
    [Cmdlet(VerbsLifecycle.Invoke, "SQLiteQuery")]
    public class InvokeSQLiteQueryCommand : PSCmdlet
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true
        )]
        [ValidateNotNullOrEmpty]
        public string Database { get; set; } = string.Empty;

        [Parameter(
           Position = 1,
           Mandatory = true,
           ValueFromPipeline = true
        )]
        [ValidateNotNullOrEmpty]
        public string Query { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = this.Database;
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = this.Query;

                var reader = insertCmd.ExecuteReader();
                while (reader.Read())
                {
                    var values = new List<object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        values.Add(reader.GetValue(i));
                    }
                    var output = values.ToArray();
                    WriteObject(output);
                }
            }
            base.ProcessRecord();
        }
    }
}