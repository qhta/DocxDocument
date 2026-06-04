namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a proofing tool type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddictionarytype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDictionaryType")]
public enum DictionaryType
{
  /// <summary>
  /// Spelling.
  /// </summary>
  [WordInteropEnumValue("wdSpelling")]
  Spelling = 0,
  /// <summary>
  /// Grammar.
  /// </summary>
  [WordInteropEnumValue("wdGrammar")]
  Grammar = 1,
  /// <summary>
  /// Thesaurus.
  /// </summary>
  [WordInteropEnumValue("wdThesaurus")]
  Thesaurus = 2,
  /// <summary>
  /// Hyphenation.
  /// </summary>
  [WordInteropEnumValue("wdHyphenation")]
  Hyphenation = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdSpellingComplete")]
  SpellingComplete = 4,
  /// <summary>
  /// Custom spelling dictionary.
  /// </summary>
  [WordInteropEnumValue("wdSpellingCustom")]
  SpellingCustom = 5,
  /// <summary>
  /// Legal dictionary.
  /// </summary>
  [WordInteropEnumValue("wdSpellingLegal")]
  SpellingLegal = 6,
  /// <summary>
  /// Medical dictionary.
  /// </summary>
  [WordInteropEnumValue("wdSpellingMedical")]
  SpellingMedical = 7,
  /// <summary>
  /// Dictionary for converting between Hangul and Hanja. Available only if you have enabled support for Korean
  /// through Microsoft Office Language Settings.
  /// </summary>
  [WordInteropEnumValue("wdHangulHanjaConversion")]
  HangulHanjaConversion = 8,
  /// <summary>
  /// Custom dictionary for converting between Hangul and
  /// </summary>
  [WordInteropEnumValue("wdHangulHanjaConversionCustom")]
  HangulHanjaConversionCustom = 9
}
