
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of the chart element.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartelementposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartElementPosition
{
  /// <summary>
  /// Automatically sets the position of the chart element.
  /// </summary>
  Automatic = -4105,
  /// <summary>
  /// Specifies a specific position for the chart element.
  /// </summary>
  Custom = -4114
}

