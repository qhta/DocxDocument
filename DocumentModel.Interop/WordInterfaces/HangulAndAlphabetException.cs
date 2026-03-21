namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single Hangul or alphabet AutoCorrect exception.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception?view=word-pia"/>
public partial interface HangulAndAlphabetException : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception.name?view=word-pia"/>
  public string Name { get; }
}
