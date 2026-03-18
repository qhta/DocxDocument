namespace DocumentModel.Interop;

/// <summary>
/// A collection of SpellingSuggestion objects that represent all the suggestions for a specified word or for the first word in the specified range.
/// </summary>
public interface SpellingSuggestions : InteropObject, InteropCollection<SpellingSuggestion>
{
  /// <summary>
  /// The spelling error type.
  /// </summary>
  public WdSpellingErrorType SpellingErrorType { get; }
}
