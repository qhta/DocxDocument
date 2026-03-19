namespace DocumentModel.Interop.Word;

public partial interface MailMerge
{
  /// <summary>
  /// Creates a new data source for the mail merge operation.
  /// </summary>
  /// <param name="Name">The name of the data source file.</param>
  /// <param name="PasswordDocument">The password for the data source document.</param>
  /// <param name="WritePasswordDocument">The write password for the data source document.</param>
  /// <param name="HeaderRecord">The header record for the data source.</param>
  /// <param name="MSQuery">The Microsoft Query information.</param>
  /// <param name="SQLStatement">The primary SQL statement for the data source.</param>
  /// <param name="SQLStatement1">The secondary SQL statement for the data source.</param>
  /// <param name="Connection">The connection string for the data source.</param>
  /// <param name="LinkToSource">true to link to the source; otherwise, false.</param>
  public void CreateDataSource(string Name, string PasswordDocument, string WritePasswordDocument, string HeaderRecord, 
    string MSQuery, string SQLStatement, string SQLStatement1, string Connection, bool LinkToSource);
}
