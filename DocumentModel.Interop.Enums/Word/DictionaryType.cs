namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a proofing tool type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddictionarytype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDictionaryType))]
public enum DictionaryType
{
  /// <summary>
  /// Spelling.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdSpelling))]
  Spelling = 0,
  /// <summary>
  /// Grammar.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdGrammar))]
  Grammar = 1,
  /// <summary>
  /// Thesaurus.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdThesaurus))]
  Thesaurus = 2,
  /// <summary>
  /// Hyphenation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdHyphenation))]
  Hyphenation = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdSpellingComplete))]
  SpellingComplete = 4,
  /// <summary>
  /// Custom spelling dictionary.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdSpellingCustom))]
  SpellingCustom = 5,
  /// <summary>
  /// Legal dictionary.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdSpellingLegal))]
  SpellingLegal = 6,
  /// <summary>
  /// Medical dictionary.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdSpellingMedical))]
  SpellingMedical = 7,
  /// <summary>
  /// Dictionary for converting between Hangul and Hanja. Available only if you have enabled support for Korean
  /// through Microsoft Office Language Settings.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdHangulHanjaConversion))]
  HangulHanjaConversion = 8,
  /// <summary>
  /// Custom dictionary for converting between Hangul and
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDictionaryType.wdHangulHanjaConversionCustom))]
  HangulHanjaConversionCustom = 9
}
