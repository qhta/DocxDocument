namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of SpellingSuggestion objects that represent all the suggestions for a specified word or for the first word in the specified range.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestions?view=word-pia"/>
public interface SpellingSuggestions : InteropObject, InteropCollection<SpellingSuggestion>
{
  /// <summary>
  /// The spelling error type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestions.spellingerrortype?view=word-pia"/>
  public WdSpellingErrorType SpellingErrorType { get; }
}
