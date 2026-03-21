namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single spelling suggestion for a misspelled word.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestion?view=word-pia"/>
public interface SpellingSuggestion : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestion.name?view=word-pia"/>
  public string Name { get; }

}
