namespace DXW;


/// <summary>
///   Defines the CalendarValues enumeration.
/// </summary>
public enum CalendarValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorian&quot;.
  /// </summary>
  [EnumString("gregorian")]
  Gregorian,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hijri&quot;.
  /// </summary>
  [EnumString("hijri")]
  Hijri,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;umalqura&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("umalqura")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  Umalqura,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hebrew&quot;.
  /// </summary>
  [EnumString("hebrew")]
  Hebrew,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;taiwan&quot;.
  /// </summary>
  [EnumString("taiwan")]
  Taiwan,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;japan&quot;.
  /// </summary>
  [EnumString("japan")]
  Japan,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thai&quot;.
  /// </summary>
  [EnumString("thai")]
  Thai,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;korea&quot;.
  /// </summary>
  [EnumString("korea")]
  Korea,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;saka&quot;.
  /// </summary>
  [EnumString("saka")]
  Saka,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianXlitEnglish&quot;.
  /// </summary>
  [EnumString("gregorianXlitEnglish")]
  GregorianTransliteratedEnglish,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianXlitFrench&quot;.
  /// </summary>
  [EnumString("gregorianXlitFrench")]
  GregorianTransliteratedFrench,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianUs&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("gregorianUs")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  GregorianUs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianMeFrench&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("gregorianMeFrench")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  GregorianMeFrench,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianArabic&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("gregorianArabic")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  GregorianArabic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("none")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  None,
  
}
