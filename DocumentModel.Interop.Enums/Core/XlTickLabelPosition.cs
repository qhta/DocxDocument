
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of tick-mark labels on the specified axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlticklabelposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlTickLabelPosition
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Top or right side of
  /// the chart.
  /// </summary>
  High = -4127,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Bottom or left side
  /// of the chart.
  /// </summary>
  Low = -4134,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Next to axis (where
  /// axis is not at either side of the chart).
  /// </summary>
  NextToAxis = 4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). No tick marks.
  /// </summary>
  None = -4142
}
