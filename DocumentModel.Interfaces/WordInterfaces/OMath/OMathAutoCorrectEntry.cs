namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual entry in the OMathAutoCorrectEntries collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry?view=word-pia"/>
public partial interface OMathAutoCorrectEntry : InteropObject
{
  /// <summary>
  /// Returns the index number of the entry in the math AutoCorrect entries collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets the text that is replaced.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns or sets the replacement text for the entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry.value?view=word-pia"/>
  public string Value { get; set; }
}
