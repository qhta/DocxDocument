namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies calendar type to use when displaying the date or time.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcalendartypebi?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdCalendarTypeBi")]
public enum CalendarTypeBi
{
  /// <summary>
  /// Bi-directional calendar.
  /// </summary>
  [WordInteropEnumValue("wdCalendarTypeBidi")]
  Bidi = 99,
  /// <summary>
  /// Gregorian calendar.
  /// </summary>
  [WordInteropEnumValue("wdCalendarTypeGregorian")]
  Gregorian = 100
}
