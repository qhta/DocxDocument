namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line style for the border.
/// </summary>
public enum XlLineStyle
{
  /// <summary>
  /// Continuous line.
  /// </summary>
  Continuous = unchecked((int)1),
  /// <summary>
  /// Alternating dashes and dots.
  /// </summary>
  DashDot = unchecked((int)4),
  /// <summary>
  /// Dash followed by two dots.
  /// </summary>
  DashDotDot = unchecked((int)5),
  /// <summary>
  /// Slanted dashes.
  /// </summary>
  SlantDashDot = unchecked((int)13),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  LineStyleNone = unchecked((int)-4142),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  Double = unchecked((int)-4119),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  Dot = unchecked((int)-4118),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  Dash = unchecked((int)-4115)
}
