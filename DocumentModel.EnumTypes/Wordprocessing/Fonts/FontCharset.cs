namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specific Windows character set codes using in font table.
/// </summary>
public static class FontCharset
{

  /// <summary>
  /// ANSI character set (IANA name iso-8859-1).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsAnsi))]
  public static byte Ansi = 0x00;
  /// <summary>
  /// Default character set.
  /// </summary>
  [NotMapped]
  public static byte Default = 0x01;   
  /// <summary>
  /// Symbol character set, 
  /// This value specifies that the characters in the Unicode private use area
  /// (U+FF00 to U+FFFF) of the font should be used to display characters 
  /// in the range U+0000 to U+00FF.
  /// </summary>
  [NotMapped]
  public static byte Symbol = 0x02;
  /// <summary>
  /// Macintosh (Standard Roman) character set (IANA name macintosh).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsMacFfn))]
  public static byte MacFfn = 0x4D;
  /// <summary>
  /// Specifies the JIS character set (IANA name shift_jis).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsShiftJIS))]
  public static byte ShiftJIS = 0x80;
  /// <summary>
  /// Specifies the Hangul character set (IANA name ks_c_5601-1987).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsHangeul))]
  public static byte Hangul = 0x81;
  /// <summary>
  /// Specifies the Johab character set (IANA name ks_c_5691-1992).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsJohab))]
  public static byte Johab = 0x82;
  /// <summary>
  /// Specifies the GB-2312 character set (IANA name GBK).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsGB2312))]
  public static byte GB2312 = 0x86;
  /// <summary>
  /// Specifies the Chinese Big Five character set (IANA name Big5).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsChinese5))]
  public static byte Chinese5 = 0x88;
  /// <summary>
  /// Specifies the Greek character set (IANA name windows-1253).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsGreek))]
  public static byte Greek = 0xA1;
  /// <summary>
  /// Specifies the Greek character set (IANA name iso-8859-9).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsTurkish))]
  public static byte Turkish = 0xA2;
  /// <summary>
  /// Specifies the Greek character set (IANA name windows-1258).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsVietnamese))]
  public static byte Vietnamese = 0xA3;
  /// <summary>
  /// Specifies the Hebrew character set (IANA name windows-1255).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsHebrew))]
  public static byte Hebrew = 0xB1;
  /// <summary>
  /// Specifies the Arabic character set (IANA name windows-1256).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsArabic))]
  public static byte Arabic = 0xB2;
  /// <summary>
  /// Specifies the Baltic character set (IANA name windows-1257).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsBaltic))]
  public static byte Baltic = 0xBA;
  /// <summary>
  /// Specifies the Russian character set (IANA name windows-1251).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsRussian))]
  public static byte Russian = 0xCC;
  /// <summary>
  /// Specifies the Thai character set (IANA name windows-874).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsThai))]
  public static byte Thai = 0xDE;
  /// <summary>
  /// Specifies the EasternEuropean character set (IANA name windows-1250).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.StrictCharacterSet.chsEastEurope))]
  public static byte EastEurope = 0xEE;
  /// <summary>
  /// Specifies the OEM character set not defined by the standard.
  /// </summary>
  [NotMapped]
  public static byte OEM = 0xFF;
}