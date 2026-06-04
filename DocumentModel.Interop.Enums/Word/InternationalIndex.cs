namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies information specific to the current country/region and international settings.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinternationalindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdInternationalIndex")]
public enum InternationalIndex
{
  /// <summary>
  /// Returns the list separator (, in U.S. English).
  /// </summary>
  [InteropEnumValue("wdListSeparator")]
  ListSeparator = 17,
  /// <summary>
  /// Returns the decimal separator (. in U.S. English).
  /// </summary>
  [InteropEnumValue("wdDecimalSeparator")]
  DecimalSeparator = 18,
  /// <summary>
  /// Returns the thousands separator (, in U.S. English).
  /// </summary>
  [InteropEnumValue("wdThousandsSeparator")]
  ThousandsSeparator = 19,
  /// <summary>
  /// Returns the currency symbol ($ in U.S. English).
  /// </summary>
  [InteropEnumValue("wdCurrencyCode")]
  CurrencyCode = 20,
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  [InteropEnumValue("wd24HourClock")]
  TwentyFourHourClock = 21,
  /// <summary>
  /// Returns the string used to indicate morning hours (for example, 10 AM).
  /// </summary>
  [InteropEnumValue("wdInternationalAM")]
  InternationalAM = 22,
  /// <summary>
  /// Returns the string used to indicate afternoon and evening hours (for example, 2 PM).
  /// </summary>
  [InteropEnumValue("wdInternationalPM")]
  InternationalPM = 23,
  /// <summary>
  /// Returns the time separator (: in U.S. English).
  /// </summary>
  [InteropEnumValue("wdTimeSeparator")]
  TimeSeparator = 24,
  /// <summary>
  /// Returns the date separator (/ in U.S. English).
  /// </summary>
  [InteropEnumValue("wdDateSeparator")]
  DateSeparator = 25,
  /// <summary>
  /// Returns the language version of Word.
  /// </summary>
  [InteropEnumValue("wdProductLanguageID")]
  ProductLanguageID = 26
}
