namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mail merge field name in a data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname?view=word-pia"/>
public class MailMergeFieldName : InteropObject
{
  /// <summary>
  /// Returns the name of the mail merge field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the index number of the field in the mail merge field names collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname.index?view=word-pia"/>
  public int Index { get; }

}
