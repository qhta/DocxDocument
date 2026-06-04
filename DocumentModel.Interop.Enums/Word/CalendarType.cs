namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a calendar type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcalendartype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCalendarType))]
public enum CalendarType
{
  /// <summary>
  /// Western.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarWestern))]
  Western = 0,
  /// <summary>
  /// Arabic.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarArabic))]
  Arabic = 1,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarHebrew))]
  Hebrew = 2,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarTaiwan))]
  Taiwan = 3,
  /// <summary>
  /// Japanese.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarJapan))]
  Japan = 4,
  /// <summary>
  /// Thai.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarThai))]
  Thai = 5,
  /// <summary>
  /// Korean.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarKorean))]
  Korean = 6,
  /// <summary>
  /// Saka Era.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarSakaEra))]
  SakaEra = 7,
  /// <summary>
  /// English.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarTranslitEnglish))]
  TranslitEnglish = 8,
  /// <summary>
  /// French.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarTranslitFrench))]
  TranslitFrench = 9,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCalendarType.wdCalendarUmalqura))]
  Umalqura = 13
}
