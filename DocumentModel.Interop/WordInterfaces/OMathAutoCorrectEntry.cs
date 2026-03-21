namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual entry in the OMathAutoCorrectEntries collection.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry?view=word-pia"/>
public partial interface OMathAutoCorrectEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The value.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry.value?view=word-pia"/>
  public string Value { get; set; }
}
