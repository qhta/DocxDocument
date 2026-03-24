namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a proofing tool type.
/// </summary>
public enum WdDictionaryType
{
  /// <summary>
  /// Spelling.
  /// </summary>
  Spelling = unchecked((int)0),
  /// <summary>
  /// Grammar.
  /// </summary>
  Grammar = unchecked((int)1),
  /// <summary>
  /// Thesaurus.
  /// </summary>
  Thesaurus = unchecked((int)2),
  /// <summary>
  /// Hyphenation.
  /// </summary>
  Hyphenation = unchecked((int)3),
  /// <summary>
  /// Not supported.
  /// </summary>
  SpellingComplete = unchecked((int)4),
  /// <summary>
  /// Custom spelling dictionary.
  /// </summary>
  SpellingCustom = unchecked((int)5),
  /// <summary>
  /// Legal dictionary.
  /// </summary>
  SpellingLegal = unchecked((int)6),
  /// <summary>
  /// Medical dictionary.
  /// </summary>
  SpellingMedical = unchecked((int)7),
  /// <summary>
  /// Dictionary for converting between Hangul and Hanja. Available only if you have enabled support for Korean
  /// through Microsoft Office Language Settings. wdHangulHanjaConversionCustom9 Custom dictionary for converting
  /// between Hangul and [System.Runtime.InteropServices.Guid("6AA9DBAF-EDDB-31DA-88C3-FFF0FBA0FC96")] public enum
  /// WdDictionaryType ﾉ Expand table Hanja.
  /// </summary>
  HangulHanjaConversion = unchecked((int)8),
  /// <summary>
  /// Specifies a proofing tool type.
  /// </summary>
  HangulHanjaConversionCustom = unchecked((int)9)
}
