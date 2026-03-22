namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
/// saved document.
/// </summary>
public enum MsoEncoding
{
  /// <summary>
  /// Thai.
  /// </summary>
  msoEncodingThai = 874,
  /// <summary>
  /// Japanese (Shift-JIS).
  /// </summary>
  msoEncodingJapaneseShiftJIS = 932,
  /// <summary>
  /// Simplified Chinese GBK.
  /// </summary>
  msoEncodingSimplifiedChineseGBK = 936,
  /// <summary>
  /// Korean.
  /// </summary>
  msoEncodingKorean = 949,
  /// <summary>
  /// Traditional Chinese Big 5.
  /// </summary>
  msoEncodingTraditionalChineseBig5 = 950,
  /// <summary>
  /// Unicode little endian.
  /// </summary>
  msoEncodingUnicodeLittleEndian = 1200,
  /// <summary>
  /// Unicode big endian.
  /// </summary>
  msoEncodingUnicodeBigEndian = 1201,
  /// <summary>
  /// Central European.
  /// </summary>
  msoEncodingCentralEuropean = 1250,
  /// <summary>
  /// Cyrillic.
  /// </summary>
  msoEncodingCyrillic = 1251,
  /// <summary>
  /// Western.
  /// </summary>
  msoEncodingWestern = 1252,
  /// <summary>
  /// Greek.
  /// </summary>
  msoEncodingGreek = 1253,
  /// <summary>
  /// Turkish.
  /// </summary>
  msoEncodingTurkish = 1254,
  /// <summary>
  /// Hebrew.
  /// </summary>
  msoEncodingHebrew = 1255,
  /// <summary>
  /// Arabic.
  /// </summary>
  msoEncodingArabic = 1256,
  /// <summary>
  /// Baltic.
  /// </summary>
  msoEncodingBaltic = 1257,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  msoEncodingVietnamese = 1258,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingAutoDetect = 50001,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingJapaneseAutoDetect = 50932,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingSimplifiedChineseAutoDetect = 50936,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingKoreanAutoDetect = 50949,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingTraditionalChineseAutoDetect = 50950,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingCyrillicAutoDetect = 51251,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingGreekAutoDetect = 51253,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingArabicAutoDetect = 51256,
  /// <summary>
  /// ISO 8859-1 Latin 1.
  /// </summary>
  msoEncodingISO88591Latin1 = 28591,
  /// <summary>
  /// ISO 8859-2 Central Europe.
  /// </summary>
  msoEncodingISO88592CentralEurope = 28592,
  /// <summary>
  /// ISO 8859-3 Latin 3.
  /// </summary>
  msoEncodingISO88593Latin3 = 28593,
  /// <summary>
  /// ISO 8859-4 Baltic.
  /// </summary>
  msoEncodingISO88594Baltic = 28594,
  /// <summary>
  /// ISO 8859-5 Cyrillic.
  /// </summary>
  msoEncodingISO88595Cyrillic = 28595,
  /// <summary>
  /// ISA 8859-6 Arabic.
  /// </summary>
  msoEncodingISO88596Arabic = 28596,
  /// <summary>
  /// ISO 8859-7 Greek.
  /// </summary>
  msoEncodingISO88597Greek = 28597,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO88598Hebrew = 28598,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO88599Turkish = 28599,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO885915Latin9 = 28605,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO88598HebrewLogical = 38598,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO2022JPNoHalfwidthKatakana = 50220,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO2022JPJISX02021984 = 50221,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO2022JPJISX02011989 = 50222,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO2022KR = 50225,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO2022CNTraditionalChinese = 50227,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISO2022CNSimplifiedChinese = 50229,
  /// <summary>
  /// Macintosh Roman.
  /// </summary>
  msoEncodingMacRoman = 10000,
  /// <summary>
  /// Macintosh Japanese.
  /// </summary>
  msoEncodingMacJapanese = 10001,
  /// <summary>
  /// Macintosh Traditional Chinese (Big 5).
  /// </summary>
  msoEncodingMacTraditionalChineseBig5 = 10002,
  /// <summary>
  /// Macintosh Korean.
  /// </summary>
  msoEncodingMacKorean = 10003,
  /// <summary>
  /// Macintosh Arabic.
  /// </summary>
  msoEncodingMacArabic = 10004,
  /// <summary>
  /// Macintosh Hebrew.
  /// </summary>
  msoEncodingMacHebrew = 10005,
  /// <summary>
  /// Macintosh Greek.
  /// </summary>
  msoEncodingMacGreek1 = 10006,
  /// <summary>
  /// Macintosh Cyrillic.
  /// </summary>
  msoEncodingMacCyrillic = 10007,
  /// <summary>
  /// Macintosh Simplified Chinese (GB 2312).
  /// </summary>
  msoEncodingMacSimplifiedChineseGB2312 = 10008,
  /// <summary>
  /// Macintosh Romanian.
  /// </summary>
  msoEncodingMacRomania = 10010,
  /// <summary>
  /// Macintosh Ukrainian.
  /// </summary>
  msoEncodingMacUkraine = 10017,
  /// <summary>
  /// Macintosh Latin 2.
  /// </summary>
  msoEncodingMacLatin2 = 10029,
  /// <summary>
  /// Macintosh Icelandic.
  /// </summary>
  msoEncodingMacIcelandic = 10079,
  /// <summary>
  /// Macintosh Turkish.
  /// </summary>
  msoEncodingMacTurkish = 10081,
  /// <summary>
  /// Macintosh Croatian.
  /// </summary>
  msoEncodingMacCroatia = 10082,
  /// <summary>
  /// EBCDIC as used in the United States and Canada.
  /// </summary>
  msoEncodingEBCDICUSCanada = 37,
  /// <summary>
  /// International EBCDIC.
  /// </summary>
  msoEncodingEBCDICInternational = 500,
  /// <summary>
  /// EBCDIC Multilingual ROECE (Latin 2).
  /// </summary>
  msoEncodingEBCDICMultilingualROECELatin2 = 870,
  /// <summary>
  /// EBCDIC as used in the Modern Greek language.
  /// </summary>
  msoEncodingEBCDICGreekModern = 875,
  /// <summary>
  /// EBCDIC as used with Turkish (Latin 5).
  /// </summary>
  msoEncodingEBCDICTurkishLatin5 = 1026,
  /// <summary>
  /// EBCDIC as used in Germany.
  /// </summary>
  msoEncodingEBCDICGermany = 20273,
  /// <summary>
  /// EBCDIC as used in Denmark and Norway.
  /// </summary>
  msoEncodingEBCDICDenmarkNorway = 20277,
  /// <summary>
  /// EBCDIC as used in Finland and Sweden.
  /// </summary>
  msoEncodingEBCDICFinlandSweden = 20278,
  /// <summary>
  /// EBCDIC as used in Italy.
  /// </summary>
  msoEncodingEBCDICItaly = 20280,
  /// <summary>
  /// EBCDIC as used in Latin America and Spain.
  /// </summary>
  msoEncodingEBCDICLatinAmericaSpain = 20284,
  /// <summary>
  /// EBCDIC as used in the United Kingdom.
  /// </summary>
  msoEncodingEBCDICUnitedKingdom = 20285,
  /// <summary>
  /// EBCDIC as used with Japanese Katakana (extended).
  /// </summary>
  msoEncodingEBCDICJapaneseKatakanaExtended = 20290,
  /// <summary>
  /// EBCDIC as used in France.
  /// </summary>
  msoEncodingEBCDICFrance = 20297,
  /// <summary>
  /// Extended Binary Coded Decimal Interchange Code (EBCDIC) Arabic.
  /// </summary>
  msoEncodingEBCDICArabic = 20420,
  /// <summary>
  /// EBCDIC as used in the Greek language.
  /// </summary>
  msoEncodingEBCDICGreek = 20423,
  /// <summary>
  /// EBCDIC as used in the Hebrew language.
  /// </summary>
  msoEncodingEBCDICHebrew = 20424,
  /// <summary>
  /// EBCDIC as used with Korean (extended).
  /// </summary>
  msoEncodingEBCDICKoreanExtended = 20833,
  /// <summary>
  /// EBCDIC as used with Thai.
  /// </summary>
  msoEncodingEBCDICThai = 20838,
  /// <summary>
  /// EBCDIC as used in Iceland.
  /// </summary>
  msoEncodingEBCDICIcelandic = 20871,
  /// <summary>
  /// EBCDIC as used with Turkish.
  /// </summary>
  msoEncodingEBCDICTurkish = 20905,
  /// <summary>
  /// EBCDIC as used with Russian.
  /// </summary>
  msoEncodingEBCDICRussian = 20880,
  /// <summary>
  /// EBCDIC as used with Serbian and Bulgarian.
  /// </summary>
  msoEncodingEBCDICSerbianBulgarian = 21025,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEBCDICJapaneseKatakanaExtendedAndJapanese = 50930,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEBCDICUSCanadaAndJapanese = 50931,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEBCDICKoreanExtendedAndKorean = 50933,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEBCDICSimplifiedChineseExtendedAndSimplifiedChinese = 50935,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEBCDICUSCanadaAndTraditionalChinese = 50937,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEBCDICJapaneseLatinExtendedAndJapanese = 50939,
  /// <summary>
  /// OEM as used in the United States.
  /// </summary>
  msoEncodingOEMUnitedStates = 437,
  /// <summary>
  /// OEM as used with Greek 437G.
  /// </summary>
  msoEncodingOEMGreek437G = 737,
  /// <summary>
  /// OEM as used with Baltic.
  /// </summary>
  msoEncodingOEMBaltic = 775,
  /// <summary>
  /// OEM as used with multi- lingual Latin I.
  /// </summary>
  msoEncodingOEMMultilingualLatinI = 850,
  /// <summary>
  /// OEM as used with multi- lingual Latin II. public enum class MsoEncoding ﾉ Expand table
  /// </summary>
  msoEncodingOEMMultilingualLatinII = 852,
  /// <summary>
  /// OEM as used with Cyrillic.
  /// </summary>
  msoEncodingOEMCyrillic = 855,
  /// <summary>
  /// OEM as used with Turkish.
  /// </summary>
  msoEncodingOEMTurkish = 857,
  /// <summary>
  /// OEM as used with Portuguese.
  /// </summary>
  msoEncodingOEMPortuguese = 860,
  /// <summary>
  /// OEM as used with Icelandic.
  /// </summary>
  msoEncodingOEMIcelandic = 861,
  /// <summary>
  /// OEM as used with Hebrew.
  /// </summary>
  msoEncodingOEMHebrew = 862,
  /// <summary>
  /// OEM as used with Canadian French.
  /// </summary>
  msoEncodingOEMCanadianFrench = 863,
  /// <summary>
  /// OEM as used with Arabic.
  /// </summary>
  msoEncodingOEMArabic = 864,
  /// <summary>
  /// OEM as used with Nordic languages.
  /// </summary>
  msoEncodingOEMNordic = 865,
  /// <summary>
  /// OEM as used with Cyrillic II.
  /// </summary>
  msoEncodingOEMCyrillicII = 866,
  /// <summary>
  /// OEM as used with Modern Greek.
  /// </summary>
  msoEncodingOEMModernGreek = 869,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEUCJapanese = 51932,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEUCChineseSimplifiedChinese = 51936,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEUCKorean = 51949,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEUCTaiwaneseTraditionalChinese = 51950,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIDevanagari = 57002,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIBengali = 57003,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIITamil = 57004,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIITelugu = 57005,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIAssamese = 57006,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIOriya = 57007,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIKannada = 57008,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIMalayalam = 57009,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIGujarati = 57010,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingISCIIPunjabi = 57011,
  /// <summary>
  /// Arabic ASMO.
  /// </summary>
  msoEncodingArabicASMO = 708,
  /// <summary>
  /// Transparent Arabic.
  /// </summary>
  msoEncodingArabicTransparentASMO = 720,
  /// <summary>
  /// Korean (Johab).
  /// </summary>
  msoEncodingKoreanJohab = 1361,
  /// <summary>
  /// Taiwan CNS.
  /// </summary>
  msoEncodingTaiwanCNS = 20000,
  /// <summary>
  /// Taiwan TCA.
  /// </summary>
  msoEncodingTaiwanTCA = 20001,
  /// <summary>
  /// Taiwan Eten.
  /// </summary>
  msoEncodingTaiwanEten = 20002,
  /// <summary>
  /// Taiwan IBM 5550.
  /// </summary>
  msoEncodingTaiwanIBM5550 = 20003,
  /// <summary>
  /// Taiwan Teletext.
  /// </summary>
  msoEncodingTaiwanTeleText = 20004,
  /// <summary>
  /// Taiwan Wang.
  /// </summary>
  msoEncodingTaiwanWang = 20005,
  /// <summary>
  /// IA5, International Reference Version (IRV).
  /// </summary>
  msoEncodingIA5IRV = 20105,
  /// <summary>
  /// German (International Alphabet No. 5, or IA5).
  /// </summary>
  msoEncodingIA5German = 20106,
  /// <summary>
  /// IA5 as used with Swedish.
  /// </summary>
  msoEncodingIA5Swedish = 20107,
  /// <summary>
  /// IA5 as used with Norwegian.
  /// </summary>
  msoEncodingIA5Norwegian = 20108,
  /// <summary>
  /// United States ASCII.
  /// </summary>
  msoEncodingUSASCII = 20127,
  /// <summary>
  /// T61.
  /// </summary>
  msoEncodingT61 = 20261,
  /// <summary>
  /// ISO 6937 Non-Spacing Accent.
  /// </summary>
  msoEncodingISO6937NonSpacingAccent = 20269,
  /// <summary>
  /// KOI8-R.
  /// </summary>
  msoEncodingKOI8R = 20866,
  /// <summary>
  /// Extended Alpha lowercase.
  /// </summary>
  msoEncodingExtAlphaLowercase = 21027,
  /// <summary>
  /// K0I8-U.
  /// </summary>
  msoEncodingKOI8U = 21866,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingEuropa3 = 29001,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingHZGBSimplifiedChinese = 52936,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingSimplifiedChineseGB18030 = 54936,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingUTF7 = 65000,
  /// <summary>
  /// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
  /// saved document.
  /// </summary>
  msoEncodingUTF8 = 65001
}
