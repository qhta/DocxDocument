namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CalendarValues enumeration.
/// </summary>
public enum CalendarValues
{
  /// <summary>
  /// Gregorian.
  /// </summary>
  [XmlEnum("gregorian")]
  Gregorian,
  
  /// <summary>
  /// Hijri.
  /// </summary>
  [XmlEnum("hijri")]
  Hijri,
  
  /// <summary>
  /// umalqura.
  /// </summary>
  [XmlEnum("umalqura")]
  Umalqura,
  
  /// <summary>
  /// Hebrew.
  /// </summary>
  [XmlEnum("hebrew")]
  Hebrew,
  
  /// <summary>
  /// Taiwan.
  /// </summary>
  [XmlEnum("taiwan")]
  Taiwan,
  
  /// <summary>
  /// Japanese Emperor Era.
  /// </summary>
  [XmlEnum("japan")]
  Japan,
  
  /// <summary>
  /// Thai.
  /// </summary>
  [XmlEnum("thai")]
  Thai,
  
  /// <summary>
  /// Korean Tangun Era.
  /// </summary>
  [XmlEnum("korea")]
  Korea,
  
  /// <summary>
  /// Saka Era.
  /// </summary>
  [XmlEnum("saka")]
  Saka,
  
  /// <summary>
  /// Gregorian transliterated English.
  /// </summary>
  [XmlEnum("gregorianXlitEnglish")]
  GregorianTransliteratedEnglish,
  
  /// <summary>
  /// Gregorian transliterated French.
  /// </summary>
  [XmlEnum("gregorianXlitFrench")]
  GregorianTransliteratedFrench,
  
  /// <summary>
  /// gregorianUs.
  /// </summary>
  [XmlEnum("gregorianUs")]
  GregorianUs,
  
  /// <summary>
  /// gregorianMeFrench.
  /// </summary>
  [XmlEnum("gregorianMeFrench")]
  GregorianMeFrench,
  
  /// <summary>
  /// gregorianArabic.
  /// </summary>
  [XmlEnum("gregorianArabic")]
  GregorianArabic,
  
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
