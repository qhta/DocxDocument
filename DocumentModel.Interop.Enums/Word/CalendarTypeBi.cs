namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies calendar type to use when displaying the date or time.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcalendartypebi?view=office-pia` for Office interop details.
/// </remarks>
public enum CalendarTypeBi
{
  /// <summary>
  /// Bi-directional calendar.
  /// </summary>
  Bidi = 99,
  /// <summary>
  /// Gregorian calendar.
  /// </summary>
  Gregorian = 100
}
