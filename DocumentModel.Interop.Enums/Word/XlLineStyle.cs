namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line style for the border.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xllinestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlLineStyle")]
public enum XlLineStyle
{
  /// <summary>
  /// Continuous line.
  /// </summary>
  [WordInteropEnumValue("xlContinuous")]
  Continuous = 1,
  /// <summary>
  /// Alternating dashes and dots.
  /// </summary>
  [WordInteropEnumValue("xlDashDot")]
  DashDot = 4,
  /// <summary>
  /// Dash followed by two dots.
  /// </summary>
  [WordInteropEnumValue("xlDashDotDot")]
  DashDotDot = 5,
  /// <summary>
  /// Slanted dashes.
  /// </summary>
  [WordInteropEnumValue("xlSlantDashDot")]
  SlantDashDot = 13,
  /// <summary>
  /// No line.
  /// </summary>
  [WordInteropEnumValue("xlLineStyleNone")]
  LineStyleNone = -4142,
  /// <summary>
  /// Double line.
  /// </summary>
  [WordInteropEnumValue("xlDouble")]
  Double = -4119,
  /// <summary>
  /// Dotted line.
  /// </summary>
  [WordInteropEnumValue("xlDot")]
  Dot = -4118,
  /// <summary>
  /// Dashed line.
  /// </summary>
  [WordInteropEnumValue("xlDash")]
  Dash = -4115
}
