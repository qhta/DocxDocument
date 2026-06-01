namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single spelling suggestion for a misspelled word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestion?view=word-pia"/>
public class SpellingSuggestion : InteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestion.name?view=word-pia"/>
  public string Name { get; }

}
