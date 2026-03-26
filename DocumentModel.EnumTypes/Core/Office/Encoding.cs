namespace DocumentMode.Office;

/// <summary>
/// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
/// saved document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoencoding?view=office-pia` for Office interop details.
/// </remarks>
public enum Encoding
{
  /// <summary>
  /// Thai.
  /// </summary>
  Thai = 874,
  /// <summary>
  /// Japanese (Shift-JIS).
  /// </summary>
  JapaneseShiftJIS = 932,
  /// <summary>
  /// Simplified Chinese GBK.
  /// </summary>
  SimplifiedChineseGBK = 936,
  /// <summary>
  /// Korean.
  /// </summary>
  Korean = 949,
  /// <summary>
  /// Traditional Chinese Big 5.
  /// </summary>
  TraditionalChineseBig5 = 950,
  /// <summary>
  /// Unicode little endian.
  /// </summary>
  UnicodeLittleEndian = 1200,
  /// <summary>
  /// Unicode big endian.
  /// </summary>
  UnicodeBigEndian = 1201,
  /// <summary>
  /// Central European.
  /// </summary>
  CentralEuropean = 1250,
  /// <summary>
  /// Cyrillic.
  /// </summary>
  Cyrillic = 1251,
  /// <summary>
  /// Western.
  /// </summary>
  Western = 1252,
  /// <summary>
  /// Greek.
  /// </summary>
  Greek = 1253,
  /// <summary>
  /// Turkish.
  /// </summary>
  Turkish = 1254,
  /// <summary>
  /// Hebrew.
  /// </summary>
  Hebrew = 1255,
  /// <summary>
  /// Arabic.
  /// </summary>
  Arabic = 1256,
  /// <summary>
  /// Baltic.
  /// </summary>
  Baltic = 1257,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  Vietnamese = 1258,
  /// <summary>
  /// Web browser auto- detects type of encoding to use.
  /// </summary>
  AutoDetect = 50001,
  /// <summary>
  /// Web browser auto- detects type of Japanese encoding to use.
  /// </summary>
  JapaneseAutoDetect = 50932,
  /// <summary>
  /// Web browser auto- detects type of Simplified Chinese encoding to use.
  /// </summary>
  SimplifiedChineseAutoDetect = 50936,
  /// <summary>
  /// Web browser auto- detects type of Korean encoding to use.
  /// </summary>
  KoreanAutoDetect = 50949,
  /// <summary>
  /// Web browser auto- detects type of Traditional Chinese encoding to use.
  /// </summary>
  TraditionalChineseAutoDetect = 50950,
  /// <summary>
  /// Web browser auto- detects type of Cyrillic encoding to use.
  /// </summary>
  CyrillicAutoDetect = 51251,
  /// <summary>
  /// Web browser auto- detects type of Greek encoding to use.
  /// </summary>
  GreekAutoDetect = 51253,
  /// <summary>
  /// Web browser auto- detects type of Arabic encoding to use.
  /// </summary>
  ArabicAutoDetect = 51256,
  /// <summary>
  /// ISO 8859-1 Latin 1.
  /// </summary>
  ISO88591Latin1 = 28591,
  /// <summary>
  /// ISO 8859-2 Central Europe.
  /// </summary>
  ISO88592CentralEurope = 28592,
  /// <summary>
  /// ISO 8859-3 Latin 3.
  /// </summary>
  ISO88593Latin3 = 28593,
  /// <summary>
  /// ISO 8859-4 Baltic.
  /// </summary>
  ISO88594Baltic = 28594,
  /// <summary>
  /// ISO 8859-5 Cyrillic.
  /// </summary>
  ISO88595Cyrillic = 28595,
  /// <summary>
  /// ISA 8859-6 Arabic.
  /// </summary>
  ISO88596Arabic = 28596,
  /// <summary>
  /// ISO 8859-7 Greek.
  /// </summary>
  ISO88597Greek = 28597,
  /// <summary>
  /// ISO 8859-8 Hebrew.
  /// </summary>
  ISO88598Hebrew = 28598,
  /// <summary>
  /// ISO 8859-9 Turkish.
  /// </summary>
  ISO88599Turkish = 28599,
  /// <summary>
  /// ISO 8859-15 with Latin 9.
  /// </summary>
  ISO885915Latin9 = 28605,
  /// <summary>
  /// ISO 8859-8 Hebrew (Logical).
  /// </summary>
  ISO88598HebrewLogical = 38598,
  /// <summary>
  /// ISO 2022-JP with no half-width Katakana.
  /// </summary>
  ISO2022JPNoHalfwidthKatakana = 50220,
  /// <summary>
  /// ISO 2022-JP
  /// </summary>
  ISO2022JPJISX02021984 = 50221,
  /// <summary>
  /// ISO 2022-JP
  /// </summary>
  ISO2022JPJISX02011989 = 50222,
  /// <summary>
  /// ISO 2022-KR.
  /// </summary>
  ISO2022KR = 50225,
  /// <summary>
  /// ISO 2022-CN encoding as used with Traditional Chinese.
  /// </summary>
  ISO2022CNTraditionalChinese = 50227,
  /// <summary>
  /// ISO 2022-CN encoding as used with Simplified Chinese.
  /// </summary>
  ISO2022CNSimplifiedChinese = 50229,
  /// <summary>
  /// Macintosh Roman.
  /// </summary>
  MacRoman = 10000,
  /// <summary>
  /// Macintosh Japanese.
  /// </summary>
  MacJapanese = 10001,
  /// <summary>
  /// Macintosh Traditional Chinese (Big 5).
  /// </summary>
  MacTraditionalChineseBig5 = 10002,
  /// <summary>
  /// Macintosh Korean.
  /// </summary>
  MacKorean = 10003,
  /// <summary>
  /// Macintosh Arabic.
  /// </summary>
  MacArabic = 10004,
  /// <summary>
  /// Macintosh Hebrew.
  /// </summary>
  MacHebrew = 10005,
  /// <summary>
  /// Macintosh Greek.
  /// </summary>
  MacGreek1 = 10006,
  /// <summary>
  /// Macintosh Cyrillic.
  /// </summary>
  MacCyrillic = 10007,
  /// <summary>
  /// Macintosh Simplified Chinese (GB 2312).
  /// </summary>
  MacSimplifiedChineseGB2312 = 10008,
  /// <summary>
  /// Macintosh Romanian.
  /// </summary>
  MacRomania = 10010,
  /// <summary>
  /// Macintosh Ukrainian.
  /// </summary>
  MacUkraine = 10017,
  /// <summary>
  /// Macintosh Latin 2.
  /// </summary>
  MacLatin2 = 10029,
  /// <summary>
  /// Macintosh Icelandic.
  /// </summary>
  MacIcelandic = 10079,
  /// <summary>
  /// Macintosh Turkish.
  /// </summary>
  MacTurkish = 10081,
  /// <summary>
  /// Macintosh Croatian.
  /// </summary>
  MacCroatia = 10082,
  /// <summary>
  /// EBCDIC as used in the United States and Canada.
  /// </summary>
  EBCDICUSCanada = 37,
  /// <summary>
  /// International EBCDIC.
  /// </summary>
  EBCDICInternational = 500,
  /// <summary>
  /// EBCDIC Multilingual ROECE (Latin 2).
  /// </summary>
  EBCDICMultilingualROECELatin2 = 870,
  /// <summary>
  /// EBCDIC as used in the Modern Greek language.
  /// </summary>
  EBCDICGreekModern = 875,
  /// <summary>
  /// EBCDIC as used with Turkish (Latin 5).
  /// </summary>
  EBCDICTurkishLatin5 = 1026,
  /// <summary>
  /// EBCDIC as used in Germany.
  /// </summary>
  EBCDICGermany = 20273,
  /// <summary>
  /// EBCDIC as used in Denmark and Norway.
  /// </summary>
  EBCDICDenmarkNorway = 20277,
  /// <summary>
  /// EBCDIC as used in Finland and Sweden.
  /// </summary>
  EBCDICFinlandSweden = 20278,
  /// <summary>
  /// EBCDIC as used in Italy.
  /// </summary>
  EBCDICItaly = 20280,
  /// <summary>
  /// EBCDIC as used in Latin America and Spain.
  /// </summary>
  EBCDICLatinAmericaSpain = 20284,
  /// <summary>
  /// EBCDIC as used in the United Kingdom.
  /// </summary>
  EBCDICUnitedKingdom = 20285,
  /// <summary>
  /// EBCDIC as used with Japanese Katakana (extended).
  /// </summary>
  EBCDICJapaneseKatakanaExtended = 20290,
  /// <summary>
  /// EBCDIC as used in France.
  /// </summary>
  EBCDICFrance = 20297,
  /// <summary>
  /// Extended Binary Coded Decimal Interchange Code (EBCDIC) Arabic.
  /// </summary>
  EBCDICArabic = 20420,
  /// <summary>
  /// EBCDIC as used in the Greek language.
  /// </summary>
  EBCDICGreek = 20423,
  /// <summary>
  /// EBCDIC as used in the Hebrew language.
  /// </summary>
  EBCDICHebrew = 20424,
  /// <summary>
  /// EBCDIC as used with Korean (extended).
  /// </summary>
  EBCDICKoreanExtended = 20833,
  /// <summary>
  /// EBCDIC as used with Thai.
  /// </summary>
  EBCDICThai = 20838,
  /// <summary>
  /// EBCDIC as used in Iceland.
  /// </summary>
  EBCDICIcelandic = 20871,
  /// <summary>
  /// EBCDIC as used with Turkish.
  /// </summary>
  EBCDICTurkish = 20905,
  /// <summary>
  /// EBCDIC as used with Russian.
  /// </summary>
  EBCDICRussian = 20880,
  /// <summary>
  /// EBCDIC as used with Serbian and Bulgarian.
  /// </summary>
  EBCDICSerbianBulgarian = 21025,
  /// <summary>
  /// EBCDIC as used with Japanese Katakana (extended) and Japanese.
  /// </summary>
  EBCDICJapaneseKatakanaExtendedAndJapanese = 50930,
  /// <summary>
  /// EBCDIC as used in the United States and Canada, and with Japanese.
  /// </summary>
  EBCDICUSCanadaAndJapanese = 50931,
  /// <summary>
  /// EBCDIC as used with Korean (extended) and Korean.
  /// </summary>
  EBCDICKoreanExtendedAndKorean = 50933,
  /// <summary>
  /// EBCDIC as used with Simplified Chinese (extended) and Simplified Chinese.
  /// </summary>
  EBCDICSimplifiedChineseExtendedAndSimplifiedChinese = 50935,
  /// <summary>
  /// EBCDIC as used in the United States and Canada, and with Traditional Chinese.
  /// </summary>
  EBCDICUSCanadaAndTraditionalChinese = 50937,
  /// <summary>
  /// EBCDIC as used with Japanese Latin (extended) and Japanese.
  /// </summary>
  EBCDICJapaneseLatinExtendedAndJapanese = 50939,
  /// <summary>
  /// OEM as used in the United States.
  /// </summary>
  OEMUnitedStates = 437,
  /// <summary>
  /// OEM as used with Greek 437G.
  /// </summary>
  OEMGreek437G = 737,
  /// <summary>
  /// OEM as used with Baltic.
  /// </summary>
  OEMBaltic = 775,
  /// <summary>
  /// OEM as used with multi- lingual Latin I.
  /// </summary>
  OEMMultilingualLatinI = 850,
  /// <summary>
  /// OEM as used with multi- lingual Latin II.
  /// </summary>
  OEMMultilingualLatinII = 852,
  /// <summary>
  /// OEM as used with Cyrillic.
  /// </summary>
  OEMCyrillic = 855,
  /// <summary>
  /// OEM as used with Turkish.
  /// </summary>
  OEMTurkish = 857,
  /// <summary>
  /// OEM as used with Portuguese.
  /// </summary>
  OEMPortuguese = 860,
  /// <summary>
  /// OEM as used with Icelandic.
  /// </summary>
  OEMIcelandic = 861,
  /// <summary>
  /// OEM as used with Hebrew.
  /// </summary>
  OEMHebrew = 862,
  /// <summary>
  /// OEM as used with Canadian French.
  /// </summary>
  OEMCanadianFrench = 863,
  /// <summary>
  /// OEM as used with Arabic.
  /// </summary>
  OEMArabic = 864,
  /// <summary>
  /// OEM as used with Nordic languages.
  /// </summary>
  OEMNordic = 865,
  /// <summary>
  /// OEM as used with Cyrillic II.
  /// </summary>
  OEMCyrillicII = 866,
  /// <summary>
  /// OEM as used with Modern Greek.
  /// </summary>
  OEMModernGreek = 869,
  /// <summary>
  /// EUC as used with Japanese.
  /// </summary>
  EUCJapanese = 51932,
  /// <summary>
  /// Extended Unix Code (EUC) as used with Chinese and Simplified Chinese.
  /// </summary>
  EUCChineseSimplifiedChinese = 51936,
  /// <summary>
  /// EUC as used with Korean.
  /// </summary>
  EUCKorean = 51949,
  /// <summary>
  /// EUC as used with Taiwanese and Traditional Chinese.
  /// </summary>
  EUCTaiwaneseTraditionalChinese = 51950,
  /// <summary>
  /// ISCII as used with Devanagari.
  /// </summary>
  ISCIIDevanagari = 57002,
  /// <summary>
  /// ISCII as used with Bengali.
  /// </summary>
  ISCIIBengali = 57003,
  /// <summary>
  /// ISCII as used with Tamil.
  /// </summary>
  ISCIITamil = 57004,
  /// <summary>
  /// ISCII as used with Telugu.
  /// </summary>
  ISCIITelugu = 57005,
  /// <summary>
  /// Indian Script Code for Information Interchange (ISCII) as used with Assamese.
  /// </summary>
  ISCIIAssamese = 57006,
  /// <summary>
  /// ISCII as used with Oriya.
  /// </summary>
  ISCIIOriya = 57007,
  /// <summary>
  /// ISCII as used with Kannada.
  /// </summary>
  ISCIIKannada = 57008,
  /// <summary>
  /// ISCII as used with Malayalam.
  /// </summary>
  ISCIIMalayalam = 57009,
  /// <summary>
  /// ISCII as used with Gujarati.
  /// </summary>
  ISCIIGujarati = 57010,
  /// <summary>
  /// ISCII as used with Punjabi.
  /// </summary>
  ISCIIPunjabi = 57011,
  /// <summary>
  /// Arabic ASMO.
  /// </summary>
  ArabicASMO = 708,
  /// <summary>
  /// Transparent Arabic.
  /// </summary>
  ArabicTransparentASMO = 720,
  /// <summary>
  /// Korean (Johab).
  /// </summary>
  KoreanJohab = 1361,
  /// <summary>
  /// Taiwan CNS.
  /// </summary>
  TaiwanCNS = 20000,
  /// <summary>
  /// Taiwan TCA.
  /// </summary>
  TaiwanTCA = 20001,
  /// <summary>
  /// Taiwan Eten.
  /// </summary>
  TaiwanEten = 20002,
  /// <summary>
  /// Taiwan IBM 5550.
  /// </summary>
  TaiwanIBM5550 = 20003,
  /// <summary>
  /// Taiwan Teletext.
  /// </summary>
  TaiwanTeleText = 20004,
  /// <summary>
  /// Taiwan Wang.
  /// </summary>
  TaiwanWang = 20005,
  /// <summary>
  /// IA5, International Reference Version (IRV).
  /// </summary>
  IA5IRV = 20105,
  /// <summary>
  /// German (International Alphabet No. 5, or IA5).
  /// </summary>
  IA5German = 20106,
  /// <summary>
  /// IA5 as used with Swedish.
  /// </summary>
  IA5Swedish = 20107,
  /// <summary>
  /// IA5 as used with Norwegian.
  /// </summary>
  IA5Norwegian = 20108,
  /// <summary>
  /// United States ASCII.
  /// </summary>
  USASCII = 20127,
  /// <summary>
  /// T61.
  /// </summary>
  T61 = 20261,
  /// <summary>
  /// ISO 6937 Non-Spacing Accent.
  /// </summary>
  ISO6937NonSpacingAccent = 20269,
  /// <summary>
  /// KOI8-R.
  /// </summary>
  KOI8R = 20866,
  /// <summary>
  /// Extended Alpha lowercase.
  /// </summary>
  ExtAlphaLowercase = 21027,
  /// <summary>
  /// K0I8-U.
  /// </summary>
  KOI8U = 21866,
  /// <summary>
  /// Europa.
  /// </summary>
  Europa3 = 29001,
  /// <summary>
  /// Simplified Chinese (HZGB).
  /// </summary>
  HZGBSimplifiedChinese = 52936,
  /// <summary>
  /// Simplified Chinese GB 18030.
  /// </summary>
  SimplifiedChineseGB18030 = 54936,
  /// <summary>
  /// UTF-7 encoding.
  /// </summary>
  UTF7 = 65000,
  /// <summary>
  /// UTF-8 encoding.
  /// </summary>
  UTF8 = 65001
}
