namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CalendarValues enumeration.
/// </summary>
public enum CalendarKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorian&quot;.
  /// </summary>
  Gregorian,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hijri&quot;.
  /// </summary>
  Hijri,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;umalqura&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  Umalqura,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hebrew&quot;.
  /// </summary>
  Hebrew,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;taiwan&quot;.
  /// </summary>
  Taiwan,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;japan&quot;.
  /// </summary>
  Japan,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thai&quot;.
  /// </summary>
  Thai,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;korea&quot;.
  /// </summary>
  Korea,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;saka&quot;.
  /// </summary>
  Saka,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianXlitEnglish&quot;.
  /// </summary>
  GregorianTransliteratedEnglish,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianXlitFrench&quot;.
  /// </summary>
  GregorianTransliteratedFrench,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianUs&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  GregorianUs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianMeFrench&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  GregorianMeFrench,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gregorianArabic&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  GregorianArabic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  None,
  
}
