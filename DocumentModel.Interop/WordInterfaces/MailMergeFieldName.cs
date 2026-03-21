namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mail merge field name in a data source.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname?view=word-pia"/>
public interface MailMergeFieldName : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldname.index?view=word-pia"/>
  public int Index { get; }

}
