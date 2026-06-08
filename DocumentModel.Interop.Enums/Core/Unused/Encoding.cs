namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
/// saved document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoencoding?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoEncoding")]
public enum Encoding
{
  /// <summary>
  /// Thai.
  /// </summary>
  [InteropEnumValue("msoEncodingThai")]
  Thai = 874,
  /// <summary>
  /// Japanese (Shift-JIS).
  /// </summary>
  [InteropEnumValue("msoEncodingJapaneseShiftJIS")]
  JapaneseShiftJIS = 932,
  /// <summary>
  /// Simplified Chinese GBK.
  /// </summary>
  [InteropEnumValue("msoEncodingSimplifiedChineseGBK")]
  SimplifiedChineseGBK = 936,
  /// <summary>
  /// Korean.
  /// </summary>
  [InteropEnumValue("msoEncodingKorean")]
  Korean = 949,
  /// <summary>
  /// Traditional Chinese Big 5.
  /// </summary>
  [InteropEnumValue("msoEncodingTraditionalChineseBig5")]
  TraditionalChineseBig5 = 950,
  /// <summary>
  /// Unicode little endian.
  /// </summary>
  [InteropEnumValue("msoEncodingUnicodeLittleEndian")]
  UnicodeLittleEndian = 1200,
  /// <summary>
  /// Unicode big endian.
  /// </summary>
  [InteropEnumValue("msoEncodingUnicodeBigEndian")]
  UnicodeBigEndian = 1201,
  /// <summary>
  /// Central European.
  /// </summary>
  [InteropEnumValue("msoEncodingCentralEuropean")]
  CentralEuropean = 1250,
  /// <summary>
  /// Cyrillic.
  /// </summary>
  [InteropEnumValue("msoEncodingCyrillic")]
  Cyrillic = 1251,
  /// <summary>
  /// Western.
  /// </summary>
  [InteropEnumValue("msoEncodingWestern")]
  Western = 1252,
  /// <summary>
  /// Greek.
  /// </summary>
  [InteropEnumValue("msoEncodingGreek")]
  Greek = 1253,
  /// <summary>
  /// Turkish.
  /// </summary>
  [InteropEnumValue("msoEncodingTurkish")]
  Turkish = 1254,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [InteropEnumValue("msoEncodingHebrew")]
  Hebrew = 1255,
  /// <summary>
  /// Arabic.
  /// </summary>
  [InteropEnumValue("msoEncodingArabic")]
  Arabic = 1256,
  /// <summary>
  /// Baltic.
  /// </summary>
  [InteropEnumValue("msoEncodingBaltic")]
  Baltic = 1257,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  [InteropEnumValue("msoEncodingVietnamese")]
  Vietnamese = 1258,
  /// <summary>
  /// Web browser auto- detects type of encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingAutoDetect")]
  AutoDetect = 50001,
  /// <summary>
  /// Web browser auto- detects type of Japanese encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingJapaneseAutoDetect")]
  JapaneseAutoDetect = 50932,
  /// <summary>
  /// Web browser auto- detects type of Simplified Chinese encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingSimplifiedChineseAutoDetect")]
  SimplifiedChineseAutoDetect = 50936,
  /// <summary>
  /// Web browser auto- detects type of Korean encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingKoreanAutoDetect")]
  KoreanAutoDetect = 50949,
  /// <summary>
  /// Web browser auto- detects type of Traditional Chinese encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingTraditionalChineseAutoDetect")]
  TraditionalChineseAutoDetect = 50950,
  /// <summary>
  /// Web browser auto- detects type of Cyrillic encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingCyrillicAutoDetect")]
  CyrillicAutoDetect = 51251,
  /// <summary>
  /// Web browser auto- detects type of Greek encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingGreekAutoDetect")]
  GreekAutoDetect = 51253,
  /// <summary>
  /// Web browser auto- detects type of Arabic encoding to use.
  /// </summary>
  [InteropEnumValue("msoEncodingArabicAutoDetect")]
  ArabicAutoDetect = 51256,
  /// <summary>
  /// ISO 8859-1 Latin 1.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88591Latin1")]
  ISO88591Latin1 = 28591,
  /// <summary>
  /// ISO 8859-2 Central Europe.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88592CentralEurope")]
  ISO88592CentralEurope = 28592,
  /// <summary>
  /// ISO 8859-3 Latin 3.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88593Latin3")]
  ISO88593Latin3 = 28593,
  /// <summary>
  /// ISO 8859-4 Baltic.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88594Baltic")]
  ISO88594Baltic = 28594,
  /// <summary>
  /// ISO 8859-5 Cyrillic.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88595Cyrillic")]
  ISO88595Cyrillic = 28595,
  /// <summary>
  /// ISA 8859-6 Arabic.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88596Arabic")]
  ISO88596Arabic = 28596,
  /// <summary>
  /// ISO 8859-7 Greek.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88597Greek")]
  ISO88597Greek = 28597,
  /// <summary>
  /// ISO 8859-8 Hebrew.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88598Hebrew")]
  ISO88598Hebrew = 28598,
  /// <summary>
  /// ISO 8859-9 Turkish.
  /// </summary>
  [InteropEnumValue("msoEncodingISO88599Turkish")]
  ISO88599Turkish = 28599,
  /// <summary>
  /// ISO 8859-15 with Latin 9.
  /// </summary>
  [InteropEnumValue("msoEncodingISO885915Latin9")]
  ISO885915Latin9 = 28605,
  /// <summary>
  /// ISO 8859-8 Hebrew (Logical).
  /// </summary>
  [InteropEnumValue("msoEncodingISO88598HebrewLogical")]
  ISO88598HebrewLogical = 38598,
  /// <summary>
  /// ISO 2022-JP with no half-width Katakana.
  /// </summary>
  [InteropEnumValue("msoEncodingISO2022JPNoHalfwidthKatakana")]
  ISO2022JPNoHalfwidthKatakana = 50220,
  /// <summary>
  /// ISO 2022-JP
  /// </summary>
  [InteropEnumValue("msoEncodingISO2022JPJISX02021984")]
  ISO2022JPJISX02021984 = 50221,
  /// <summary>
  /// ISO 2022-JP
  /// </summary>
  [InteropEnumValue("msoEncodingISO2022JPJISX02011989")]
  ISO2022JPJISX02011989 = 50222,
  /// <summary>
  /// ISO 2022-KR.
  /// </summary>
  [InteropEnumValue("msoEncodingISO2022KR")]
  ISO2022KR = 50225,
  /// <summary>
  /// ISO 2022-CN encoding as used with Traditional Chinese.
  /// </summary>
  [InteropEnumValue("msoEncodingISO2022CNTraditionalChinese")]
  ISO2022CNTraditionalChinese = 50227,
  /// <summary>
  /// ISO 2022-CN encoding as used with Simplified Chinese.
  /// </summary>
  [InteropEnumValue("msoEncodingISO2022CNSimplifiedChinese")]
  ISO2022CNSimplifiedChinese = 50229,
  /// <summary>
  /// Macintosh Roman.
  /// </summary>
  [InteropEnumValue("msoEncodingMacRoman")]
  MacRoman = 10000,
  /// <summary>
  /// Macintosh Japanese.
  /// </summary>
  [InteropEnumValue("msoEncodingMacJapanese")]
  MacJapanese = 10001,
  /// <summary>
  /// Macintosh Traditional Chinese (Big 5).
  /// </summary>
  [InteropEnumValue("msoEncodingMacTraditionalChineseBig5")]
  MacTraditionalChineseBig5 = 10002,
  /// <summary>
  /// Macintosh Korean.
  /// </summary>
  [InteropEnumValue("msoEncodingMacKorean")]
  MacKorean = 10003,
  /// <summary>
  /// Macintosh Arabic.
  /// </summary>
  [InteropEnumValue("msoEncodingMacArabic")]
  MacArabic = 10004,
  /// <summary>
  /// Macintosh Hebrew.
  /// </summary>
  [InteropEnumValue("msoEncodingMacHebrew")]
  MacHebrew = 10005,
  /// <summary>
  /// Macintosh Greek.
  /// </summary>
  [InteropEnumValue("msoEncodingMacGreek1")]
  MacGreek1 = 10006,
  /// <summary>
  /// Macintosh Cyrillic.
  /// </summary>
  [InteropEnumValue("msoEncodingMacCyrillic")]
  MacCyrillic = 10007,
  /// <summary>
  /// Macintosh Simplified Chinese (GB 2312).
  /// </summary>
  [InteropEnumValue("msoEncodingMacSimplifiedChineseGB2312")]
  MacSimplifiedChineseGB2312 = 10008,
  /// <summary>
  /// Macintosh Romanian.
  /// </summary>
  [InteropEnumValue("msoEncodingMacRomania")]
  MacRomania = 10010,
  /// <summary>
  /// Macintosh Ukrainian.
  /// </summary>
  [InteropEnumValue("msoEncodingMacUkraine")]
  MacUkraine = 10017,
  /// <summary>
  /// Macintosh Latin 2.
  /// </summary>
  [InteropEnumValue("msoEncodingMacLatin2")]
  MacLatin2 = 10029,
  /// <summary>
  /// Macintosh Icelandic.
  /// </summary>
  [InteropEnumValue("msoEncodingMacIcelandic")]
  MacIcelandic = 10079,
  /// <summary>
  /// Macintosh Turkish.
  /// </summary>
  [InteropEnumValue("msoEncodingMacTurkish")]
  MacTurkish = 10081,
  /// <summary>
  /// Macintosh Croatian.
  /// </summary>
  [InteropEnumValue("msoEncodingMacCroatia")]
  MacCroatia = 10082,
  /// <summary>
  /// EBCDIC as used in the United States and Canada.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICUSCanada")]
  EBCDICUSCanada = 37,
  /// <summary>
  /// International EBCDIC.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICInternational")]
  EBCDICInternational = 500,
  /// <summary>
  /// EBCDIC Multilingual ROECE (Latin 2).
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICMultilingualROECELatin2")]
  EBCDICMultilingualROECELatin2 = 870,
  /// <summary>
  /// EBCDIC as used in the Modern Greek language.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICGreekModern")]
  EBCDICGreekModern = 875,
  /// <summary>
  /// EBCDIC as used with Turkish (Latin 5).
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICTurkishLatin5")]
  EBCDICTurkishLatin5 = 1026,
  /// <summary>
  /// EBCDIC as used in Germany.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICGermany")]
  EBCDICGermany = 20273,
  /// <summary>
  /// EBCDIC as used in Denmark and Norway.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICDenmarkNorway")]
  EBCDICDenmarkNorway = 20277,
  /// <summary>
  /// EBCDIC as used in Finland and Sweden.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICFinlandSweden")]
  EBCDICFinlandSweden = 20278,
  /// <summary>
  /// EBCDIC as used in Italy.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICItaly")]
  EBCDICItaly = 20280,
  /// <summary>
  /// EBCDIC as used in Latin America and Spain.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICLatinAmericaSpain")]
  EBCDICLatinAmericaSpain = 20284,
  /// <summary>
  /// EBCDIC as used in the United Kingdom.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICUnitedKingdom")]
  EBCDICUnitedKingdom = 20285,
  /// <summary>
  /// EBCDIC as used with Japanese Katakana (extended).
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICJapaneseKatakanaExtended")]
  EBCDICJapaneseKatakanaExtended = 20290,
  /// <summary>
  /// EBCDIC as used in France.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICFrance")]
  EBCDICFrance = 20297,
  /// <summary>
  /// Extended Binary Coded Decimal Interchange Code (EBCDIC) Arabic.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICArabic")]
  EBCDICArabic = 20420,
  /// <summary>
  /// EBCDIC as used in the Greek language.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICGreek")]
  EBCDICGreek = 20423,
  /// <summary>
  /// EBCDIC as used in the Hebrew language.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICHebrew")]
  EBCDICHebrew = 20424,
  /// <summary>
  /// EBCDIC as used with Korean (extended).
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICKoreanExtended")]
  EBCDICKoreanExtended = 20833,
  /// <summary>
  /// EBCDIC as used with Thai.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICThai")]
  EBCDICThai = 20838,
  /// <summary>
  /// EBCDIC as used in Iceland.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICIcelandic")]
  EBCDICIcelandic = 20871,
  /// <summary>
  /// EBCDIC as used with Turkish.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICTurkish")]
  EBCDICTurkish = 20905,
  /// <summary>
  /// EBCDIC as used with Russian.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICRussian")]
  EBCDICRussian = 20880,
  /// <summary>
  /// EBCDIC as used with Serbian and Bulgarian.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICSerbianBulgarian")]
  EBCDICSerbianBulgarian = 21025,
  /// <summary>
  /// EBCDIC as used with Japanese Katakana (extended) and Japanese.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICJapaneseKatakanaExtendedAndJapanese")]
  EBCDICJapaneseKatakanaExtendedAndJapanese = 50930,
  /// <summary>
  /// EBCDIC as used in the United States and Canada, and with Japanese.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICUSCanadaAndJapanese")]
  EBCDICUSCanadaAndJapanese = 50931,
  /// <summary>
  /// EBCDIC as used with Korean (extended) and Korean.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICKoreanExtendedAndKorean")]
  EBCDICKoreanExtendedAndKorean = 50933,
  /// <summary>
  /// EBCDIC as used with Simplified Chinese (extended) and Simplified Chinese.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICSimplifiedChineseExtendedAndSimplifiedChinese")]
  EBCDICSimplifiedChineseExtendedAndSimplifiedChinese = 50935,
  /// <summary>
  /// EBCDIC as used in the United States and Canada, and with Traditional Chinese.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICUSCanadaAndTraditionalChinese")]
  EBCDICUSCanadaAndTraditionalChinese = 50937,
  /// <summary>
  /// EBCDIC as used with Japanese Latin (extended) and Japanese.
  /// </summary>
  [InteropEnumValue("msoEncodingEBCDICJapaneseLatinExtendedAndJapanese")]
  EBCDICJapaneseLatinExtendedAndJapanese = 50939,
  /// <summary>
  /// OEM as used in the United States.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMUnitedStates")]
  OEMUnitedStates = 437,
  /// <summary>
  /// OEM as used with Greek 437G.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMGreek437G")]
  OEMGreek437G = 737,
  /// <summary>
  /// OEM as used with Baltic.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMBaltic")]
  OEMBaltic = 775,
  /// <summary>
  /// OEM as used with multi- lingual Latin I.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMMultilingualLatinI")]
  OEMMultilingualLatinI = 850,
  /// <summary>
  /// OEM as used with multi- lingual Latin II.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMMultilingualLatinII")]
  OEMMultilingualLatinII = 852,
  /// <summary>
  /// OEM as used with Cyrillic.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMCyrillic")]
  OEMCyrillic = 855,
  /// <summary>
  /// OEM as used with Turkish.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMTurkish")]
  OEMTurkish = 857,
  /// <summary>
  /// OEM as used with Portuguese.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMPortuguese")]
  OEMPortuguese = 860,
  /// <summary>
  /// OEM as used with Icelandic.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMIcelandic")]
  OEMIcelandic = 861,
  /// <summary>
  /// OEM as used with Hebrew.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMHebrew")]
  OEMHebrew = 862,
  /// <summary>
  /// OEM as used with Canadian French.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMCanadianFrench")]
  OEMCanadianFrench = 863,
  /// <summary>
  /// OEM as used with Arabic.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMArabic")]
  OEMArabic = 864,
  /// <summary>
  /// OEM as used with Nordic languages.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMNordic")]
  OEMNordic = 865,
  /// <summary>
  /// OEM as used with Cyrillic II.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMCyrillicII")]
  OEMCyrillicII = 866,
  /// <summary>
  /// OEM as used with Modern Greek.
  /// </summary>
  [InteropEnumValue("msoEncodingOEMModernGreek")]
  OEMModernGreek = 869,
  /// <summary>
  /// EUC as used with Japanese.
  /// </summary>
  [InteropEnumValue("msoEncodingEUCJapanese")]
  EUCJapanese = 51932,
  /// <summary>
  /// Extended Unix Code (EUC) as used with Chinese and Simplified Chinese.
  /// </summary>
  [InteropEnumValue("msoEncodingEUCChineseSimplifiedChinese")]
  EUCChineseSimplifiedChinese = 51936,
  /// <summary>
  /// EUC as used with Korean.
  /// </summary>
  [InteropEnumValue("msoEncodingEUCKorean")]
  EUCKorean = 51949,
  /// <summary>
  /// EUC as used with Taiwanese and Traditional Chinese.
  /// </summary>
  [InteropEnumValue("msoEncodingEUCTaiwaneseTraditionalChinese")]
  EUCTaiwaneseTraditionalChinese = 51950,
  /// <summary>
  /// ISCII as used with Devanagari.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIDevanagari")]
  ISCIIDevanagari = 57002,
  /// <summary>
  /// ISCII as used with Bengali.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIBengali")]
  ISCIIBengali = 57003,
  /// <summary>
  /// ISCII as used with Tamil.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIITamil")]
  ISCIITamil = 57004,
  /// <summary>
  /// ISCII as used with Telugu.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIITelugu")]
  ISCIITelugu = 57005,
  /// <summary>
  /// Indian Script Code for Information Interchange (ISCII) as used with Assamese.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIAssamese")]
  ISCIIAssamese = 57006,
  /// <summary>
  /// ISCII as used with Oriya.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIOriya")]
  ISCIIOriya = 57007,
  /// <summary>
  /// ISCII as used with Kannada.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIKannada")]
  ISCIIKannada = 57008,
  /// <summary>
  /// ISCII as used with Malayalam.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIMalayalam")]
  ISCIIMalayalam = 57009,
  /// <summary>
  /// ISCII as used with Gujarati.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIGujarati")]
  ISCIIGujarati = 57010,
  /// <summary>
  /// ISCII as used with Punjabi.
  /// </summary>
  [InteropEnumValue("msoEncodingISCIIPunjabi")]
  ISCIIPunjabi = 57011,
  /// <summary>
  /// Arabic ASMO.
  /// </summary>
  [InteropEnumValue("msoEncodingArabicASMO")]
  ArabicASMO = 708,
  /// <summary>
  /// Transparent Arabic.
  /// </summary>
  [InteropEnumValue("msoEncodingArabicTransparentASMO")]
  ArabicTransparentASMO = 720,
  /// <summary>
  /// Korean (Johab).
  /// </summary>
  [InteropEnumValue("msoEncodingKoreanJohab")]
  KoreanJohab = 1361,
  /// <summary>
  /// Taiwan CNS.
  /// </summary>
  [InteropEnumValue("msoEncodingTaiwanCNS")]
  TaiwanCNS = 20000,
  /// <summary>
  /// Taiwan TCA.
  /// </summary>
  [InteropEnumValue("msoEncodingTaiwanTCA")]
  TaiwanTCA = 20001,
  /// <summary>
  /// Taiwan Eten.
  /// </summary>
  [InteropEnumValue("msoEncodingTaiwanEten")]
  TaiwanEten = 20002,
  /// <summary>
  /// Taiwan IBM 5550.
  /// </summary>
  [InteropEnumValue("msoEncodingTaiwanIBM5550")]
  TaiwanIBM5550 = 20003,
  /// <summary>
  /// Taiwan Teletext.
  /// </summary>
  [InteropEnumValue("msoEncodingTaiwanTeleText")]
  TaiwanTeleText = 20004,
  /// <summary>
  /// Taiwan Wang.
  /// </summary>
  [InteropEnumValue("msoEncodingTaiwanWang")]
  TaiwanWang = 20005,
  /// <summary>
  /// IA5, International Reference Version (IRV).
  /// </summary>
  [InteropEnumValue("msoEncodingIA5IRV")]
  IA5IRV = 20105,
  /// <summary>
  /// German (International Alphabet No. 5, or IA5).
  /// </summary>
  [InteropEnumValue("msoEncodingIA5German")]
  IA5German = 20106,
  /// <summary>
  /// IA5 as used with Swedish.
  /// </summary>
  [InteropEnumValue("msoEncodingIA5Swedish")]
  IA5Swedish = 20107,
  /// <summary>
  /// IA5 as used with Norwegian.
  /// </summary>
  [InteropEnumValue("msoEncodingIA5Norwegian")]
  IA5Norwegian = 20108,
  /// <summary>
  /// United States ASCII.
  /// </summary>
  [InteropEnumValue("msoEncodingUSASCII")]
  USASCII = 20127,
  /// <summary>
  /// T61.
  /// </summary>
  [InteropEnumValue("msoEncodingT61")]
  T61 = 20261,
  /// <summary>
  /// ISO 6937 Non-Spacing Accent.
  /// </summary>
  [InteropEnumValue("msoEncodingISO6937NonSpacingAccent")]
  ISO6937NonSpacingAccent = 20269,
  /// <summary>
  /// KOI8-R.
  /// </summary>
  [InteropEnumValue("msoEncodingKOI8R")]
  KOI8R = 20866,
  /// <summary>
  /// Extended Alpha lowercase.
  /// </summary>
  [InteropEnumValue("msoEncodingExtAlphaLowercase")]
  ExtAlphaLowercase = 21027,
  /// <summary>
  /// K0I8-U.
  /// </summary>
  [InteropEnumValue("msoEncodingKOI8U")]
  KOI8U = 21866,
  /// <summary>
  /// Europa.
  /// </summary>
  [InteropEnumValue("msoEncodingEuropa3")]
  Europa3 = 29001,
  /// <summary>
  /// Simplified Chinese (HZGB).
  /// </summary>
  [InteropEnumValue("msoEncodingHZGBSimplifiedChinese")]
  HZGBSimplifiedChinese = 52936,
  /// <summary>
  /// Simplified Chinese GB 18030.
  /// </summary>
  [InteropEnumValue("msoEncodingSimplifiedChineseGB18030")]
  SimplifiedChineseGB18030 = 54936,
  /// <summary>
  /// UTF-7 encoding.
  /// </summary>
  [InteropEnumValue("msoEncodingUTF7")]
  UTF7 = 65000,
  /// <summary>
  /// UTF-8 encoding.
  /// </summary>
  [InteropEnumValue("msoEncodingUTF8")]
  UTF8 = 65001
}
