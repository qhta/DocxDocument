namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StrictCharacterSet enumeration.
/// </summary>
public enum StrictCharacterSet
{
  /// <summary>
  /// iso-8859-1.
  /// </summary>
  [XmlEnum("iso-8859-1")]
  chsAnsi,
  
  /// <summary>
  /// macintosh.
  /// </summary>
  [XmlEnum("macintosh")]
  chsMacFfn,
  
  /// <summary>
  /// shift_jis.
  /// </summary>
  [XmlEnum("shift_jis")]
  chsShiftJIS,
  
  /// <summary>
  /// ks_c-5601-1987.
  /// </summary>
  [XmlEnum("ks_c-5601-1987")]
  chsHangeul,
  
  /// <summary>
  /// KS_C-5601-1992.
  /// </summary>
  [XmlEnum("KS_C-5601-1992")]
  chsJohab,
  
  /// <summary>
  /// GBK.
  /// </summary>
  [XmlEnum("GBK")]
  chsGB2312,
  
  /// <summary>
  /// Big5.
  /// </summary>
  [XmlEnum("Big5")]
  chsChinese5,
  
  /// <summary>
  /// windows-1253.
  /// </summary>
  [XmlEnum("windows-1253")]
  chsGreek,
  
  /// <summary>
  /// iso-8859-9.
  /// </summary>
  [XmlEnum("iso-8859-9")]
  chsTurkish,
  
  /// <summary>
  /// windows-1258.
  /// </summary>
  [XmlEnum("windows-1258")]
  chsVietnamese,
  
  /// <summary>
  /// windows-1255.
  /// </summary>
  [XmlEnum("windows-1255")]
  chsHebrew,
  
  /// <summary>
  /// windows-1256.
  /// </summary>
  [XmlEnum("windows-1256")]
  chsArabic,
  
  /// <summary>
  /// windows-1257.
  /// </summary>
  [XmlEnum("windows-1257")]
  chsBaltic,
  
  /// <summary>
  /// windows-1251.
  /// </summary>
  [XmlEnum("windows-1251")]
  chsRussian,
  
  /// <summary>
  /// windows-874.
  /// </summary>
  [XmlEnum("windows-874")]
  chsThai,
  
  /// <summary>
  /// windows-1250.
  /// </summary>
  [XmlEnum("windows-1250")]
  chsEastEurope,
  
}
