namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single Hangul-and-alphabet AutoCorrect exception.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception?view=word-pia"/>
public partial interface HangulAndAlphabetException : IModelObject
{
  /// <summary>
  /// Returns the position of this item in its collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns the name of the Hangul-and-alphabet AutoCorrect exception.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception.name?view=word-pia"/>
  public string Name { get; }
}
