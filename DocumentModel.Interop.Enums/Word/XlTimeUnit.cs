namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the unit of time for chart axes and data series.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltimeunit?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlTimeUnit))]
public enum TimeUnit
{
  /// <summary>
  /// Days
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTimeUnit.xlDays))]
  Days = 0,
  /// <summary>
  /// Months
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTimeUnit.xlMonths))]
  Months = 1,
  /// <summary>
  /// Years
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTimeUnit.xlYears))]
  Years = 2
}
