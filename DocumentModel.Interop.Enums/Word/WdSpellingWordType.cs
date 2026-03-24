namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way Microsoft Word makes spelling suggestions.
/// </summary>
public enum WdSpellingWordType
{
  /// <summary>
  /// Spellword searching.
  /// </summary>
  Spellword = unchecked((int)0),
  /// <summary>
  /// Wildcard searching.
  /// </summary>
  Wildcard = unchecked((int)1),
  /// <summary>
  /// Anagram searching.
  /// </summary>
  Anagram = unchecked((int)2)
}
