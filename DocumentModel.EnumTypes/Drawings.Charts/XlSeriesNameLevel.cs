
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the series
/// labels for the series label levels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlseriesnamelevel?view=office-pia` for Office interop details.
/// </remarks>
public enum XlSeriesNameLevel
{
  /// <summary>
  /// Set no category labels in the chart; instead default Ito automatic indexed labels.
  /// </summary>
  None = -3,
  /// <summary>
  /// Indicates literal data in the series names.
  /// </summary>
  Custom,
  /// <summary>
  /// Set series names Ito all series name levels w/in range on the chart.
  /// </summary>
  All
}

