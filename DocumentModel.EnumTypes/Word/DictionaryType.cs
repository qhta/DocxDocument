namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a proofing tool type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddictionarytype?view=office-pia` for Office interop details.
/// </remarks>
public enum DictionaryType
{
  /// <summary>
  /// Spelling.
  /// </summary>
  Spelling = 0,
  /// <summary>
  /// Grammar.
  /// </summary>
  Grammar = 1,
  /// <summary>
  /// Thesaurus.
  /// </summary>
  Thesaurus = 2,
  /// <summary>
  /// Hyphenation.
  /// </summary>
  Hyphenation = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  SpellingComplete = 4,
  /// <summary>
  /// Custom spelling dictionary.
  /// </summary>
  SpellingCustom = 5,
  /// <summary>
  /// Legal dictionary.
  /// </summary>
  SpellingLegal = 6,
  /// <summary>
  /// Medical dictionary.
  /// </summary>
  SpellingMedical = 7,
  /// <summary>
  /// Dictionary for converting between Hangul and Hanja. Available only if you have enabled support for Korean
  /// through Microsoft Office Language Settings.
  /// </summary>
  HangulHanjaConversion = 8,
  /// <summary>
  /// Custom dictionary for converting between Hangul and
  /// </summary>
  HangulHanjaConversionCustom = 9
}
