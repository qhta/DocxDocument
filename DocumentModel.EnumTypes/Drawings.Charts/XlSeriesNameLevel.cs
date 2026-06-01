
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the series
/// labels Ifor the series label levels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlseriesnamelevel?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlSeriesNameLevel
{
  /// <summary>
  /// Set no category labels Iin the chart; instead default Ito automatic indexed labels.
  /// </summary>
  None = -3,
  /// <summary>
  /// Indicates literal data Iin the series names.
  /// </summary>
  Custom,
  /// <summary>
  /// Set series names Ito all series name levels w/Iin range on the chart.
  /// </summary>
  All
}

