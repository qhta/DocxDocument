namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calendar Type
/// </summary>
public enum CalendarKind
{
  /// <summary>
  /// No Calendar Type.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Gregorian.
  /// </summary>
  [XmlEnum("gregorian")]
  Gregorian,
  
  /// <summary>
  /// Gregorian (U.S.) Calendar.
  /// </summary>
  [XmlEnum("gregorianUs")]
  GregorianUs,
  
  /// <summary>
  /// Japanese Emperor Era Calendar.
  /// </summary>
  [XmlEnum("japan")]
  Japan,
  
  /// <summary>
  /// Taiwan Era Calendar.
  /// </summary>
  [XmlEnum("taiwan")]
  Taiwan,
  
  /// <summary>
  /// Korean Tangun Era Calendar.
  /// </summary>
  [XmlEnum("korea")]
  Korea,
  
  /// <summary>
  /// Hijri (Arabic Lunar) Calendar.
  /// </summary>
  [XmlEnum("hijri")]
  Hijri,
  
  /// <summary>
  /// Thai Calendar.
  /// </summary>
  [XmlEnum("thai")]
  Thai,
  
  /// <summary>
  /// Hebrew (Lunar) Calendar.
  /// </summary>
  [XmlEnum("hebrew")]
  Hebrew,
  
  /// <summary>
  /// Gregorian Middle East French Calendar.
  /// </summary>
  [XmlEnum("gregorianMeFrench")]
  GregorianMiddleEastFrench,
  
  /// <summary>
  /// Gregorian Arabic Calendar.
  /// </summary>
  [XmlEnum("gregorianArabic")]
  GregorianArabic,
  
  /// <summary>
  /// Gregorian Transliterated English Calendar.
  /// </summary>
  [XmlEnum("gregorianXlitEnglish")]
  GregorianTransliteratedEnglish,
  
  /// <summary>
  /// Gregorian Transliterated French Calendar.
  /// </summary>
  [XmlEnum("gregorianXlitFrench")]
  GregorianTransliteratedFrench,
  
}
