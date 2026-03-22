namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of tick-mark labels on the specified axis.
/// </summary>
public enum XlTickLabelPosition
{
  /// <summary>
  /// Next to axis (where axis is not at either side of the chart).
  /// </summary>
  xlTickLabelPositionNextToAxis = unchecked((int)4),
  /// <summary>
  /// Specifies the position of tick-mark labels on the specified axis.
  /// </summary>
  xlTickLabelPositionNone = unchecked((int)-4142),
  /// <summary>
  /// Specifies the position of tick-mark labels on the specified axis.
  /// </summary>
  xlTickLabelPositionLow = unchecked((int)-4134),
  /// <summary>
  /// Specifies the position of tick-mark labels on the specified axis.
  /// </summary>
  xlTickLabelPositionHigh = unchecked((int)-4127)
}
