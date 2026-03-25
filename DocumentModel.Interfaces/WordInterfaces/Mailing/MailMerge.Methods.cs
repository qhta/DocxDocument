namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge?view=word-pia"/>
public partial interface MailMerge: InteropObject
{
  /// <summary>
  /// Creates a new mail merge data source.
  /// </summary>
  /// <param name="Name">Specifies the data source file name.</param>
  /// <param name="PasswordDocument">Specifies the password to open the document.</param>
  /// <param name="WritePasswordDocument">Specifies the password to save changes.</param>
  /// <param name="HeaderRecord">Specifies the header record text.</param>
  /// <param name="MSQuery">Specifies Microsoft Query data.</param>
  /// <param name="SQLStatement">Specifies the first SQL statement.</param>
  /// <param name="SQLStatement1">Specifies the second SQL statement.</param>
  /// <param name="Connection">Specifies the data connection string.</param>
  /// <param name="LinkToSource">Specifies whether the main document links to the data source.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.createdatasource?view=word-pia"/>
  public void CreateDataSource(string Name, string PasswordDocument, string WritePasswordDocument, string HeaderRecord, 
    string MSQuery, string SQLStatement, string SQLStatement1, string Connection, bool LinkToSource);
}
