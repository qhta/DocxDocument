namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line style for the border.
/// </summary>
public enum XlLineStyle
{
  /// <summary>
  /// Continuous line.
  /// </summary>
  xlContinuous = unchecked((int)1),
  /// <summary>
  /// Alternating dashes and dots.
  /// </summary>
  xlDashDot = unchecked((int)4),
  /// <summary>
  /// Dash followed by two dots.
  /// </summary>
  xlDashDotDot = unchecked((int)5),
  /// <summary>
  /// Slanted dashes.
  /// </summary>
  xlSlantDashDot = unchecked((int)13),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  xlLineStyleNone = unchecked((int)-4142),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  xlDouble = unchecked((int)-4119),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  xlDot = unchecked((int)-4118),
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  xlDash = unchecked((int)-4115)
}
