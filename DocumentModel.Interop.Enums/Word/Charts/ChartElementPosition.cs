namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of the chart element.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartelementposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlChartElementPosition")]
public enum ChartElementPosition
{
  /// <summary>
  /// Specifies a specific position for the chart element.
  /// </summary>
  [InteropEnumValue("xlChartElementPositionCustom")]
  Custom = -4114,
  /// <summary>
  /// Automatically sets the position of the chart element.
  /// </summary>
  [InteropEnumValue("xlChartElementPositionAutomatic")]
  Automatic = -4105
}

