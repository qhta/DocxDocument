namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoCorrect entry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry?view=word-pia"/>
public partial interface AutoCorrectEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.value?view=word-pia"/>
  public string Value { get; set; }

  /// <summary>
  /// The rich text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.richtext?view=word-pia"/>
  public bool RichText { get; }
}
