namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way Microsoft Word makes spelling suggestions.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspellingwordtype?view=office-pia` for Office interop details.
/// </remarks>
public enum SpellingWordType
{
  /// <summary>
  /// Spellword searching.
  /// </summary>
  Spellword = 0,
  /// <summary>
  /// Wildcard searching.
  /// </summary>
  Wildcard = 1,
  /// <summary>
  /// Anagram searching.
  /// </summary>
  Anagram = 2
}
