
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of the legend on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xllegendposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlLegendPosition
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Below the chart.
  /// </summary>
  Bottom = -4107,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). In the upper
  /// right-hand corner of the chart border. public enum class XlLegendPosition
  /// </summary>
  Corner = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Left of the chart.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Right of the chart.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Above the chart.
  /// </summary>
  Top = -4160,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). A custom position.
  /// </summary>
  Custom = -4161
}
