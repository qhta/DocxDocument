namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CalendarValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues))]
public enum Calendar
{
  /// <summary>
  ///   Gregorian.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Gregorian))]
  Gregorian,
  /// <summary>
  ///   Hijri.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Hijri))]
  Hijri,
  /// <summary>
  ///   umalqura.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Umalqura))]
  Umalqura,
  /// <summary>
  ///   Hebrew.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Hebrew))]
  Hebrew,
  /// <summary>
  ///   Taiwan.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Taiwan))]
  Taiwan,
  /// <summary>
  ///   Japanese Emperor Era.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Japan))]
  Japan,
  /// <summary>
  ///   Thai.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Thai))]
  Thai,
  /// <summary>
  ///   Korean Tangun Era.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Korea))]
  Korea,
  /// <summary>
  ///   Saka Era.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.Saka))]
  Saka,
  /// <summary>
  ///   Gregorian transliterated English.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.GregorianTransliteratedEnglish))]
  GregorianTransliteratedEnglish,
  /// <summary>
  ///   Gregorian transliterated French.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.GregorianTransliteratedFrench))]
  GregorianTransliteratedFrench,
  /// <summary>
  ///   gregorianUs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.GregorianUs))]
  GregorianUs,
  /// <summary>
  ///   gregorianMeFrench.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.GregorianMeFrench))]
  GregorianMeFrench,
  /// <summary>
  ///   gregorianArabic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.GregorianArabic))]
  GregorianArabic,
  /// <summary>
  ///   none.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CalendarValues.None))]
  None
}