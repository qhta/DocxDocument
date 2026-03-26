namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single AutoCorrect entry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry?view=word-pia"/>
public partial interface AutoCorrectEntry : InteropObject
{
  /// <summary>
  /// Gets the index number of the AutoCorrect entry in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets the text to find for this AutoCorrect entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Gets or sets the replacement text for this AutoCorrect entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.value?view=word-pia"/>
  public string Value { get; set; }

  /// <summary>
  /// Gets a value indicating whether the AutoCorrect entry uses rich-text formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentry.richtext?view=word-pia"/>
  public bool RichText { get; }
}
