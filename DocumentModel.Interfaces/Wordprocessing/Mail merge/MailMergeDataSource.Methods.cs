namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource?view=word-pia"/>
public partial interface IMailMergeDataSource: IModelObject
{
  /// <summary>
  /// Finds a record in the mail merge data source using Word 2000-compatible behavior.
  /// </summary>
  /// <param name="FindText">Specifies the text to find.</param>
  /// <param name="Field">Specifies the field to search.</param>
  /// <returns>true if the record is found; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.findrecord2000?view=word-pia"/>
  public bool FindRecord2000(string FindText, string Field);
}
