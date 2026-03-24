namespace DocumentModel.Interop.Word;

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
  /// Specifies the line style for the border.
  /// </summary>
  LineStyleNone = -4142,
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  Double = -4119,
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  Dot = -4118,
  /// <summary>
  /// Specifies the line style for the border.
  /// </summary>
  Dash = -4115
}
