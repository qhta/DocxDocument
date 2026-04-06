namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a mail merge field name in a data source.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname?view=word-pia"/>
public interface IMailMergeFieldName : IModelObject
{
  /// <summary>
  /// Returns the name of the mail merge field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the index number of the field in the mail merge field names collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname.index?view=word-pia"/>
  public int Index { get; }

}
