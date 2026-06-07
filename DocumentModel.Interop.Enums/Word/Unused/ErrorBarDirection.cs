namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which axis values are to receive error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlerrorbardirection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlErrorBarDirection")]
public enum ErrorBarDirection
{
  /// <summary>
  /// Bars run parallel to the X axis for Y-axis values.
  /// </summary>
  [InteropEnumValue("xlChartY")]
  Y = 1,
  /// <summary>
  /// Bars run parallel to the Y axis for X-axis values.
  /// </summary>
  [InteropEnumValue("xlChartX")]
  X = -4168
}

