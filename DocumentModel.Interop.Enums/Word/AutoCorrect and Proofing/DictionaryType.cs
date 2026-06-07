namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a proofing tool type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddictionarytype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDictionaryType")]
public enum DictionaryType
{
  /// <summary>
  /// Spelling.
  /// </summary>
  [InteropEnumValue("wdSpelling")]
  Spelling = 0,
  /// <summary>
  /// Grammar.
  /// </summary>
  [InteropEnumValue("wdGrammar")]
  Grammar = 1,
  /// <summary>
  /// Thesaurus.
  /// </summary>
  [InteropEnumValue("wdThesaurus")]
  Thesaurus = 2,
  /// <summary>
  /// Hyphenation.
  /// </summary>
  [InteropEnumValue("wdHyphenation")]
  Hyphenation = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdSpellingComplete")]
  SpellingComplete = 4,
  /// <summary>
  /// Custom spelling dictionary.
  /// </summary>
  [InteropEnumValue("wdSpellingCustom")]
  SpellingCustom = 5,
  /// <summary>
  /// Legal dictionary.
  /// </summary>
  [InteropEnumValue("wdSpellingLegal")]
  SpellingLegal = 6,
  /// <summary>
  /// Medical dictionary.
  /// </summary>
  [InteropEnumValue("wdSpellingMedical")]
  SpellingMedical = 7,
  /// <summary>
  /// Dictionary for converting between Hangul and Hanja. Available only if you have enabled support for Korean
  /// through Microsoft Office Language Settings.
  /// </summary>
  [InteropEnumValue("wdHangulHanjaConversion")]
  HangulHanjaConversion = 8,
  /// <summary>
  /// Custom dictionary for converting between Hangul and
  /// </summary>
  [InteropEnumValue("wdHangulHanjaConversionCustom")]
  HangulHanjaConversionCustom = 9
}
