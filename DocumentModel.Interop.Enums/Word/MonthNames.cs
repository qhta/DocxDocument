namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format in which to display month names.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmonthnames?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMonthNames")]
public enum MonthNames
{
  /// <summary>
  /// Arabic format.
  /// </summary>
  [WordInteropEnumValue("wdMonthNamesArabic")]
  Arabic = 0,
  /// <summary>
  /// English format.
  /// </summary>
  [WordInteropEnumValue("wdMonthNamesEnglish")]
  English = 1,
  /// <summary>
  /// French format.
  /// </summary>
  [WordInteropEnumValue("wdMonthNamesFrench")]
  French = 2
}
