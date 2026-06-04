namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a calendar type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcalendartype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdCalendarType")]
public enum CalendarType
{
  /// <summary>
  /// Western.
  /// </summary>
  [WordInteropEnumValue("wdCalendarWestern")]
  Western = 0,
  /// <summary>
  /// Arabic.
  /// </summary>
  [WordInteropEnumValue("wdCalendarArabic")]
  Arabic = 1,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [WordInteropEnumValue("wdCalendarHebrew")]
  Hebrew = 2,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdCalendarTaiwan")]
  Taiwan = 3,
  /// <summary>
  /// Japanese.
  /// </summary>
  [WordInteropEnumValue("wdCalendarJapan")]
  Japan = 4,
  /// <summary>
  /// Thai.
  /// </summary>
  [WordInteropEnumValue("wdCalendarThai")]
  Thai = 5,
  /// <summary>
  /// Korean.
  /// </summary>
  [WordInteropEnumValue("wdCalendarKorean")]
  Korean = 6,
  /// <summary>
  /// Saka Era.
  /// </summary>
  [WordInteropEnumValue("wdCalendarSakaEra")]
  SakaEra = 7,
  /// <summary>
  /// English.
  /// </summary>
  [WordInteropEnumValue("wdCalendarTranslitEnglish")]
  TranslitEnglish = 8,
  /// <summary>
  /// French.
  /// </summary>
  [WordInteropEnumValue("wdCalendarTranslitFrench")]
  TranslitFrench = 9,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdCalendarUmalqura")]
  Umalqura = 13
}
