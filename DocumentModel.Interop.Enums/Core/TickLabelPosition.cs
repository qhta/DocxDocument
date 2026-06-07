
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of tick-mark labels on the specified axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlticklabelposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlTickLabelPosition")]
public enum TickLabelPosition
{
  /// <summary>
  /// Top or right side of the chart.
  /// </summary>
  [InteropEnumValue("xlTickLabelPositionHigh")]
  High = -4127,
  /// <summary>
  /// Bottom or left side of the chart.
  /// </summary>
  [InteropEnumValue("xlTickLabelPositionLow")]
  Low = -4134,
  /// <summary>
  /// Next to axis (where axis is not at either side of the chart).
  /// </summary>
  [InteropEnumValue("xlTickLabelPositionNextToAxis")]
  NextToAxis = 4,
  /// <summary>
  /// No tick marks.
  /// </summary>
  [InteropEnumValue("xlTickLabelPositionNone")]
  None = -4142
}
