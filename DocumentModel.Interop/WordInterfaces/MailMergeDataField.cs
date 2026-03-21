namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single mail merge field in a data source.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield?view=word-pia"/>
public interface MailMergeDataField : InteropObject
{
  /// <summary>
  /// The value.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield.value?view=word-pia"/>
  public string Value { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafield.index?view=word-pia"/>
  public int Index { get; }

}
