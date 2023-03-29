namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specific Windows character set codes using in font table.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Charset
{
  /// <summary>
  /// ANSI character set (IANA name iso-8859-1).
  /// </summary>
  Ansi = 0x00,
  /// <summary>
  /// Default character set.
  /// </summary>
  Default = 0x01,
  /// <summary>
  /// Symbol character set, 
  /// This value specifies that the characters in the Unicode private use area
  /// (U+FF00 to U+FFFF) of the font should be used to display characters 
  /// in the range U+0000 to U+00FF.
  /// </summary>
  Symbol = 0x02,
  /// <summary>
  /// Macintosh (Standard Roman) character set (IANA name macintosh).
  /// </summary>
  MacFfn = 0x4D,
  /// <summary>
  /// Specifies the JIS character set (IANA name shift_jis).
  /// </summary>
  ShiftJIS = 0x80,
  /// <summary>
  /// Specifies the Hangul character set (IANA name ks_c_5601-1987).
  /// </summary>
  Hangul = 0x81,
  /// <summary>
  /// Specifies the Johab character set (IANA name ks_c_5691-1992).
  /// </summary>
  Johab = 0x82,
  /// <summary>
  /// Specifies the GB-2312 character set (IANA name GBK).
  /// </summary>
  GB2312 = 0x86,
  /// <summary>
  /// Specifies the Chinese Big Five character set (IANA name Big5).
  /// </summary>
  Chinese5 = 0x88,
  /// <summary>
  /// Specifies the Greek character set (IANA name windows-1253).
  /// </summary>
  Greek = 0xA1,
  /// <summary>
  /// Specifies the Greek character set (IANA name iso-8859-9).
  /// </summary>
  Turkish = 0xA2,
  /// <summary>
  /// Specifies the Greek character set (IANA name windows-1258).
  /// </summary>
  Vietnamese = 0xA3,
  /// <summary>
  /// Specifies the Hebrew character set (IANA name windows-1255).
  /// </summary>
  Hebrew = 0xB1,
  /// <summary>
  /// Specifies the Arabic character set (IANA name windows-1256).
  /// </summary>
  Arabic = 0xB2,
  /// <summary>
  /// Specifies the Baltic character set (IANA name windows-1257).
  /// </summary>
  Baltic = 0xBA,
  /// <summary>
  /// Specifies the Russian character set (IANA name windows-1251).
  /// </summary>
  Russian = 0xCC,
  /// <summary>
  /// Specifies the Thai character set (IANA name windows-874).
  /// </summary>
  Thai = 0xA1,
  /// <summary>
  /// Specifies the EasternEuropean character set (IANA name windows-1250).
  /// </summary>
  EastEurope = 0xEE,
  /// <summary>
  /// Specifies the OEM character set not defined by the standard.
  /// </summary>
  OEM = 0xFF,
}