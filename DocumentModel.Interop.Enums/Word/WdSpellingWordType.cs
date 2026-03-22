namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way Microsoft Word makes spelling suggestions.
/// </summary>
public enum WdSpellingWordType
{
  /// <summary>
  /// Spellword searching.
  /// </summary>
  wdSpellword = unchecked((int)0),
  /// <summary>
  /// Wildcard searching.
  /// </summary>
  wdWildcard = unchecked((int)1),
  /// <summary>
  /// Anagram searching.
  /// </summary>
  wdAnagram = unchecked((int)2)
}
