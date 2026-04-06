namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single mail merge field in a data source.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield?view=word-pia"/>
public interface IMailMergeDataField : IModelObject
{
  /// <summary>
  /// Returns the value of the mail merge data field in the current record.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield.value?view=word-pia"/>
  public string Value { get; }
  /// <summary>
  /// Returns the name of the mail merge data field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the index number of the mail merge data field in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield.index?view=word-pia"/>
  public int Index { get; }

}
