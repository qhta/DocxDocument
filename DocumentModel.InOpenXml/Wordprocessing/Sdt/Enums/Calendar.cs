namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CalendarValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.CalendarValues))]
public enum Calendar
{
  /// <summary>
  ///   Gregorian.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Gregorian))]
  Gregorian,
  /// <summary>
  ///   Hijri.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Hijri))]
  Hijri,
  /// <summary>
  ///   umalqura.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Umalqura))]
  Umalqura,
  /// <summary>
  ///   Hebrew.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Hebrew))]
  Hebrew,
  /// <summary>
  ///   Taiwan.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Taiwan))]
  Taiwan,
  /// <summary>
  ///   Japanese Emperor Era.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Japan))]
  Japan,
  /// <summary>
  ///   Thai.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Thai))]
  Thai,
  /// <summary>
  ///   Korean Tangun Era.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Korea))]
  Korea,
  /// <summary>
  ///   Saka Era.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.Saka))]
  Saka,
  /// <summary>
  ///   Gregorian transliterated English.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.GregorianTransliteratedEnglish))]
  GregorianTransliteratedEnglish,
  /// <summary>
  ///   Gregorian transliterated French.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.GregorianTransliteratedFrench))]
  GregorianTransliteratedFrench,
  /// <summary>
  ///   gregorianUs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.GregorianUs))]
  GregorianUs,
  /// <summary>
  ///   gregorianMeFrench.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.GregorianMeFrench))]
  GregorianMeFrench,
  /// <summary>
  ///   gregorianArabic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.GregorianArabic))]
  GregorianArabic,
  /// <summary>
  ///   none.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CalendarValues.None))]
  None
}