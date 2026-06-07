namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way Microsoft Word makes spelling suggestions.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspellingwordtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSpellingWordType")]
public enum SpellingWordType
{
  /// <summary>
  /// Spellword searching.
  /// </summary>
  [InteropEnumValue("wdSpellword")]
  Spellword = 0,
  /// <summary>
  /// Wildcard searching.
  /// </summary>
  [InteropEnumValue("wdWildcard")]
  Wildcard = 1,
  /// <summary>
  /// Anagram searching.
  /// </summary>
  [InteropEnumValue("wdAnagram")]
  Anagram = 2
}
