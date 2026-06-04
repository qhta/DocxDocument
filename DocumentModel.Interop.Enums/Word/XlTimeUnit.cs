namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the unit of time for chart axes and data series.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltimeunit?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlTimeUnit")]
public enum TimeUnit
{
  /// <summary>
  /// Days
  /// </summary>
  [WordInteropEnumValue("xlDays")]
  Days = 0,
  /// <summary>
  /// Months
  /// </summary>
  [WordInteropEnumValue("xlMonths")]
  Months = 1,
  /// <summary>
  /// Years
  /// </summary>
  [WordInteropEnumValue("xlYears")]
  Years = 2
}
