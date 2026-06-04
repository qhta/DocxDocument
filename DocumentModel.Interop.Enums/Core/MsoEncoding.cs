namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the document encoding (code page or character set) for the Web browser to use when a user views a
/// saved document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoencoding?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoEncoding))]
public enum Encoding
{
  /// <summary>
  /// Thai.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingThai))]
  Thai = 874,
  /// <summary>
  /// Japanese (Shift-JIS).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingJapaneseShiftJIS))]
  JapaneseShiftJIS = 932,
  /// <summary>
  /// Simplified Chinese GBK.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingSimplifiedChineseGBK))]
  SimplifiedChineseGBK = 936,
  /// <summary>
  /// Korean.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingKorean))]
  Korean = 949,
  /// <summary>
  /// Traditional Chinese Big 5.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTraditionalChineseBig5))]
  TraditionalChineseBig5 = 950,
  /// <summary>
  /// Unicode little endian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingUnicodeLittleEndian))]
  UnicodeLittleEndian = 1200,
  /// <summary>
  /// Unicode big endian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingUnicodeBigEndian))]
  UnicodeBigEndian = 1201,
  /// <summary>
  /// Central European.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingCentralEuropean))]
  CentralEuropean = 1250,
  /// <summary>
  /// Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingCyrillic))]
  Cyrillic = 1251,
  /// <summary>
  /// Western.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingWestern))]
  Western = 1252,
  /// <summary>
  /// Greek.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingGreek))]
  Greek = 1253,
  /// <summary>
  /// Turkish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTurkish))]
  Turkish = 1254,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingHebrew))]
  Hebrew = 1255,
  /// <summary>
  /// Arabic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingArabic))]
  Arabic = 1256,
  /// <summary>
  /// Baltic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingBaltic))]
  Baltic = 1257,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingVietnamese))]
  Vietnamese = 1258,
  /// <summary>
  /// Web browser auto- detects type of encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingAutoDetect))]
  AutoDetect = 50001,
  /// <summary>
  /// Web browser auto- detects type of Japanese encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingJapaneseAutoDetect))]
  JapaneseAutoDetect = 50932,
  /// <summary>
  /// Web browser auto- detects type of Simplified Chinese encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingSimplifiedChineseAutoDetect))]
  SimplifiedChineseAutoDetect = 50936,
  /// <summary>
  /// Web browser auto- detects type of Korean encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingKoreanAutoDetect))]
  KoreanAutoDetect = 50949,
  /// <summary>
  /// Web browser auto- detects type of Traditional Chinese encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTraditionalChineseAutoDetect))]
  TraditionalChineseAutoDetect = 50950,
  /// <summary>
  /// Web browser auto- detects type of Cyrillic encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingCyrillicAutoDetect))]
  CyrillicAutoDetect = 51251,
  /// <summary>
  /// Web browser auto- detects type of Greek encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingGreekAutoDetect))]
  GreekAutoDetect = 51253,
  /// <summary>
  /// Web browser auto- detects type of Arabic encoding to use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingArabicAutoDetect))]
  ArabicAutoDetect = 51256,
  /// <summary>
  /// ISO 8859-1 Latin 1.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88591Latin1))]
  ISO88591Latin1 = 28591,
  /// <summary>
  /// ISO 8859-2 Central Europe.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88592CentralEurope))]
  ISO88592CentralEurope = 28592,
  /// <summary>
  /// ISO 8859-3 Latin 3.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88593Latin3))]
  ISO88593Latin3 = 28593,
  /// <summary>
  /// ISO 8859-4 Baltic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88594Baltic))]
  ISO88594Baltic = 28594,
  /// <summary>
  /// ISO 8859-5 Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88595Cyrillic))]
  ISO88595Cyrillic = 28595,
  /// <summary>
  /// ISA 8859-6 Arabic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88596Arabic))]
  ISO88596Arabic = 28596,
  /// <summary>
  /// ISO 8859-7 Greek.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88597Greek))]
  ISO88597Greek = 28597,
  /// <summary>
  /// ISO 8859-8 Hebrew.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88598Hebrew))]
  ISO88598Hebrew = 28598,
  /// <summary>
  /// ISO 8859-9 Turkish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88599Turkish))]
  ISO88599Turkish = 28599,
  /// <summary>
  /// ISO 8859-15 with Latin 9.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO885915Latin9))]
  ISO885915Latin9 = 28605,
  /// <summary>
  /// ISO 8859-8 Hebrew (Logical).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO88598HebrewLogical))]
  ISO88598HebrewLogical = 38598,
  /// <summary>
  /// ISO 2022-JP with no half-width Katakana.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO2022JPNoHalfwidthKatakana))]
  ISO2022JPNoHalfwidthKatakana = 50220,
  /// <summary>
  /// ISO 2022-JP
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO2022JPJISX02021984))]
  ISO2022JPJISX02021984 = 50221,
  /// <summary>
  /// ISO 2022-JP
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO2022JPJISX02011989))]
  ISO2022JPJISX02011989 = 50222,
  /// <summary>
  /// ISO 2022-KR.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO2022KR))]
  ISO2022KR = 50225,
  /// <summary>
  /// ISO 2022-CN encoding as used with Traditional Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO2022CNTraditionalChinese))]
  ISO2022CNTraditionalChinese = 50227,
  /// <summary>
  /// ISO 2022-CN encoding as used with Simplified Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO2022CNSimplifiedChinese))]
  ISO2022CNSimplifiedChinese = 50229,
  /// <summary>
  /// Macintosh Roman.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacRoman))]
  MacRoman = 10000,
  /// <summary>
  /// Macintosh Japanese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacJapanese))]
  MacJapanese = 10001,
  /// <summary>
  /// Macintosh Traditional Chinese (Big 5).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacTraditionalChineseBig5))]
  MacTraditionalChineseBig5 = 10002,
  /// <summary>
  /// Macintosh Korean.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacKorean))]
  MacKorean = 10003,
  /// <summary>
  /// Macintosh Arabic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacArabic))]
  MacArabic = 10004,
  /// <summary>
  /// Macintosh Hebrew.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacHebrew))]
  MacHebrew = 10005,
  /// <summary>
  /// Macintosh Greek.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacGreek1))]
  MacGreek1 = 10006,
  /// <summary>
  /// Macintosh Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacCyrillic))]
  MacCyrillic = 10007,
  /// <summary>
  /// Macintosh Simplified Chinese (GB 2312).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacSimplifiedChineseGB2312))]
  MacSimplifiedChineseGB2312 = 10008,
  /// <summary>
  /// Macintosh Romanian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacRomania))]
  MacRomania = 10010,
  /// <summary>
  /// Macintosh Ukrainian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacUkraine))]
  MacUkraine = 10017,
  /// <summary>
  /// Macintosh Latin 2.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacLatin2))]
  MacLatin2 = 10029,
  /// <summary>
  /// Macintosh Icelandic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacIcelandic))]
  MacIcelandic = 10079,
  /// <summary>
  /// Macintosh Turkish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacTurkish))]
  MacTurkish = 10081,
  /// <summary>
  /// Macintosh Croatian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingMacCroatia))]
  MacCroatia = 10082,
  /// <summary>
  /// EBCDIC as used in the United States and Canada.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICUSCanada))]
  EBCDICUSCanada = 37,
  /// <summary>
  /// International EBCDIC.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICInternational))]
  EBCDICInternational = 500,
  /// <summary>
  /// EBCDIC Multilingual ROECE (Latin 2).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICMultilingualROECELatin2))]
  EBCDICMultilingualROECELatin2 = 870,
  /// <summary>
  /// EBCDIC as used in the Modern Greek language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICGreekModern))]
  EBCDICGreekModern = 875,
  /// <summary>
  /// EBCDIC as used with Turkish (Latin 5).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICTurkishLatin5))]
  EBCDICTurkishLatin5 = 1026,
  /// <summary>
  /// EBCDIC as used in Germany.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICGermany))]
  EBCDICGermany = 20273,
  /// <summary>
  /// EBCDIC as used in Denmark and Norway.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICDenmarkNorway))]
  EBCDICDenmarkNorway = 20277,
  /// <summary>
  /// EBCDIC as used in Finland and Sweden.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICFinlandSweden))]
  EBCDICFinlandSweden = 20278,
  /// <summary>
  /// EBCDIC as used in Italy.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICItaly))]
  EBCDICItaly = 20280,
  /// <summary>
  /// EBCDIC as used in Latin America and Spain.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICLatinAmericaSpain))]
  EBCDICLatinAmericaSpain = 20284,
  /// <summary>
  /// EBCDIC as used in the United Kingdom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICUnitedKingdom))]
  EBCDICUnitedKingdom = 20285,
  /// <summary>
  /// EBCDIC as used with Japanese Katakana (extended).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICJapaneseKatakanaExtended))]
  EBCDICJapaneseKatakanaExtended = 20290,
  /// <summary>
  /// EBCDIC as used in France.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICFrance))]
  EBCDICFrance = 20297,
  /// <summary>
  /// Extended Binary Coded Decimal Interchange Code (EBCDIC) Arabic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICArabic))]
  EBCDICArabic = 20420,
  /// <summary>
  /// EBCDIC as used in the Greek language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICGreek))]
  EBCDICGreek = 20423,
  /// <summary>
  /// EBCDIC as used in the Hebrew language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICHebrew))]
  EBCDICHebrew = 20424,
  /// <summary>
  /// EBCDIC as used with Korean (extended).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICKoreanExtended))]
  EBCDICKoreanExtended = 20833,
  /// <summary>
  /// EBCDIC as used with Thai.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICThai))]
  EBCDICThai = 20838,
  /// <summary>
  /// EBCDIC as used in Iceland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICIcelandic))]
  EBCDICIcelandic = 20871,
  /// <summary>
  /// EBCDIC as used with Turkish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICTurkish))]
  EBCDICTurkish = 20905,
  /// <summary>
  /// EBCDIC as used with Russian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICRussian))]
  EBCDICRussian = 20880,
  /// <summary>
  /// EBCDIC as used with Serbian and Bulgarian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICSerbianBulgarian))]
  EBCDICSerbianBulgarian = 21025,
  /// <summary>
  /// EBCDIC as used with Japanese Katakana (extended) and Japanese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICJapaneseKatakanaExtendedAndJapanese))]
  EBCDICJapaneseKatakanaExtendedAndJapanese = 50930,
  /// <summary>
  /// EBCDIC as used in the United States and Canada, and with Japanese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICUSCanadaAndJapanese))]
  EBCDICUSCanadaAndJapanese = 50931,
  /// <summary>
  /// EBCDIC as used with Korean (extended) and Korean.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICKoreanExtendedAndKorean))]
  EBCDICKoreanExtendedAndKorean = 50933,
  /// <summary>
  /// EBCDIC as used with Simplified Chinese (extended) and Simplified Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICSimplifiedChineseExtendedAndSimplifiedChinese))]
  EBCDICSimplifiedChineseExtendedAndSimplifiedChinese = 50935,
  /// <summary>
  /// EBCDIC as used in the United States and Canada, and with Traditional Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICUSCanadaAndTraditionalChinese))]
  EBCDICUSCanadaAndTraditionalChinese = 50937,
  /// <summary>
  /// EBCDIC as used with Japanese Latin (extended) and Japanese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEBCDICJapaneseLatinExtendedAndJapanese))]
  EBCDICJapaneseLatinExtendedAndJapanese = 50939,
  /// <summary>
  /// OEM as used in the United States.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMUnitedStates))]
  OEMUnitedStates = 437,
  /// <summary>
  /// OEM as used with Greek 437G.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMGreek437G))]
  OEMGreek437G = 737,
  /// <summary>
  /// OEM as used with Baltic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMBaltic))]
  OEMBaltic = 775,
  /// <summary>
  /// OEM as used with multi- lingual Latin I.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMMultilingualLatinI))]
  OEMMultilingualLatinI = 850,
  /// <summary>
  /// OEM as used with multi- lingual Latin II.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMMultilingualLatinII))]
  OEMMultilingualLatinII = 852,
  /// <summary>
  /// OEM as used with Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMCyrillic))]
  OEMCyrillic = 855,
  /// <summary>
  /// OEM as used with Turkish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMTurkish))]
  OEMTurkish = 857,
  /// <summary>
  /// OEM as used with Portuguese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMPortuguese))]
  OEMPortuguese = 860,
  /// <summary>
  /// OEM as used with Icelandic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMIcelandic))]
  OEMIcelandic = 861,
  /// <summary>
  /// OEM as used with Hebrew.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMHebrew))]
  OEMHebrew = 862,
  /// <summary>
  /// OEM as used with Canadian French.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMCanadianFrench))]
  OEMCanadianFrench = 863,
  /// <summary>
  /// OEM as used with Arabic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMArabic))]
  OEMArabic = 864,
  /// <summary>
  /// OEM as used with Nordic languages.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMNordic))]
  OEMNordic = 865,
  /// <summary>
  /// OEM as used with Cyrillic II.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMCyrillicII))]
  OEMCyrillicII = 866,
  /// <summary>
  /// OEM as used with Modern Greek.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingOEMModernGreek))]
  OEMModernGreek = 869,
  /// <summary>
  /// EUC as used with Japanese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEUCJapanese))]
  EUCJapanese = 51932,
  /// <summary>
  /// Extended Unix Code (EUC) as used with Chinese and Simplified Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEUCChineseSimplifiedChinese))]
  EUCChineseSimplifiedChinese = 51936,
  /// <summary>
  /// EUC as used with Korean.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEUCKorean))]
  EUCKorean = 51949,
  /// <summary>
  /// EUC as used with Taiwanese and Traditional Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEUCTaiwaneseTraditionalChinese))]
  EUCTaiwaneseTraditionalChinese = 51950,
  /// <summary>
  /// ISCII as used with Devanagari.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIDevanagari))]
  ISCIIDevanagari = 57002,
  /// <summary>
  /// ISCII as used with Bengali.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIBengali))]
  ISCIIBengali = 57003,
  /// <summary>
  /// ISCII as used with Tamil.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIITamil))]
  ISCIITamil = 57004,
  /// <summary>
  /// ISCII as used with Telugu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIITelugu))]
  ISCIITelugu = 57005,
  /// <summary>
  /// Indian Script Code for Information Interchange (ISCII) as used with Assamese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIAssamese))]
  ISCIIAssamese = 57006,
  /// <summary>
  /// ISCII as used with Oriya.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIOriya))]
  ISCIIOriya = 57007,
  /// <summary>
  /// ISCII as used with Kannada.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIKannada))]
  ISCIIKannada = 57008,
  /// <summary>
  /// ISCII as used with Malayalam.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIMalayalam))]
  ISCIIMalayalam = 57009,
  /// <summary>
  /// ISCII as used with Gujarati.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIGujarati))]
  ISCIIGujarati = 57010,
  /// <summary>
  /// ISCII as used with Punjabi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISCIIPunjabi))]
  ISCIIPunjabi = 57011,
  /// <summary>
  /// Arabic ASMO.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingArabicASMO))]
  ArabicASMO = 708,
  /// <summary>
  /// Transparent Arabic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingArabicTransparentASMO))]
  ArabicTransparentASMO = 720,
  /// <summary>
  /// Korean (Johab).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingKoreanJohab))]
  KoreanJohab = 1361,
  /// <summary>
  /// Taiwan CNS.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTaiwanCNS))]
  TaiwanCNS = 20000,
  /// <summary>
  /// Taiwan TCA.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTaiwanTCA))]
  TaiwanTCA = 20001,
  /// <summary>
  /// Taiwan Eten.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTaiwanEten))]
  TaiwanEten = 20002,
  /// <summary>
  /// Taiwan IBM 5550.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTaiwanIBM5550))]
  TaiwanIBM5550 = 20003,
  /// <summary>
  /// Taiwan Teletext.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTaiwanTeleText))]
  TaiwanTeleText = 20004,
  /// <summary>
  /// Taiwan Wang.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingTaiwanWang))]
  TaiwanWang = 20005,
  /// <summary>
  /// IA5, International Reference Version (IRV).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingIA5IRV))]
  IA5IRV = 20105,
  /// <summary>
  /// German (International Alphabet No. 5, or IA5).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingIA5German))]
  IA5German = 20106,
  /// <summary>
  /// IA5 as used with Swedish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingIA5Swedish))]
  IA5Swedish = 20107,
  /// <summary>
  /// IA5 as used with Norwegian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingIA5Norwegian))]
  IA5Norwegian = 20108,
  /// <summary>
  /// United States ASCII.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingUSASCII))]
  USASCII = 20127,
  /// <summary>
  /// T61.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingT61))]
  T61 = 20261,
  /// <summary>
  /// ISO 6937 Non-Spacing Accent.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingISO6937NonSpacingAccent))]
  ISO6937NonSpacingAccent = 20269,
  /// <summary>
  /// KOI8-R.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingKOI8R))]
  KOI8R = 20866,
  /// <summary>
  /// Extended Alpha lowercase.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingExtAlphaLowercase))]
  ExtAlphaLowercase = 21027,
  /// <summary>
  /// K0I8-U.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingKOI8U))]
  KOI8U = 21866,
  /// <summary>
  /// Europa.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingEuropa3))]
  Europa3 = 29001,
  /// <summary>
  /// Simplified Chinese (HZGB).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingHZGBSimplifiedChinese))]
  HZGBSimplifiedChinese = 52936,
  /// <summary>
  /// Simplified Chinese GB 18030.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingSimplifiedChineseGB18030))]
  SimplifiedChineseGB18030 = 54936,
  /// <summary>
  /// UTF-7 encoding.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingUTF7))]
  UTF7 = 65000,
  /// <summary>
  /// UTF-8 encoding.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoEncoding.msoEncodingUTF8))]
  UTF8 = 65001
}
