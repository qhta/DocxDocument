namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the line style for the border.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xllinestyle?view=office-pia` for Office interop details.
/// </remarks>
public enum XlLineStyle
{
  /// <summary>
  /// Continuous line.
  /// </summary>
  Continuous = 1,
  /// <summary>
  /// Alternating dashes and dots.
  /// </summary>
  DashDot = 4,
  /// <summary>
  /// Dash followed by two dots.
  /// </summary>
  DashDotDot = 5,
  /// <summary>
  /// Slanted dashes.
  /// </summary>
  SlantDashDot = 13,
  /// <summary>
  /// No line.
  /// </summary>
  LineStyleNone = -4142,
  /// <summary>
  /// Double line.
  /// </summary>
  Double = -4119,
  /// <summary>
  /// Dotted line.
  /// </summary>
  Dot = -4118,
  /// <summary>
  /// Dashed line.
  /// </summary>
  Dash = -4115
}

