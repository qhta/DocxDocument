namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a calendar type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcalendartype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCalendarType")]
public enum CalendarType
{
  /// <summary>
  /// Western.
  /// </summary>
  [InteropEnumValue("wdCalendarWestern")]
  Western = 0,
  /// <summary>
  /// Arabic.
  /// </summary>
  [InteropEnumValue("wdCalendarArabic")]
  Arabic = 1,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [InteropEnumValue("wdCalendarHebrew")]
  Hebrew = 2,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdCalendarTaiwan")]
  Taiwan = 3,
  /// <summary>
  /// Japanese.
  /// </summary>
  [InteropEnumValue("wdCalendarJapan")]
  Japan = 4,
  /// <summary>
  /// Thai.
  /// </summary>
  [InteropEnumValue("wdCalendarThai")]
  Thai = 5,
  /// <summary>
  /// Korean.
  /// </summary>
  [InteropEnumValue("wdCalendarKorean")]
  Korean = 6,
  /// <summary>
  /// Saka Era.
  /// </summary>
  [InteropEnumValue("wdCalendarSakaEra")]
  SakaEra = 7,
  /// <summary>
  /// English.
  /// </summary>
  [InteropEnumValue("wdCalendarTranslitEnglish")]
  TranslitEnglish = 8,
  /// <summary>
  /// French.
  /// </summary>
  [InteropEnumValue("wdCalendarTranslitFrench")]
  TranslitFrench = 9,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdCalendarUmalqura")]
  Umalqura = 13
}
