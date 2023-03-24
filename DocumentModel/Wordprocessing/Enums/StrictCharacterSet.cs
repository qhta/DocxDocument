namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StrictCharacterSet enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrictCharacterSet
{
  /// <summary>
  ///   iso-8859-1.
  /// </summary>
  chsAnsi,

  /// <summary>
  ///   macintosh.
  /// </summary>
  chsMacFfn,

  /// <summary>
  ///   shift_jis.
  /// </summary>
  chsShiftJIS,

  /// <summary>
  ///   ks_c-5601-1987.
  /// </summary>
  chsHangeul,

  /// <summary>
  ///   KS_C-5601-1992.
  /// </summary>
  chsJohab,

  /// <summary>
  ///   GBK.
  /// </summary>
  chsGB2312,

  /// <summary>
  ///   Big5.
  /// </summary>
  chsChinese5,

  /// <summary>
  ///   windows-1253.
  /// </summary>
  chsGreek,

  /// <summary>
  ///   iso-8859-9.
  /// </summary>
  chsTurkish,

  /// <summary>
  ///   windows-1258.
  /// </summary>
  chsVietnamese,

  /// <summary>
  ///   windows-1255.
  /// </summary>
  chsHebrew,

  /// <summary>
  ///   windows-1256.
  /// </summary>
  chsArabic,

  /// <summary>
  ///   windows-1257.
  /// </summary>
  chsBaltic,

  /// <summary>
  ///   windows-1251.
  /// </summary>
  chsRussian,

  /// <summary>
  ///   windows-874.
  /// </summary>
  chsThai,

  /// <summary>
  ///   windows-1250.
  /// </summary>
  chsEastEurope
}