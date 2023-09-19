namespace DXW;


/// <summary>
///   Defines the StrictCharacterSet enumeration.
/// </summary>
public enum StrictCharacterSet
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;iso-8859-1&quot;.
  /// </summary>
  [EnumString("iso-8859-1")]
  chsAnsi,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;macintosh&quot;.
  /// </summary>
  [EnumString("macintosh")]
  chsMacFfn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shift_jis&quot;.
  /// </summary>
  [EnumString("shift_jis")]
  chsShiftJIS,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ks_c-5601-1987&quot;.
  /// </summary>
  [EnumString("ks_c-5601-1987")]
  chsHangeul,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;KS_C-5601-1992&quot;.
  /// </summary>
  [EnumString("KS_C-5601-1992")]
  chsJohab,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;GBK&quot;.
  /// </summary>
  [EnumString("GBK")]
  chsGB2312,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;Big5&quot;.
  /// </summary>
  [EnumString("Big5")]
  chsChinese5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-1253&quot;.
  /// </summary>
  [EnumString("windows-1253")]
  chsGreek,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;iso-8859-9&quot;.
  /// </summary>
  [EnumString("iso-8859-9")]
  chsTurkish,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-1258&quot;.
  /// </summary>
  [EnumString("windows-1258")]
  chsVietnamese,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-1255&quot;.
  /// </summary>
  [EnumString("windows-1255")]
  chsHebrew,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-1256&quot;.
  /// </summary>
  [EnumString("windows-1256")]
  chsArabic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-1257&quot;.
  /// </summary>
  [EnumString("windows-1257")]
  chsBaltic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-1251&quot;.
  /// </summary>
  [EnumString("windows-1251")]
  chsRussian,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-874&quot;.
  /// </summary>
  [EnumString("windows-874")]
  chsThai,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;windows-1250&quot;.
  /// </summary>
  [EnumString("windows-1250")]
  chsEastEurope,
  
}
