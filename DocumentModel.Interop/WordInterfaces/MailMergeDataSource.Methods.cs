namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource?view=word-pia"/>
public partial interface MailMergeDataSource
{
  /// <summary>
  /// Finds a record in the data source using Word 2000 compatibility.
  /// </summary>
  /// <param name="FindText">The text to find in the data source.</param>
  /// <param name="Field">The field to search for the text.</param>
  /// <returns>true if the record is found; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.findrecord2000?view=word-pia"/>
  public bool FindRecord2000(string FindText, string Field);
}
