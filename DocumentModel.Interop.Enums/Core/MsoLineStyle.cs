namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a line.
/// </summary>
public enum MsoLineStyle
{
  /// <summary>
  /// Specifies the style for a line.
  /// </summary>
  msoLineStyleMixed = -2,
  /// <summary>
  /// Single line.
  /// </summary>
  msoLineSingle = 1,
  /// <summary>
  /// Two thin lines.
  /// </summary>
  msoLineThinThin = 2,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is below thin line. For vertical lines, thick
  /// line is to the right of the thin line.
  /// </summary>
  msoLineThinThick = 3,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is above thin line. For vertical lines, thick
  /// line is to the left of the thin line. msoLineThickBetweenThin5 Thick line with a thin line on each side.
  /// </summary>
  msoLineThickThin = 4,
  /// <summary>
  /// Specifies the style for a line.
  /// </summary>
  msoLineThickBetweenThin = 5
}
