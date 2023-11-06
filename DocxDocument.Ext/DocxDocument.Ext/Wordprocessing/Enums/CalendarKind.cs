namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CalendarValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum CalendarKind
{
  /// <summary>
  ///   Gregorian.
  /// </summary>
  Gregorian,

  /// <summary>
  ///   Hijri.
  /// </summary>
  Hijri,

  /// <summary>
  ///   umalqura.
  /// </summary>
  Umalqura,

  /// <summary>
  ///   Hebrew.
  /// </summary>
  Hebrew,

  /// <summary>
  ///   Taiwan.
  /// </summary>
  Taiwan,

  /// <summary>
  ///   Japanese Emperor Era.
  /// </summary>
  Japan,

  /// <summary>
  ///   Thai.
  /// </summary>
  Thai,

  /// <summary>
  ///   Korean Tangun Era.
  /// </summary>
  Korea,

  /// <summary>
  ///   Saka Era.
  /// </summary>
  Saka,

  /// <summary>
  ///   Gregorian transliterated English.
  /// </summary>
  GregorianTransliteratedEnglish,

  /// <summary>
  ///   Gregorian transliterated French.
  /// </summary>
  GregorianTransliteratedFrench,

  /// <summary>
  ///   gregorianUs.
  /// </summary>
  GregorianUs,

  /// <summary>
  ///   gregorianMeFrench.
  /// </summary>
  GregorianMeFrench,

  /// <summary>
  ///   gregorianArabic.
  /// </summary>
  GregorianArabic,

  /// <summary>
  ///   none.
  /// </summary>
  None
}